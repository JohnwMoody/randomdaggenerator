using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DagGenerator.App_Code
{
    public class DagNode : IComparable<DagNode>
    {
        public int Id { get; private set; }
        public int CompTime { get; private set; }
        public HashSet<DagEdge> PrevEdges { get; } = new HashSet<DagEdge>();
        public HashSet<DagEdge> NextEdges { get; } = new HashSet<DagEdge>();
        public Dictionary<int, int> Dependencies { get; } = new Dictionary<int, int>();
        public int LayerNumber { get; private set; }
        public bool CriticalPath { get; set; } = false;
        
        public DagNode(int id, int compTime, int layerNumber)
        {
            Id = id;
            CompTime = compTime;
            LayerNumber = layerNumber;
        }

        public SortedSet<DagNode> GetNextNodes()
        {
            SortedSet<DagNode> nextNodes = new SortedSet<DagNode>();
            foreach (DagEdge nextEdge in NextEdges)
            {
                nextNodes.Add(nextEdge.NextNode);
            }
            return nextNodes;
        }

        public int CompareTo(DagNode other)
        {
            return Id - other.Id;
        }

        public void UpdateDependencies()
        {
            foreach (DagEdge edge in PrevEdges)
            {
                if (!Dependencies.ContainsKey(edge.PrevNode.Id))
                {
                    Dependencies.Add(edge.PrevNode.Id, edge.CommTime);
                }
            }
        }

        public string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Id.ToString() + " " + CompTime + " " + Dependencies.Count + "\n");
            foreach(int dg in Dependencies.Keys)
            {
                str.Append("\t" + dg + " " + Dependencies[dg] + "\n");
            }
            return str.ToString();
        }
    }
}