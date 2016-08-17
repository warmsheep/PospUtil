using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    public class PinUtil
    {
        /// <summary>
        /// PIN加密的主帐号
        /// </summary>
        /// <param name="accountNo"></param>
        /// <returns></returns>
        public static byte[] getPAN(string accountNo)
        {
            int len = accountNo.Length;
            accountNo = accountNo.Substring(len < 13 ? 0 : len - 13, 12);
            accountNo = accountNo.PadLeft(16, '0');

            return StringUtil.hexStringToByte(accountNo);
        }

        /// <summary>
        /// 对pin进行处理
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public static byte[] procPin(string pin)
        {
            if (pin.Length == 16)
            {
                return StringUtil.hexStringToByte(pin);
            } 
            else
            {
                pin = "06" + pin + "FFFFFFFF";
            }
           
            return StringUtil.hexStringToByte(pin);
        }

        public static byte[] process(string pin, string accountNo)
        {
            byte[] pinBytes = procPin(pin);
            byte[] accountNoBytes = getPAN(accountNo);
            byte[] resultBytes = new byte[8];
            //PIN BLOCK 格式等于 PIN 按位异或 主帐号;
            for (int i = 0; i < 8; i++)
            {
                resultBytes[i] = (byte)(pinBytes[i] ^ accountNoBytes[i]);
            }
            return resultBytes;
        }

        public static byte[] reverse(string accountNo, string xorValue)
        {
            byte[] accountNoBytes = getPAN(accountNo);
            byte[] xorValueByte = StringUtil.hexStringToByte(xorValue);
            byte[] arrRet = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                arrRet[i] = (byte)(accountNoBytes[i] ^ xorValueByte[i]);
            }
            return arrRet;
        }
        
    }
}
