using Modbus.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zhaoxi.AirCompressorMonitorSystem.Models;

namespace Zhaoxi.AirCompressorMonitorSystem.Utils
{
    public  class CommonHelper
    {
        public static CommunicationSet connSets = null;//通信设置信息
        public static bool isLogin = false;//是否登录
        public static bool isConnected = false;//是否已连接
        public static TcpClient tcpClient = null;//客户端连接对象
        public static IModbusMaster master = null;//通信主站
    }
}
