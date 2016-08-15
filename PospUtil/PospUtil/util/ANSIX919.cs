using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    /// <summary>
    /// X9.19 MAC算法工具类
    /// </summary>
    public class ANSIX919 : AbsMac
    {
        public static string getMac(string reqData,string macKey)
        {
            byte[] reqDataBytes = StringUtil.hexStringToByte(reqData);
            byte[] macKeyBytes = StringUtil.hexStringToByte(macKey);
            byte[] result = getMac(reqDataBytes, macKeyBytes);
            return StringUtil.byteToHexString(result);
        }

        /// <summary>
        /// 计算MAC
        /// </summary>
        /// <param name="reqData"></param>
        /// <param name="macKey"></param>
        /// <returns></returns>
        public static byte[] getMac(byte[] reqDataBytes, byte[] macKeyBytes)
        {
            byte[] left = new byte[8];
            byte[] right = new byte[8];
            Array.Copy(macKeyBytes, 0, left, 0, 8);
            Array.Copy(macKeyBytes, 8, right, 0, 8);

            byte[] macTemp = ANSIX99.getMac(reqDataBytes, left);
            string macTempStr = StringUtil.byteToHexString(macTemp);
            byte[] desRightTemp = DesEncryptUtil.desDecrypt(macTemp, right);
            string desRightTempStr = StringUtil.byteToHexString(desRightTemp);
            byte[] mac = DesEncryptUtil.desEncrypt(desRightTemp, left);
            string macStr = StringUtil.byteToHexString(mac);
            return mac;
        }
    }
}
