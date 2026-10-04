using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhaoxi.CustControls;

namespace Zhaoxi.AirCompressorMonitorSystem.Utils
{
    /// <summary>
    /// 项目相关的通用辅助类
    /// </summary>
    public static class Utility
    {
        //存储按钮的原始放置
        public static Dictionary<string,UButton> dicOldBtns= new Dictionary<string,UButton>();

        /// <summary>
        /// 添加指定按钮的存储
        /// </summary>
        /// <param name="button"></param>
        public static void StoreUButton( this UButton button)
        {
            dicOldBtns.Add(button.Name, CopyBtnSets(button));
        }

        /// <summary>
        /// 生成指定按钮的副本
        /// </summary>
        /// <param name="btn"></param>
        /// <returns></returns>
        public static UButton CopyBtnSets(UButton btn)
        {
            UButton btnCopy = new UButton()
            {
                BgColor = btn.BgColor,
                ForeColor = btn.ForeColor,
                BgColor2 = btn.BgColor2,
                FocusBgColor = btn.FocusBgColor,
                FocusForeColor = btn.FocusForeColor
            };
            return btnCopy;
        }

        /// <summary>
        /// 指定的UButton禁用
        /// </summary>
        /// <param name="btn"></param>
        public static void UnableBtn(this UButton btn)
        {
            btn.Enabled = false;
            btn.BgColor = Color.Gray;
            btn.BgColor2 = Color.Transparent;
            btn.ForeColor = Color.LightGray;
            btn.FocusBgColor = Color.Gray;
            btn.FocusForeColor = Color.LightGray;
        }

        /// <summary>
        /// 指定的UButton启用
        /// </summary>
        /// <param name="btn"></param>
        public static void EnableBtn(this UButton btn)
        {
            btn.Enabled = true;
            UButton btnSets=dicOldBtns[btn.Name];
            btn.BgColor= btnSets.BgColor;
            btn.ForeColor= btnSets.ForeColor;
            btn.BgColor2 = btnSets.BgColor2;
            btn.FocusBgColor= btnSets.FocusBgColor;
            btn.FocusForeColor= btnSets.FocusForeColor;
        }

        /// <summary>
        /// 设置默认状态标签  运行状态、故障
        /// </summary>
        /// <param name="lbl"></param>
        /// <param name="isRunState"></param>
        public static void SetDefalutStateLabel(Label lbl,bool isRunState=false)
        {
             if(isRunState)
            {
                lbl.Text = "已停止";
            }
             else
            {
                lbl.Text = "无";
            }
            lbl.ForeColor = Color.Gray;
        }
        /// <summary>
        /// 将2个ushort转换为一个uint值
        /// </summary>
        /// <param name="ushorts"></param>
        /// <returns></returns>
        public static uint GetUshortToUInt(ushort[] ushorts)
        {
            List<byte> bytes = new List<byte>();
            byte[] bytes1 = BitConverter.GetBytes(ushorts[1]);
            bytes.AddRange(bytes1);
            byte[] bytes2 = BitConverter.GetBytes(ushorts[0]);
            bytes.AddRange(bytes2);
            return BitConverter.ToUInt32(bytes.ToArray(), 0);
        }


        /// <summary>
        /// 将2个ushort转换为一个float值
        /// </summary>
        /// <param name="ushorts"></param>
        /// <returns></returns>
        public static float GetUshortToFloat(ushort[] ushorts)
        {
            List<byte> bytes = new List<byte>();
            byte[] bytes1 = BitConverter.GetBytes(ushorts[1]);
            bytes.AddRange(bytes1);
            byte[] bytes2 = BitConverter.GetBytes(ushorts[0]);
            bytes.AddRange(bytes2);
            return BitConverter.ToSingle(bytes.ToArray(), 0);
        }

        /// <summary>
        /// 将float转换为两个ushort
        /// </summary>
        /// <param name="float"></param>
        /// <returns></returns>
        public static ushort[] GetFloatToUshorts(float val)
        {
            ushort[] reValues=new ushort[2];
            byte[] bytes = BitConverter.GetBytes(val);
            Array.Reverse(bytes);
            reValues[0] = BitConverter.ToUInt16(bytes, 0);
            reValues[0] = BitConverter.ToUInt16(bytes, 2);
            return reValues;
        }

        /// <summary>
        /// 检测某个数据值异常
        /// </summary>
        /// <param name="value">要检测的值</param>
        /// <param name="alarmValues">临界值数组</param>
        /// <returns></returns>
        public static int CheckData(float value, float[] alarmValues)
        {
            int result = -1;
            float min=alarmValues[0];
            float max=alarmValues[1];
            if (value < min)
            {
                result = 0;//低值异常
            }
            else if (value > max)
            {
                result = 2;//高值异常
            }
            else
                result = 1;//正常
            return result;
        }
    }
}
