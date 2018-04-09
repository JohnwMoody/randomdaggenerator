using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DagGenerator.App_Code.VisSupport
{
    public class VisInfoHolder
    {
        public List<NodesDataSet> nodes { get; set; }
        public List<EdgesDataSet> edges { get; set; }
    }
}