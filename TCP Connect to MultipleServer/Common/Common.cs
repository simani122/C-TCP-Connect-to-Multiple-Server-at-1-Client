using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Connect_to_MultipleServer
{
    public class Common
    {
        public static string Server1_IP { get; set; } = "127.0.0.1";
        public static string Server2_IP { get; set; } = "127.0.0.1";
        public static int Server1_Port { get; set; } = 41200;
        public static int Server2_Port { get; set; } = 41200;

        public static string ServeIP_1_Data { get; set; } = string.Empty;
        public static string ServerIP_2_Data { get; set; } = string.Empty;
    }
}
