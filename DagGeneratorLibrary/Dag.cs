using System.Collections.Generic;
using System.Text;

namespace DagGeneratorLibrary
{
    public class Dag
    {
        private DagInformation dagInformation;
        public int CpTime { get;  private set; } = 0;
        public List<DagEdge> CriticalNodes { get; private set; }
        public List<DagNode> GraphNodes { set; get; }
        private  HashSet<DagEdge> DagEdgeSet = new HashSet<DagEdge>();

        public Dag(DagInformation dagInformation)
        {
            this.dagInformation = dagInformation;
        }

        public DagEdge InsertEdge(DagNode prevNode, DagNode nextNode, int commTime)
        {
            DagEdge newEdge = FindEdge(prevNode, nextNode);
            if (newEdge is null)
            {
                newEdge = new DagEdge(prevNode, nextNode, commTime);
                prevNode.NextEdges.Add(newEdge);
                nextNode.PrevEdges.Add(newEdge);
                DagEdgeSet.Add(newEdge);
                return newEdge;
            }
            return newEdge;
        }

        public void GetCriticalPath()
        {
            CriticalNodes = CriticalPath(GraphNodes[0], 0, new List<DagEdge>());
            foreach(DagEdge edge in CriticalNodes)
            {
                edge.CriticalPath = true;
            }
        }

        private List<DagEdge> CriticalPath(DagNode node, int time, List<DagEdge> currList)
        {
            if (node.Id == GraphNodes.Count)
            {
                return null;
            }
            int maxTime = time + node.CompTime;
            List<DagEdge> edgeList = new List<DagEdge>();
            edgeList.AddRange(node.NextEdges);
            for (int i = 0; i < edgeList.Count; i++)
            {
                List<DagEdge> edgeListCopy = new List<DagEdge>();
                for (int j = 0; j < currList.Count; j++)
                {
                    edgeListCopy.Add(currList[j]);
                }
                edgeListCopy.Add(edgeList[i]);
                CriticalPath(edgeList[i].NextNode, edgeList[i].CommTime + maxTime, edgeListCopy);
                if (maxTime > CpTime)
                {
                    CpTime = maxTime;
                    CriticalNodes = edgeListCopy;
                }
            }
            return CriticalNodes;
        }

        public DagEdge FindEdge(DagNode prevNode, DagNode nextNode)
        {
            foreach (DagEdge edge in DagEdgeSet)
            {
                if (edge.PrevNode == prevNode && edge.NextNode == nextNode)
                {
                    return edge;
                }
            }
            return null;
        }

        public HashSet<DagEdge> GetDagEdgeSet()
        {
            foreach (DagEdge e in DagEdgeSet)
            {
                if (e.CriticalPath)
                {
                    e.NextNode.CriticalPath = true;
                    e.PrevNode.CriticalPath = true;
                }
            }
            return DagEdgeSet;
        }

        public HashSet<DagNode> GetNodes()
        {
            HashSet<DagNode> nodes = new HashSet<DagNode>();
           
            return nodes;
        }

        public string ToString()
        {
            StringBuilder str = new StringBuilder();
            List<DagNode> nodes = new List<DagNode>(GetNodes());
            nodes.Sort();
            str.Append(nodes.Count).Append("\n");
            foreach (DagNode node in nodes)
            {
                node.UpdateDependencies();
                str.Append(node.ToString());
            }
            return str.ToString();
        }
    }
}