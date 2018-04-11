using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DagGenerator.App_Code.VisSupport
{
    public class EdgesDataSet
    {
        public int from { get; set; }
        public int to { get; set; }
        public string label { get; set; }
        public Color color { get; set; }
    }

    public class Color
    {
        public string color { get; set; }
    }
}