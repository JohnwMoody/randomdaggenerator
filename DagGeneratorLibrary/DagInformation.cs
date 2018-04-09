using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DagGeneratorLibrary
{
    public class DagInformation
    {
        private Dictionary<string, object> DescriptionInformation { get; } = new Dictionary<string, object>();

        public DagInformation() { }

        public void AddInformation(string key, object value)
        {
            DescriptionInformation.Add(key, value);
        }
    }
}