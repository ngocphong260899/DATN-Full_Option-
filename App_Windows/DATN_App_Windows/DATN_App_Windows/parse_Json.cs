using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft;
namespace DATN_App_Windows
{
    class parse_Json
    {
        [JsonProperty("sw_wifi")]
        public string sw_wifi { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("pos")]
        public string pos { get; set; }

        [JsonProperty("ssid")]
        public string ssid { get; set; }

        [JsonProperty("streng")]
        public string streng { get; set; }
    }
}
