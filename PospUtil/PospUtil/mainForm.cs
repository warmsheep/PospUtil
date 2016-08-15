﻿using PospUtil.util;
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

       
        

    }
}