using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    public class SHA1EncryptUtil
    {
        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="reqDataBytes"></param>
        /// <param name="encryptKeyBytes"></param>
        /// <returns></returns>
        public static string sha1Encrypt(string reqData)
        {
            byte[] cleanBytes = Encoding.Default.GetBytes(reqData);
            byte[] hashedBytes = System.Security.Cryptography.SHA1.Create().ComputeHash(cleanBytes);
            return StringUtil.byteToHexString(hashedBytes);
        }
    }
}
