using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    public class MD5EncryptUtil
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="reqDataBytes"></param>
        /// <param name="encryptKeyBytes"></param>
        /// <returns></returns>
        public static string md5Encrypt(string reqData)
        {
            byte[] result = Encoding.Default.GetBytes(reqData);    //tbPass为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return StringUtil.byteToHexString(output);
        }
    }
}
