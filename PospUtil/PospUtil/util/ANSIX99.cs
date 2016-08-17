using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    /// <summary>
    /// X99 MAC算法工具类
    /// </summary>
    public class ANSIX99 : AbsMac
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
            reqDataBytes = getEightMultiplesData(reqDataBytes);

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

            byte[] zero = new byte[8];
            for (int i = 0; i < groupLen; i++)
            {
                zero = StringUtil.xor(body[i], zero);
                zero = DesEncryptUtil.desEncrypt(zero, macKeyBytes);
            }
            body = (byte[][])null;
            return zero;
        }

    }

}
