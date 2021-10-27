using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN_App_Windows
{
    class Cmd_Json_Pub
    {
        public string cmd1_on = "{\"sw_wifi\":  1,\"status\":1 }";
        public string cmd2_on = "{\"sw_wifi\":  1,\"status\":3 }";
        public string cmd3_on = "{\"sw_wifi\":  1,\"status\":5 }";
        public string cmd1_off = "{\"sw_wifi\": 1,\"status\":2 }";
        public string cmd2_off = "{\"sw_wifi\": 1,\"status\":4 }";
        public string cmd3_off = "{\"sw_wifi\": 1,\"status\":6 }";

        public string get_State_device = "{\"sw_wifi\":2}";
    }
}
