using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.AirCompressorMonitorSystem.Models
{
    public class ParaInfo
    {
        public string ParaName {  get; set; }
        public ushort Address {  get; set; }
        public string DataType {  get; set; }
        public int DCount {  get; set; }
    }
}
