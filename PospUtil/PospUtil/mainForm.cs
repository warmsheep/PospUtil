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
            if(key == "")
            {
                MessageBox.Show("密钥不能为空！");
                return;
            }
            if(key.Length % 8 != 0)
            {
                MessageBox.Show("密钥长度有误！");
                return;
            }
            string reqData = this.tboxDesReqData.Text.ToString().Trim();
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
            string result = EncryptUtil.desEncrypt(reqData, key);
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
            string reqData = this.tboxDesReqData.Text.ToString().Trim();
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
            string result = EncryptUtil.desDecrypt(reqData, key);
            this.tboxDesResult.Text = result;
        }

        /// <summary>
        /// 密钥文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxDesKey_TextChanged(object sender, EventArgs e)
        {
            this.lbKeyLength.Text = this.tboxDesKey.Text.Length.ToString();
        }

        /// <summary>
        /// 数据文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxDesReqData_TextChanged(object sender, EventArgs e)
        {
            this.lbReqDataLength.Text = this.tboxDesReqData.Text.Length.ToString();
        }

        private void lbReqDataLength_Click(object sender, EventArgs e)
        {

        }
    }
}
