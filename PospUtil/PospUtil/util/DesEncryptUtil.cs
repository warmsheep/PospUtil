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
    public class DesEncryptUtil
    {
        //构造一个对称算法
        private SymmetricAlgorithm mCSP = new TripleDESCryptoServiceProvider();
        #region 加密解密函数

        /// <summary>
        /// DES/3DES加密
        /// </summary>
        /// <param name="reqDataBytes"></param>
        /// <param name="encryptKeyBytes"></param>
        /// <returns></returns>
        public static string desEncrypt(string reqData,string encryptKey)
        {
            byte[] keyBytes = StringUtil.hexStringToByte(encryptKey);   //密钥byte数据
            byte[] reqDataBytes = StringUtil.hexStringToByte(reqData);  //请求数据byte数组
            byte[] result = desEncrypt(reqDataBytes, keyBytes);
          
            return StringUtil.byteToHexString(result);
        }

        /// <summary>
        /// DES/3DES加密
        /// </summary>
        /// <param name="reqData"></param>
        /// <param name="encryptKey"></param>
        /// <returns></returns>
        public static byte[] desEncrypt(byte[] reqDataBytes, byte[] encryptKeyBytes)
        {
            int desMode = 0;       //1:3des,2:des
            byte[] encryptDataBytes = null;  //加密后的数据
          

            if (encryptKeyBytes.Length == 8)
            {
                desMode = 2;
            }
            else if (encryptKeyBytes.Length == 16 || encryptKeyBytes.Length == 24)
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
                fi.SetValue(des, encryptKeyBytes);
                fi = des.GetType().GetField("KeySizeValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, encryptKeyBytes.Length * 8);

                Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
                object obj = t.GetField("Encrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

                MethodInfo mi = des.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
                ICryptoTransform encryptor = (ICryptoTransform)mi.Invoke(des, new object[] { encryptKeyBytes, CipherMode.ECB, null, 0, obj });
                encryptDataBytes = encryptor.TransformFinalBlock(reqDataBytes, 0, reqDataBytes.Length);

            }
            //DES加密
            else if (desMode == 2)
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                //des.IV = encryptKeyBytes;
                des.Padding = PaddingMode.None;

                //通过反射赋值，绕开弱密钥检查
                FieldInfo fi = des.GetType().GetField("KeyValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, encryptKeyBytes);
                fi = des.GetType().GetField("KeySizeValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, encryptKeyBytes.Length * 8);

                Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
                object obj = t.GetField("Encrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

                MethodInfo mi = des.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
                ICryptoTransform encryptor = (ICryptoTransform)mi.Invoke(des, new object[] { encryptKeyBytes, CipherMode.ECB, null, 0, obj });
                encryptDataBytes = encryptor.TransformFinalBlock(reqDataBytes, 0, reqDataBytes.Length);
            }


            return encryptDataBytes;
        }

        public static string desDecrypt(string reqData,string decryptKey)
        {
            byte[] keyBytes = StringUtil.hexStringToByte(decryptKey);   //密钥byte数据
            byte[] reqDataBytes = StringUtil.hexStringToByte(reqData);  //请求数据byte数组
            byte[] result = desDecrypt(reqDataBytes, keyBytes);
            return StringUtil.byteToHexString(result);
        }

        /// <summary>
        /// DES/3DES解密
        /// </summary>
        /// <param name="reqData"></param>
        /// <param name="decryptKey"></param>
        /// <returns></returns>
        public static byte[] desDecrypt(byte[] reqDataBytes, byte[] decryptKeyBytes)
        {
            int desMode = 0;       //1:3des,2:des
            byte[] decryptDataBytes = null;  //解密后的数据


            if (decryptKeyBytes.Length == 8)
            {
                desMode = 2;
            }
            else if (decryptKeyBytes.Length == 16 || decryptKeyBytes.Length == 24)
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
                fi.SetValue(des, decryptKeyBytes);
                fi = des.GetType().GetField("KeySizeValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, decryptKeyBytes.Length * 8);

                Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
                object obj = t.GetField("Decrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

                MethodInfo mi = des.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
                ICryptoTransform decryptor = (ICryptoTransform)mi.Invoke(des, new object[] { decryptKeyBytes, CipherMode.ECB, null, 0, obj });

                decryptDataBytes = decryptor.TransformFinalBlock(reqDataBytes, 0, reqDataBytes.Length);

            }
            //DES解密
            else if (desMode == 2)
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                //des.IV = decryptKeyBytes;
                des.Padding = PaddingMode.None;

                //通过反射赋值，绕开弱密钥检查
                FieldInfo fi = des.GetType().GetField("KeyValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, decryptKeyBytes);
                fi = des.GetType().GetField("KeySizeValue", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(des, decryptKeyBytes.Length * 8);


                Type t = Type.GetType("System.Security.Cryptography.CryptoAPITransformMode");
                object obj = t.GetField("Decrypt", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).GetValue(t);

                MethodInfo mi = des.GetType().GetMethod("_NewEncryptor", BindingFlags.Instance | BindingFlags.NonPublic);
                ICryptoTransform decryptor = (ICryptoTransform)mi.Invoke(des, new object[] { decryptKeyBytes, CipherMode.ECB, null, 0, obj });

                decryptDataBytes = decryptor.TransformFinalBlock(reqDataBytes, 0, reqDataBytes.Length);
            }

            return decryptDataBytes;

        }

        #endregion

    }
}
