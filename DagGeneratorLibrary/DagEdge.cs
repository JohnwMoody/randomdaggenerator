using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DagGeneratorLibrary
{
    public class DagEdge : IComparable<DagEdge>
    {
        public DagNode PrevNode { set; get; }
        public DagNode NextNode { set; get; }
        public int CommTime { set; get; }
        public bool CriticalPath { get; set; } = false;

        public DagEdge(DagNode prevNode, DagNode nextNode, int commTime)
        {
            PrevNode = prevNode;
            NextNode = nextNode;
            CommTime = commTime;
        }

        public int CompareTo(DagEdge other)
        {
            int i = NextNode.CompareTo(other.NextNode);
            return (i != 0) ? i : PrevNode.CompareTo(other.PrevNode);
        }
    }
}