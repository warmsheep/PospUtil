using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    /// <summary>
    /// 字符串工具类
    /// </summary>
    public class StringUtil
    {
        /// <summary>
        /// 将16进制字符串转换为byte数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] hexStringToByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
            {
                hexString += " ";
            }
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
            return returnBytes;
        }

        /// <summary>
        /// 将byte数组转换为16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string byteToHexString(byte[] bytes)
        {
            string str = BitConverter.ToString(bytes).Replace("-", "");
            return str;
        }
    }
}
