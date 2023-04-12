using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypixelSkyblock.Model
{
    internal class MojangProfile
    {
        [JsonProperty(PropertyName = "id")]
        public string uuid { get; set; }


        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
    }
}
