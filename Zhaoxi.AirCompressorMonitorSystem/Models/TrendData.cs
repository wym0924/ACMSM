using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.AirCompressorMonitorSystem.Models
{
    public class TrendData
    {
        public DateTime CollectionTime { get; set; }
        public float Pressure {  get; set; }
        public float Flow {  get; set; }
        public float Temperature {  get; set; }
    }
}
