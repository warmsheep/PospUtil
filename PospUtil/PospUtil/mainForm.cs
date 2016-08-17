using PospUtil.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PospUtil
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 加密按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesEncrypt_Click(object sender, EventArgs e)
        {
            string key = this.tboxDesKey.Text.ToString().Trim();
            string reqData = this.tboxDesReqData.Text.ToString().Trim();
            if (key == "")
            {
                MessageBox.Show("密钥不能为空！");
                return;
            }
            if(key.Length % 8 != 0)
            {
                MessageBox.Show("密钥长度有误！");
                return;
            }
            if(reqData == "")
            {
                MessageBox.Show("数据不能为空！");
                return;
            }
            if(reqData.Length % 8 != 0)
            {
                MessageBox.Show("数据长度有误");
                return;
            }
            string result = DesEncryptUtil.desEncrypt(reqData, key);
            this.tboxDesResult.Text = result;

        }
        /// <summary>
        /// 解密按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesDecrypt_Click(object sender, EventArgs e)
        {
            string key = this.tboxDesKey.Text.ToString().Trim();
            string reqData = this.tboxDesReqData.Text.ToString().Trim();

            if (key == "")
            {
                MessageBox.Show("密钥不能为空！");
                return;
            }
            if (key.Length % 8 != 0)
            {
                MessageBox.Show("密钥长度有误！");
                return;
            }
            if (reqData == "")
            {
                MessageBox.Show("数据不能为空！");
                return;
            }
            if (reqData.Length % 8 != 0)
            {
                MessageBox.Show("数据长度有误");
                return;
            }
            string result = DesEncryptUtil.desDecrypt(reqData, key);
            this.tboxDesResult.Text = result;
        }

        /// <summary>
        /// 密钥文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxDesKey_TextChanged(object sender, EventArgs e)
        {
            this.lbDesKeyLength.Text = this.tboxDesKey.Text.Length.ToString();
        }

        /// <summary>
        /// 数据文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxDesReqData_TextChanged(object sender, EventArgs e)
        {
            this.lbDesReqDataLength.Text = this.tboxDesReqData.Text.Length.ToString();
        }

        private void lbReqDataLength_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// X99 MAC计算按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMacEncryptX99_Click(object sender, EventArgs e)
        {
            string masterKey = this.tboxMacMasterKey.Text.Trim();
            string macKey = this.tboxMacMacKey.Text.Trim();
            string reqData = this.tboxMacReqData.Text.Trim();

            if (masterKey != "" && masterKey.Length % 8 != 0)
            {
                MessageBox.Show("主密钥长度有误！");
                return;
            }
            if (macKey == "")
            {
                MessageBox.Show("MAC密钥不能为空！");
                return;
            }
            if (macKey.Length % 8 != 0)
            {
                MessageBox.Show("MAC密钥长度有误！");
                return;
            }
            if (reqData == "")
            {
                MessageBox.Show("数据不能为空！");
                return;
            }
           

            if (masterKey != "")
            {
                macKey = DesEncryptUtil.desDecrypt(macKey, masterKey);
            }

            reqData = reqData.Replace(" ", "");
            reqData = reqData.Replace("\n", "");
            reqData = reqData.Replace("\t", "");
            reqData = reqData.Replace("\r", "");
            string result = ANSIX99.getMac(reqData, macKey);
            this.tboxMacResult.Text = result;
        }

        /// <summary>
        /// X9.19 MAC计算按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMacEncryptX919_Click(object sender, EventArgs e)
        {
            string masterKey = this.tboxMacMasterKey.Text.Trim();
            string macKey = this.tboxMacMacKey.Text.Trim();
            string reqData = this.tboxMacReqData.Text.Trim();
            if(masterKey != "" && masterKey.Length % 8 != 0)
            {
                MessageBox.Show("主密钥长度有误！");
                return;
            }
            if (macKey == "")
            {
                MessageBox.Show("MAC密钥不能为空！");
                return;
            }
            if (macKey.Length % 8 != 0 || macKey.Length < 32)
            {
                MessageBox.Show("MAC密钥长度有误！");
                return;
            }
            if (reqData == "")
            {
                MessageBox.Show("数据不能为空！");
                return;
            }
           

            if(masterKey != "")
            {
                macKey = DesEncryptUtil.desDecrypt(macKey, masterKey);
            }

            reqData = reqData.Replace(" ", "");
            reqData = reqData.Replace("\n", "");
            reqData = reqData.Replace("\t", "");
            reqData = reqData.Replace("\r", "");
            string result = ANSIX919.getMac(reqData, macKey);
            this.tboxMacResult.Text = result;
        }

        /// <summary>
        /// 终端MAC算法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerminalMac_Click(object sender, EventArgs e)
        {
            string masterKey = this.tboxMacMasterKey.Text.Trim();
            string macKey = this.tboxMacMacKey.Text.Trim();
            string reqData = this.tboxMacReqData.Text.Trim();

            if (masterKey != "" && masterKey.Length % 8 != 0)
            {
                MessageBox.Show("主密钥长度有误！");
                return;
            }
            if (macKey == "")
            {
                MessageBox.Show("MAC密钥不能为空！");
                return;
            }
            if (macKey.Length % 8 != 0)
            {
                MessageBox.Show("MAC密钥长度有误！");
                return;
            }
            if (reqData == "")
            {
                MessageBox.Show("数据不能为空！");
                return;
            }

            if (masterKey != "")
            {
                macKey = DesEncryptUtil.desDecrypt(macKey, masterKey);
            }
            reqData = reqData.Replace(" ", "");
            reqData = reqData.Replace("\n", "");
            reqData = reqData.Replace("\t", "");
            reqData = reqData.Replace("\r", "");
            string result = PospMac.getMac(reqData, macKey);
            this.tboxMacResult.Text = result;
        }

        /// <summary>
        /// MAC计算主密钥文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxMacMasterKey_TextChanged(object sender, EventArgs e)
        {
            this.lbMacMasterKeyLength.Text = this.tboxMacMasterKey.Text.Length.ToString();
        }

        /// <summary>
        /// MAC计算MAC密钥文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxMacMacKey_TextChanged(object sender, EventArgs e)
        {
            this.lbMacMacKeyLength.Text = this.tboxMacMacKey.Text.Length.ToString();
        }

        /// <summary>
        /// MAC计算请求数据文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxMacReqData_TextChanged(object sender, EventArgs e)
        {
            this.lbMacReqDataLength.Text = this.tboxMacReqData.Text.Length.ToString();
        }


        /// <summary>
        /// 异或请求数据文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxXorReqData_TextChanged(object sender, EventArgs e)
        {
            this.lbXorReqDataLength.Text = this.tboxXorReqData.Text.Length.ToString();
        }

        /// <summary>
        /// 异或按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXor_Click(object sender, EventArgs e)
        {
            string reqData = this.tboxXorReqData.Text.Trim();
            reqData = reqData.Replace(" ", "");
            reqData = reqData.Replace("\n", "");
            reqData = reqData.Replace("\t", "");
            reqData = reqData.Replace("\r", "");
            string result = StringUtil.groupXor(reqData);
            this.tboxXorResult.Text = result;
        }


        /// <summary>
        /// PIN加密-主密钥文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxPinMasterKey_TextChanged(object sender, EventArgs e)
        {
            this.lbPinMasterKeyLength.Text = this.tboxPinMasterKey.Text.Length.ToString();
        }

        /// <summary>
        /// PIN加密-PIN密钥文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxPinKey_TextChanged(object sender, EventArgs e)
        {
            this.lbPinKeyLength.Text = this.tboxPinKey.Text.Length.ToString();
        }

        /// <summary>
        /// PIN加密-卡号文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxPinCardNo_TextChanged(object sender, EventArgs e)
        {
            this.lbPinCardNoLength.Text = this.tboxPinCardNo.Text.Length.ToString();
        }

        /// <summary>
        /// PIN加密-密码文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxPinPassword_TextChanged(object sender, EventArgs e)
        {
            this.lbPinPasswordLength.Text = this.tboxPinPassword.Text.Length.ToString();
        }

        /// <summary>
        /// PIN加密-按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPinEncrypt_Click(object sender, EventArgs e)
        {
            string masterKey = this.tboxPinMasterKey.Text.Trim();
            string pinKey = this.tboxPinKey.Text.Trim();
            string cardNo = this.tboxPinCardNo.Text.Trim();
            string pin = this.tboxPinPassword.Text.Trim();

            if (masterKey != "" && masterKey.Length % 8 != 0)
            {
                MessageBox.Show("主密钥长度有误！");
                return;
            }
            if (pinKey == "")
            {
                MessageBox.Show("PIN密钥不能为空！");
                return;
            }
            if (pinKey.Length % 8 != 0)
            {
                MessageBox.Show("PIN密钥长度有误！");
                return;
            }
            if (pin == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }

            if(masterKey != "")
            {
                pinKey = DesEncryptUtil.desDecrypt(pinKey, masterKey);
            }

            //带卡号加密
            if (cardNo != "")
            {
                pin = StringUtil.byteToHexString(PinUtil.process(pin, cardNo));
                string result = DesEncryptUtil.desEncrypt(pin,pinKey);
                this.tboxPinResult.Text = result;
            }
            //不带卡号加密
            else
            {
                string result = DesEncryptUtil.desEncrypt(pin, pinKey);
                this.tboxPinResult.Text = result;
            }

        }

        /// <summary>
        /// PIN加密-解密按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPinDecrypt_Click(object sender, EventArgs e)
        {
            string masterKey = this.tboxPinMasterKey.Text.Trim();
            string pinKey = this.tboxPinKey.Text.Trim();
            string cardNo = this.tboxPinCardNo.Text.Trim();
            string pin = this.tboxPinPassword.Text.Trim();

            if (masterKey != "" && masterKey.Length % 8 != 0)
            {
                MessageBox.Show("主密钥长度有误！");
                return;
            }
            if (pinKey == "")
            {
                MessageBox.Show("PIN密钥不能为空！");
                return;
            }
            if (pinKey.Length % 8 != 0)
            {
                MessageBox.Show("PIN密钥长度有误！");
                return;
            }
            if (pin == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }

            if (masterKey != "")
            {
                pinKey = DesEncryptUtil.desDecrypt(pinKey, masterKey);
            }

            //带卡号加密
            if (cardNo != "")
            {
                //解密
                string pinBlock = DesEncryptUtil.desDecrypt(pin, pinKey);
                byte[] pinBlockClearText = PinUtil.reverse(cardNo,pinBlock);
                string result = StringUtil.byteToHexString(pinBlockClearText);
                
                this.tboxPinResult.Text = result;
            }
            //不带卡号加密
            else
            {
                string result = DesEncryptUtil.desDecrypt(pin, pinKey);
                this.tboxPinResult.Text = result;
            }
        }

        /// <summary>
        /// 常用算法-加密点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncEncrypt_Click(object sender, EventArgs e)
        {
            int encryptType = 0;    //加密类型 1、MD5 2、SHA1
            string reqData = this.tboxEncReqData.Text.Trim();
            if(rbtnEncMd5.Checked == true)
            {
                encryptType = 1;
            }
            else if(rbtnEncSha1.Checked == true)
            {
                encryptType = 2;
            }

            //MD5加密
            if(encryptType == 1)
            {
                string result = MD5EncryptUtil.md5Encrypt(reqData);
                this.tboxEncResult.Text = result;
            }
            //SHA1加密
            else if(encryptType == 2)
            {
                string result = SHA1EncryptUtil.sha1Encrypt(reqData);
                this.tboxEncResult.Text = result;
            }
        }

        /// <summary>
        /// 终端MAC加密停靠事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerminalMac_MouseHover(object sender, EventArgs e)
        {
            this.toolTipMacEncrypt.ToolTipTitle = "算法说明";

            this.toolTipMacEncrypt.IsBalloon = false;

            this.toolTipMacEncrypt.UseFading = true;

            this.toolTipMacEncrypt.Show(
                " POS终端上送时采用ECB的加密方式，简述如下：\n" +
                "    a)  将欲发送给银行卡收单业务系统的消息中，从消息类型（MTI）到63域之间的部分构成MAC ELEMEMENT BLOCK （MAB）。\n" +
                "    b)  对MAB，按每8个字节做异或（不管信息中的字符格式），如果最后不满8个字节，则添加“0X00”。                 \n" +
                "    示例 ： MAB = M1 M2 M3 M4                                                                                   \n" +
                "    其中：	                                                                                                     \n" +
                "    M1 = MS11 MS12 MS13 MS14 MS15 MS16 MS17 MS18                                                                \n" +
                "    M2 = MS21 MS22 MS23 MS24 MS25 MS26 MS27 MS28                                                                \n" +
                "    M3 = MS31 MS32 MS33 MS34 MS35 MS36 MS37 MS38                                                                \n" +
                "    M4 = MS41 MS42 MS43 MS44 MS45 MS46 MS47 MS48                                                                \n" +
                "    按如下规则进行异或运算：                                                                                    \n" +
                "    MS11 MS12 MS13 MS14 MS15 MS16 MS17 MS18 XOR）MS21 MS22 MS23 MS24 MS25 MS26 MS27 MS28                        \n" +
                "    ---------------------------------------------------                                                         \n" +
                "    TEMP BLOCK1 = TM11 TM12 TM13 TM14 TM15 TM16 TM17 TM18                                                       \n" +
                "    然后，进行下一步的运算：                                                                                    \n" +
                "    TM11 TM12 TM13 TM14 TM15 TM16 TM17 TM18 XOR）MS31 MS32 MS33 MS34 MS35 MS36 MS37 MS38                        \n" +
                "    ---------------------------------------------------                                                         \n" +
                "    TEMP BLOCK2 = TM21 TM22 TM23 TM24 TM25 TM26 TM27 TM28                                                       \n" +
                "    再进行下一步的运算：                                                                                        \n" +
                "    TM21 TM22 TM23 TM24 TM25 TM26 TM27 TM28 XOR）MS41 MS42 MS43 MS44 MS45 MS46 MS47 MS48                        \n" +
                "    ---------------------------------------------------                                                         \n" +
                "    RESULT BLOCK = TM31 TM32 TM33 TM34 TM35 TM36 TM37 TM38                                                      \n" +
                "    c)  将异或运算后的最后8个字节（RESULT BLOCK）转换成16 个HEXDECIMAL：                                        \n" +
                "    RESULT BLOCK = TM31 TM32 TM33 TM34 TM35 TM36 TM37 TM38                                                      \n" +
                "    = TM311 TM312 TM321 TM322 TM331 TM332 TM341 TM342 || TM351 TM352 TM361 TM362 TM371 TM372 TM381 TM382        \n" +
                "    d)  用MAK加密：                                                                                             \n" +
                "    ENC BLOCK1 = eMAK（TM311 TM312 TM321 TM322 TM331 TM332 TM341 TM342）                                        \n" +
                "               = EN11 EN12 EN13 EN14 EN15 EN16 EN17 EN18                                                        \n" +
                "    e)  将加密后的结果与后8 个字节异或：                                                                        \n" +
                "    EN11 EN12  EN13 EN14  EN15 EN16  EN17 EN18 XOR）TM351 TM352 TM361 TM362 TM371 TM372 TM381 TM382             \n" +
                "    ------------------------------------------------------------                                                \n" +
                "    TEMP BLOCK = TE11  TE12 TE13  TE14 TE15  TE16 TE17  TE18                                                    \n" +
                "    f)  用异或的结果TEMP BLOCK 再进行一次双倍长密钥算法运算。                                                   \n" +
                "    ENC BLOCK2 = eMAK（TE11 TE12 TE13 TE14 TE15 TE16 TE17 TE18）                                                \n" +
                "               = EN21 EN22 EN23 EN24 EN25 EN26 EN27 EN28                                                        \n" +
                "    g)  将运算后的结果（ENC BLOCK2）转换成16 个HEXDECIMAL：                                                     \n" +
                "    ENC BLOCK2 = EN21 EN22 EN23 EN24 EN25 EN26 EN27 EN28                                                        \n" +
                "    = EM211 EM212 EM221 EM222 EM231 EM232 EM241 EM242 || EM251 EM252 EM261 EM262 EM271 EM272 EM281 EM282        \n" +
                "    示例	：                                                                                                   \n" +
                "    ENC RESULT = % H84, % H56, % HB1, % HCD, % H5A, % H3F, % H84, % H84                                         \n" +
                "      转换成16 个HEXDECIMAL: “8456B1CD5A3F8484”                                                               \n" +
                "    h)  取前8个字节作为MAC值。 取”8456B1CD”为MAC值。", this.btnTerminalMac);
        }


        
        private void copyZmkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("40404040404040405151515151515151");
        }

        private void copyZpkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("61616161616161617070707070707070");
        }

        private void copyTmkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("E0E0010101010101F1F1010101010101");
        }

        private void copyTakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1C587F1C13924FEF0101010101010101");
        }

        private void copyZakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("16161616161616161919191919191919");
        }

        private void copyZekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("23232323232323232525252525252525");
        }

        private void copyEdkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("13131313131313131515151515151515");
        }


        /// <summary>
        /// 位图转换按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBitmapConvert_Click(object sender, EventArgs e)
        {
            string bitmapData = this.tboxBitmap.Text.Trim();
            bitmapData = bitmapData.Replace(" ", "");
            if(bitmapData.Length != 16 && bitmapData.Length != 32)
            {
                MessageBox.Show("位图长度有误!");
                return;
            }
            byte[] bitmapBytes = StringUtil.hexStringToByte(bitmapData);
            StringBuilder sb = new StringBuilder();
            foreach(byte b in bitmapBytes)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            string bitmapStr = sb.ToString();
            //128位图
            if(bitmapStr.Length == 128)
            {
                for(int i = 0; i < bitmapStr.Length; i++)
                {
                    string s = bitmapStr.Substring(i, 1);
                    if(s == "1")
                    {
                        CheckBox checkbox = (CheckBox)findControl(this, "checkBox" + (i + 1));
                        checkbox.ForeColor = Color.Red;
                        checkbox.Font = new Font("宋体",16, FontStyle.Bold);
                        checkbox.Checked = true;
                    } 
                    else
                    {
                        CheckBox checkbox = (CheckBox)findControl(this,"checkBox" + (i + 1));
                        checkbox.ForeColor = Color.Black;
                        checkbox.Font = new Font("宋体", 9, FontStyle.Regular);
                        checkbox.Checked = false;
                    }
                }
            }
            //64位图
            else if(bitmapStr.Length == 64)
            {
                for (int i = 0; i < bitmapStr.Length; i++)
                {
                    string s = bitmapStr.Substring(i, 1);
                    if (s == "1")
                    {
                        CheckBox checkbox = (CheckBox)findControl(this, "checkBox" + (i + 1));
                        checkbox.ForeColor = Color.Red;
                        checkbox.Font = new Font("宋体", 16, FontStyle.Bold);
                        checkbox.Checked = true;
                    }
                    else
                    {
                        CheckBox checkbox = (CheckBox)findControl(this, "checkBox" + (i + 1));
                        checkbox.ForeColor = Color.Black;
                        checkbox.Font = new Font("宋体", 9, FontStyle.Regular);
                        checkbox.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// 查找控件
        /// </summary>
        /// <param name="control"></param>
        /// <param name="controlName"></param>
        /// <returns></returns>
        private System.Windows.Forms.Control findControl(System.Windows.Forms.Control control, string controlName)
        {
            Control c1;
            foreach (Control c in control.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
                else if (c.Controls.Count > 0)
                {
                    c1 = findControl(c, controlName);
                    if (c1 != null)
                    {
                        return c1;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 位图选中属性发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox128_CheckedChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder hexSb = new StringBuilder();
            for (int i = 0; i < 128; i++)
            {
                CheckBox checkbox = (CheckBox)findControl(this, "checkBox" + (i + 1));
                if(checkbox.Checked)
                {
                    checkbox.ForeColor = Color.Red;
                    checkbox.Font = new Font("宋体", 16, FontStyle.Bold);
                    sb.Append("1");
                } 
                else
                {
                    checkbox.ForeColor = Color.Black;
                    checkbox.Font = new Font("宋体", 9, FontStyle.Regular);
                    sb.Append("0");
                }
            }

            for(int i = 0; i < 128; i = i + 4)
            {
                string str = sb.ToString().Substring(i, 4);
                string hexStr = string.Format("{0:x}",Convert.ToInt32(str, 2)).ToUpper();
                hexSb.Append(hexStr);
            }
            
            this.tboxBitmap.Text = hexSb.ToString().Substring(0,16) + " " + hexSb.ToString(16,16);
        }

        /// <summary>
        /// 位图清空按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBitmapClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 128; i++)
            {
                CheckBox checkbox = (CheckBox)findControl(this, "checkBox" + (i + 1));
                checkbox.ForeColor = Color.Black;
                checkbox.Font = new Font("宋体", 9, FontStyle.Regular);
                checkbox.Checked = false;
            }
            this.tboxBitmap.Text = "";
        }
    }
}
