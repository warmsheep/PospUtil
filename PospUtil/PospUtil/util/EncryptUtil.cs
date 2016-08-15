using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    public class EncryptUtil
    {
        //构造一个对称算法
        private SymmetricAlgorithm mCSP = new TripleDESCryptoServiceProvider();
        #region 加密解密函数

        /// <summary>
        /// DES/3DES加密
        /// </summary>
        /// <param name="reqData"></param>
        /// <param name="encryptKey"></param>
        /// <returns></returns>
        public static string desEncrypt(string reqData, string encryptKey)
        {
            int desMode = 0;       //1:3des,2:des
            byte[] encryptDataBytes = null;  //加密后的数据
            byte[] keyBytes = StringUtil.hexStringToByte(encryptKey);   //密钥byte数据
            byte[] reqDataBytes = StringUtil.hexStringToByte(reqData);  //请求数据byte数组

            if (encryptKey.Length == 16)
            {
                desMode = 2;
            }
            else if (encryptKey.Length == 32 || encryptKey.Length == 48)
            {
                desMode = 1;
            }
            //3DES加密
            if (desMode == 1)
            {
                TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
                des.Padding = PaddingMode.None;

                //通过反射赋值，绕开弱密钥检查
                FieldInfo fi = des.GetType().GetField("KeyValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, keyBytes);
                fi = des.GetType().GetField("KeySizeValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, keyBytes.Length * 8);

                Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
                object obj = t.GetField("Encrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

                MethodInfo mi = des.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
                ICryptoTransform encryptor = (ICryptoTransform)mi.Invoke(des, new object[] { keyBytes, CipherMode.ECB, null, 0, obj });
                encryptDataBytes = encryptor.TransformFinalBlock(reqDataBytes, 0, reqDataBytes.Length);

            }
            //DES加密
            else if (desMode == 2)
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                des.IV = keyBytes;
                des.Padding = PaddingMode.None;

                //通过反射赋值，绕开弱密钥检查
                FieldInfo fi = des.GetType().GetField("KeyValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, keyBytes);
                fi = des.GetType().GetField("KeySizeValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, keyBytes.Length * 8);

                Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
                object obj = t.GetField("Encrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

                MethodInfo mi = des.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
                ICryptoTransform encryptor = (ICryptoTransform)mi.Invoke(des, new object[] { keyBytes, CipherMode.ECB, null, 0, obj });
                encryptDataBytes = encryptor.TransformFinalBlock(reqDataBytes, 0, reqDataBytes.Length);
            }


            return StringUtil.byteToHexString(encryptDataBytes);
        }

        /// <summary>
        /// DES/3DES解密
        /// </summary>
        /// <param name="reqData"></param>
        /// <param name="decryptKey"></param>
        /// <returns></returns>
        public static string desDecrypt(string reqData, string decryptKey)
        {
            int desMode = 0;       //1:3des,2:des
            byte[] decryptDataBytes = null;  //解密后的数据
            byte[] keyBytes = StringUtil.hexStringToByte(decryptKey);   //密钥byte数据
            byte[] reqDataBytes = StringUtil.hexStringToByte(reqData);  //请求数据byte数组

            if (decryptKey.Length == 16)
            {
                desMode = 2;
            }
            else if (decryptKey.Length == 32 || decryptKey.Length == 48)
            {
                desMode = 1;
            }
            //3DES解密
            if (desMode == 1)
            {
                TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
                des.Padding = PaddingMode.None;
                des.Mode = CipherMode.ECB;

                //通过反射赋值，绕开弱密钥检查
                FieldInfo fi = des.GetType().GetField("KeyValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, keyBytes);
                fi = des.GetType().GetField("KeySizeValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, keyBytes.Length * 8);

                Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
                object obj = t.GetField("Decrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

                MethodInfo mi = des.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
                ICryptoTransform decryptor = (ICryptoTransform)mi.Invoke(des, new object[] { keyBytes, CipherMode.ECB, null, 0, obj });

                decryptDataBytes = decryptor.TransformFinalBlock(reqDataBytes, 0, reqDataBytes.Length);

            }
            //DES解密
            else if (desMode == 2)
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                des.IV = keyBytes;
                des.Padding = PaddingMode.None;

                //通过反射赋值，绕开弱密钥检查
                FieldInfo fi = des.GetType().GetField("KeyValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, keyBytes);
                fi = des.GetType().GetField("KeySizeValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, keyBytes.Length * 8);


                Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
                object obj = t.GetField("Decrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

                MethodInfo mi = des.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
                ICryptoTransform decryptor = (ICryptoTransform)mi.Invoke(des, new object[] { keyBytes, CipherMode.ECB, null, 0, obj });

                decryptDataBytes = decryptor.TransformFinalBlock(reqDataBytes, 0, reqDataBytes.Length);
            }

            return StringUtil.byteToHexString(decryptDataBytes);

        }

        #endregion

    }
}
