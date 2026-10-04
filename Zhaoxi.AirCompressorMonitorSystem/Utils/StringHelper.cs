using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.AirCompressorMonitorSystem.Utils
{
    public static class StringHelper
    {
        public static decimal GetDecimal(this string str)
        {
            decimal result = 0;
            decimal.TryParse(str, out result);
            return result;
        }

        public static float GetFloat(this string str)
        {
            float result = 0;
            float.TryParse(str, out result);
            return result;
        }

        public static uint GetUInt(this string str)
        {
            uint result = 0;
            uint.TryParse(str, out result);
            return result;
        }

        public static int GetInt(this string str)
        {
            int result = 0;
            int.TryParse(str, out result);
            return result;
        }

        public static ushort GetUShort(this string str)
        {
            ushort result = 0;
            ushort.TryParse(str, out result);
            return result;
        }
    }
}
