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


        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static byte[] xor(byte[] a, byte[] b)
        {
            try
            {
                byte[] c = new byte[8];
                for (int i = 0; i < 8; i++)
                {
                    c[i] = ((byte)(a[i] ^ b[i]));
                }
                return c;
            }
            catch (Exception e)
            {
                throw new Exception("异或运算失败,a = " + a + ", b = " + b + ",exception:" + e.Message);
            }
            throw new Exception("异或运算失败,a = " + a + ", b = " + b);
        }

        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string xor(string a, string b)
        {
            byte[] abytes = hexStringToByte(a);
            byte[] bbytes = hexStringToByte(b);
            byte[] result = xor(abytes, bbytes);
            return byteToHexString(result);
        }

        /// <summary>
        /// 分组异或
        /// </summary>
        /// <param name="reqDataBytes"></param>
        /// <returns></returns>
        public static byte[] groupXor(byte[] reqDataBytes)
        {
            int dataLen = reqDataBytes.Length;
            int groupLen = dataLen / 8;
            byte[][] body = new byte[groupLen][];
            int index = 0;
            for (int i = 0; i < groupLen; i++)
            {
                body[i] = new byte[8];
                Array.Copy(reqDataBytes, index, body[i], 0, 8);
                index += 8;
            }
            byte[] zero = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            for (int i = 0; i < groupLen; i++)
            {
                zero = StringUtil.xor(body[i], zero);
            }
            body = null;
            return zero;
        }

        /// <summary>
        /// 分组异或
        /// </summary>
        /// <param name="reqData"></param>
        /// <returns></returns>
        public static string groupXor(string reqData)
        {
            byte[] reqDataBytes = hexStringToByte(reqData);
            byte[] result = groupXor(reqDataBytes);
            return byteToHexString(result);
        }
    }
}
