using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DagGenerator.Models
{
    public class Settings
    {
        [JsonProperty("nodes", Required = Required.Always)]
        public int Nodes { get; set; } = 40;

        [JsonProperty("minEdges", Required = Required.Always)]
        public int MinEdges { get; set; } = 1;

        [JsonProperty("maxEdges", Required = Required.Always)]
        public int MaxEdges { get; set; } = 7;

        [JsonProperty("minComm", Required = Required.Always)]
        public int MinComm { get; set; } = 2;

        [JsonProperty("maxComm", Required = Required.Always)]
        public int MaxComm { get; set; } = 30;

        [JsonProperty("minComp", Required = Required.Always)]
        public int MinComp { get; set; } = 2;

        [JsonProperty("maxComp", Required = Required.Always)]
        public int MaxComp { get; set; } = 40;

        [JsonProperty("settings", Required = Required.Always)]
        public bool CriticalPath { get; set; } = true;
        [JsonProperty("minLayers", Required = Required.Always)]
        public int MinLayers { get; set; } = 4;
        [JsonProperty("maxLayers", Required = Required.Always)]
        public int MaxLayers { get; set; } = 40;
    }
}