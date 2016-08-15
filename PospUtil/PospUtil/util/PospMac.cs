using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    /// <summary>
    /// 终端MAC算法
    /*  POS终端上送时采用ECB的加密方式，简述如下：
        a)  将欲发送给银行卡收单业务系统的消息中，从消息类型（MTI）到63域之间的部分构成MAC ELEMEMENT BLOCK （MAB）。
        b)  对MAB，按每8个字节做异或（不管信息中的字符格式），如果最后不满8个字节，则添加“0X00”。
        示例	：
        MAB = M1 M2 M3 M4
        其中：	
        M1 = MS11 MS12 MS13 MS14 MS15 MS16 MS17 MS18
        M2 = MS21 MS22 MS23 MS24 MS25 MS26 MS27 MS28
        M3 = MS31 MS32 MS33 MS34 MS35 MS36 MS37 MS38
        M4 = MS41 MS42 MS43 MS44 MS45 MS46 MS47 MS48

        按如下规则进行异或运算：
                    MS11 MS12 MS13 MS14 MS15 MS16 MS17 MS18
        XOR）			MS21 MS22 MS23 MS24 MS25 MS26 MS27 MS28
        ---------------------------------------------------
        TEMP BLOCK1 = TM11 TM12 TM13 TM14 TM15 TM16 TM17 TM18

        然后，进行下一步的运算：
        TM11 TM12 TM13 TM14 TM15 TM16 TM17 TM18
        XOR）			MS31 MS32 MS33 MS34 MS35 MS36 MS37 MS38
        ---------------------------------------------------
        TEMP BLOCK2 = TM21 TM22 TM23 TM24 TM25 TM26 TM27 TM28

        再进行下一步的运算：
        TM21 TM22 TM23 TM24 TM25 TM26 TM27 TM28
        XOR）			MS41 MS42 MS43 MS44 MS45 MS46 MS47 MS48
        ---------------------------------------------------
        RESULT BLOCK = TM31 TM32 TM33 TM34 TM35 TM36 TM37 TM38

        c)  将异或运算后的最后8个字节（RESULT BLOCK）转换成16 个HEXDECIMAL：
        RESULT BLOCK = TM31 TM32 TM33 TM34 TM35 TM36 TM37 TM38
                     = TM311 TM312 TM321 TM322 TM331 TM332 TM341 TM342 ||

                       TM351 TM352 TM361 TM362 TM371 TM372 TM381 TM382

        d)  用MAK加密：
        ENC BLOCK1 = eMAK（TM311 TM312 TM321 TM322 TM331 TM332 TM341 TM342）
                    = EN11 EN12 EN13 EN14 EN15 EN16 EN17 EN18

        e)  将加密后的结果与后8 个字节异或：
        EN11 EN12  EN13 EN14  EN15 EN16  EN17 EN18
        XOR）     	TM351 TM352 TM361 TM362 TM371 TM372 TM381 TM382
        ------------------------------------------------------------
        TEMP BLOCK = TE11  TE12 TE13  TE14 TE15  TE16 TE17  TE18

        f)  用异或的结果TEMP BLOCK 再进行一次双倍长密钥算法运算。
        ENC BLOCK2 = eMAK（TE11 TE12 TE13 TE14 TE15 TE16 TE17 TE18）
                   = EN21 EN22 EN23 EN24 EN25 EN26 EN27 EN28

        g)  将运算后的结果（ENC BLOCK2）转换成16 个HEXDECIMAL：
        ENC BLOCK2 = EN21 EN22 EN23 EN24 EN25 EN26 EN27 EN28
        = EM211 EM212 EM221 EM222 EM231 EM232 EM241 EM242 ||

                      EM251 EM252 EM261 EM262 EM271 EM272 EM281 EM282
        示例	：
        ENC RESULT = % H84, %H56, %HB1, %HCD, %H5A, %H3F, %H84, %H84
          转换成16 个HEXDECIMAL:
        “8456B1CD5A3F8484”
        h)  取前8个字节作为MAC值。
        取”8456B1CD”为MAC值。
    */
    public class PospMac : AbsMac
    {
        public static string getMac(string reqData, string macKey)
        {
            byte[] reqDataBytes = StringUtil.hexStringToByte(reqData);
            byte[] macKeyBytes = StringUtil.hexStringToByte(macKey);
            byte[] result = getMac(reqDataBytes, macKeyBytes);
            return StringUtil.byteToHexString(result);
        }

        public static byte[] getMac(byte[] reqDataBytes,byte[] keyBytes)
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
                zero = getExclusiveOR(body[i], zero);
            }
            body = null;
            string bodyXor = StringUtil.byteToHexString(zero);//异或的结果
            Console.WriteLine("异或结果：" + bodyXor);
            zero = null;
            byte[] bodyXor_1 = Encoding.UTF8.GetBytes(bodyXor.Substring(0, 8));
            Console.WriteLine("左半部分:" + StringUtil.byteToHexString(bodyXor_1));
            /**  开始进行加密[第一次]  **/
            byte[] bodyXor_encrypt = DesEncryptUtil.desEncrypt(bodyXor_1, keyBytes);
            Console.WriteLine("左半部分加密结果:" + StringUtil.byteToHexString(bodyXor_encrypt));
            bodyXor_1 = null;
            int bodyLength = bodyXor.Length;
            byte[] bodyXor_2 = Encoding.UTF8.GetBytes(bodyXor.Substring(8, 8));
            Console.WriteLine("右半部分:" + StringUtil.byteToHexString(bodyXor_2));
            byte[] keyXor = getExclusiveOR(bodyXor_encrypt, bodyXor_2);
            Console.WriteLine("加密结果异或右半部分:" + StringUtil.byteToHexString(keyXor));
            bodyXor_encrypt = null;
            bodyXor_2 = null;
            /**  开始进行加密[第二次]  **/
            byte[] keyXor_encrypt = DesEncryptUtil.desEncrypt(keyXor, keyBytes);
            Console.WriteLine("加密后:" + StringUtil.byteToHexString(keyXor_encrypt));
            keyXor = null;
            return keyXor_encrypt;
        }
    }
}
