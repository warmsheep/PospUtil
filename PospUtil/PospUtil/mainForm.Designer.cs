namespace PospUtil
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tbPgEncrypt = new System.Windows.Forms.TabPage();
            this.gpBoxMac = new System.Windows.Forms.GroupBox();
            this.tboxMacReqData = new System.Windows.Forms.TextBox();
            this.lbMacReqDataLength = new System.Windows.Forms.Label();
            this.lbMacMacKeyLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMacMasterKeyLength = new System.Windows.Forms.Label();
            this.btnTerminalMac = new System.Windows.Forms.Button();
            this.btnX99Mac = new System.Windows.Forms.Button();
            this.btnMacEncryptX99 = new System.Windows.Forms.Button();
            this.tboxMacResult = new System.Windows.Forms.TextBox();
            this.tboxMacMacKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxMacMasterKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpBoxDesEncrypt = new System.Windows.Forms.GroupBox();
            this.lbDesReqDataLength = new System.Windows.Forms.Label();
            this.lbDesKeyLength = new System.Windows.Forms.Label();
            this.btnDesDecrypt = new System.Windows.Forms.Button();
            this.btnDesEncrypt = new System.Windows.Forms.Button();
            this.tboxDesResult = new System.Windows.Forms.TextBox();
            this.tboxDesReqData = new System.Windows.Forms.TextBox();
            this.tboxDesKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabCtrl.SuspendLayout();
            this.tbPgEncrypt.SuspendLayout();
            this.gpBoxMac.SuspendLayout();
            this.gpBoxDesEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tbPgEncrypt);
            this.tabCtrl.Location = new System.Drawing.Point(12, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(984, 705);
            this.tabCtrl.TabIndex = 0;
            // 
            // tbPgEncrypt
            // 
            this.tbPgEncrypt.Controls.Add(this.gpBoxMac);
            this.tbPgEncrypt.Controls.Add(this.gpBoxDesEncrypt);
            this.tbPgEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tbPgEncrypt.Name = "tbPgEncrypt";
            this.tbPgEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEncrypt.Size = new System.Drawing.Size(976, 679);
            this.tbPgEncrypt.TabIndex = 0;
            this.tbPgEncrypt.Text = "加密";
            this.tbPgEncrypt.UseVisualStyleBackColor = true;
            // 
            // gpBoxMac
            // 
            this.gpBoxMac.Controls.Add(this.tboxMacReqData);
            this.gpBoxMac.Controls.Add(this.lbMacReqDataLength);
            this.gpBoxMac.Controls.Add(this.lbMacMacKeyLength);
            this.gpBoxMac.Controls.Add(this.label4);
            this.gpBoxMac.Controls.Add(this.lbMacMasterKeyLength);
            this.gpBoxMac.Controls.Add(this.btnTerminalMac);
            this.gpBoxMac.Controls.Add(this.btnX99Mac);
            this.gpBoxMac.Controls.Add(this.btnMacEncryptX99);
            this.gpBoxMac.Controls.Add(this.tboxMacResult);
            this.gpBoxMac.Controls.Add(this.tboxMacMacKey);
            this.gpBoxMac.Controls.Add(this.label9);
            this.gpBoxMac.Controls.Add(this.tboxMacMasterKey);
            this.gpBoxMac.Controls.Add(this.label6);
            this.gpBoxMac.Controls.Add(this.label7);
            this.gpBoxMac.Controls.Add(this.label8);
            this.gpBoxMac.Location = new System.Drawing.Point(42, 224);
            this.gpBoxMac.Name = "gpBoxMac";
            this.gpBoxMac.Size = new System.Drawing.Size(893, 270);
            this.gpBoxMac.TabIndex = 0;
            this.gpBoxMac.TabStop = false;
            this.gpBoxMac.Text = "MAC计算";
            // 
            // tboxMacReqData
            // 
            this.tboxMacReqData.Location = new System.Drawing.Point(99, 94);
            this.tboxMacReqData.Multiline = true;
            this.tboxMacReqData.Name = "tboxMacReqData";
            this.tboxMacReqData.Size = new System.Drawing.Size(676, 76);
            this.tboxMacReqData.TabIndex = 1;
            this.tboxMacReqData.TextChanged += new System.EventHandler(this.tboxMacReqData_TextChanged);
            // 
            // lbMacReqDataLength
            // 
            this.lbMacReqDataLength.AutoSize = true;
            this.lbMacReqDataLength.Location = new System.Drawing.Point(806, 94);
            this.lbMacReqDataLength.Name = "lbMacReqDataLength";
            this.lbMacReqDataLength.Size = new System.Drawing.Size(11, 12);
            this.lbMacReqDataLength.TabIndex = 7;
            this.lbMacReqDataLength.Text = "0";
            this.lbMacReqDataLength.Click += new System.EventHandler(this.lbReqDataLength_Click);
            // 
            // lbMacMacKeyLength
            // 
            this.lbMacMacKeyLength.AutoSize = true;
            this.lbMacMacKeyLength.Location = new System.Drawing.Point(806, 59);
            this.lbMacMacKeyLength.Name = "lbMacMacKeyLength";
            this.lbMacMacKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbMacMacKeyLength.TabIndex = 7;
            this.lbMacMacKeyLength.Text = "0";
            this.lbMacMacKeyLength.Click += new System.EventHandler(this.lbReqDataLength_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(806, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.lbReqDataLength_Click);
            // 
            // lbMacMasterKeyLength
            // 
            this.lbMacMasterKeyLength.AutoSize = true;
            this.lbMacMasterKeyLength.Location = new System.Drawing.Point(806, 26);
            this.lbMacMasterKeyLength.Name = "lbMacMasterKeyLength";
            this.lbMacMasterKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbMacMasterKeyLength.TabIndex = 6;
            this.lbMacMasterKeyLength.Text = "0";
            // 
            // btnTerminalMac
            // 
            this.btnTerminalMac.Location = new System.Drawing.Point(681, 223);
            this.btnTerminalMac.Name = "btnTerminalMac";
            this.btnTerminalMac.Size = new System.Drawing.Size(94, 23);
            this.btnTerminalMac.TabIndex = 4;
            this.btnTerminalMac.Text = "终端MAC计算";
            this.btnTerminalMac.UseVisualStyleBackColor = true;
            this.btnTerminalMac.Click += new System.EventHandler(this.btnTerminalMac_Click);
            // 
            // btnX99Mac
            // 
            this.btnX99Mac.Location = new System.Drawing.Point(568, 223);
            this.btnX99Mac.Name = "btnX99Mac";
            this.btnX99Mac.Size = new System.Drawing.Size(94, 23);
            this.btnX99Mac.TabIndex = 4;
            this.btnX99Mac.Text = "X919-MAC计算";
            this.btnX99Mac.UseVisualStyleBackColor = true;
            this.btnX99Mac.Click += new System.EventHandler(this.btnMacEncryptX919_Click);
            // 
            // btnMacEncryptX99
            // 
            this.btnMacEncryptX99.Location = new System.Drawing.Point(455, 223);
            this.btnMacEncryptX99.Name = "btnMacEncryptX99";
            this.btnMacEncryptX99.Size = new System.Drawing.Size(94, 23);
            this.btnMacEncryptX99.TabIndex = 4;
            this.btnMacEncryptX99.Text = "X99-MAC计算";
            this.btnMacEncryptX99.UseVisualStyleBackColor = true;
            this.btnMacEncryptX99.Click += new System.EventHandler(this.btnMacEncryptX99_Click);
            // 
            // tboxMacResult
            // 
            this.tboxMacResult.Location = new System.Drawing.Point(99, 186);
            this.tboxMacResult.Name = "tboxMacResult";
            this.tboxMacResult.ReadOnly = true;
            this.tboxMacResult.Size = new System.Drawing.Size(676, 21);
            this.tboxMacResult.TabIndex = 3;
            // 
            // tboxMacMacKey
            // 
            this.tboxMacMacKey.Location = new System.Drawing.Point(99, 56);
            this.tboxMacMacKey.MaxLength = 48;
            this.tboxMacMacKey.Name = "tboxMacMacKey";
            this.tboxMacMacKey.Size = new System.Drawing.Size(676, 21);
            this.tboxMacMacKey.TabIndex = 3;
            this.tboxMacMacKey.TextChanged += new System.EventHandler(this.tboxMacMacKey_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "结果";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // tboxMacMasterKey
            // 
            this.tboxMacMasterKey.Location = new System.Drawing.Point(99, 21);
            this.tboxMacMasterKey.MaxLength = 48;
            this.tboxMacMasterKey.Name = "tboxMacMasterKey";
            this.tboxMacMasterKey.Size = new System.Drawing.Size(676, 21);
            this.tboxMacMasterKey.TabIndex = 3;
            this.tboxMacMasterKey.TextChanged += new System.EventHandler(this.tboxMacMasterKey_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "数据";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "MAC密钥";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "主密钥";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpBoxDesEncrypt
            // 
            this.gpBoxDesEncrypt.Controls.Add(this.lbDesReqDataLength);
            this.gpBoxDesEncrypt.Controls.Add(this.lbDesKeyLength);
            this.gpBoxDesEncrypt.Controls.Add(this.btnDesDecrypt);
            this.gpBoxDesEncrypt.Controls.Add(this.btnDesEncrypt);
            this.gpBoxDesEncrypt.Controls.Add(this.tboxDesResult);
            this.gpBoxDesEncrypt.Controls.Add(this.tboxDesReqData);
            this.gpBoxDesEncrypt.Controls.Add(this.tboxDesKey);
            this.gpBoxDesEncrypt.Controls.Add(this.label3);
            this.gpBoxDesEncrypt.Controls.Add(this.label2);
            this.gpBoxDesEncrypt.Controls.Add(this.label1);
            this.gpBoxDesEncrypt.Location = new System.Drawing.Point(42, 42);
            this.gpBoxDesEncrypt.Name = "gpBoxDesEncrypt";
            this.gpBoxDesEncrypt.Size = new System.Drawing.Size(893, 161);
            this.gpBoxDesEncrypt.TabIndex = 0;
            this.gpBoxDesEncrypt.TabStop = false;
            this.gpBoxDesEncrypt.Text = "3DES加密";
            // 
            // lbDesReqDataLength
            // 
            this.lbDesReqDataLength.AutoSize = true;
            this.lbDesReqDataLength.Location = new System.Drawing.Point(806, 59);
            this.lbDesReqDataLength.Name = "lbDesReqDataLength";
            this.lbDesReqDataLength.Size = new System.Drawing.Size(11, 12);
            this.lbDesReqDataLength.TabIndex = 7;
            this.lbDesReqDataLength.Text = "0";
            this.lbDesReqDataLength.Click += new System.EventHandler(this.lbReqDataLength_Click);
            // 
            // lbDesKeyLength
            // 
            this.lbDesKeyLength.AutoSize = true;
            this.lbDesKeyLength.Location = new System.Drawing.Point(806, 26);
            this.lbDesKeyLength.Name = "lbDesKeyLength";
            this.lbDesKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbDesKeyLength.TabIndex = 6;
            this.lbDesKeyLength.Text = "0";
            // 
            // btnDesDecrypt
            // 
            this.btnDesDecrypt.Location = new System.Drawing.Point(700, 130);
            this.btnDesDecrypt.Name = "btnDesDecrypt";
            this.btnDesDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDesDecrypt.TabIndex = 5;
            this.btnDesDecrypt.Text = "解密";
            this.btnDesDecrypt.UseVisualStyleBackColor = true;
            this.btnDesDecrypt.Click += new System.EventHandler(this.btnDesDecrypt_Click);
            // 
            // btnDesEncrypt
            // 
            this.btnDesEncrypt.Location = new System.Drawing.Point(587, 130);
            this.btnDesEncrypt.Name = "btnDesEncrypt";
            this.btnDesEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDesEncrypt.TabIndex = 4;
            this.btnDesEncrypt.Text = "加密";
            this.btnDesEncrypt.UseVisualStyleBackColor = true;
            this.btnDesEncrypt.Click += new System.EventHandler(this.btnDesEncrypt_Click);
            // 
            // tboxDesResult
            // 
            this.tboxDesResult.Location = new System.Drawing.Point(99, 91);
            this.tboxDesResult.Name = "tboxDesResult";
            this.tboxDesResult.ReadOnly = true;
            this.tboxDesResult.Size = new System.Drawing.Size(676, 21);
            this.tboxDesResult.TabIndex = 3;
            // 
            // tboxDesReqData
            // 
            this.tboxDesReqData.Location = new System.Drawing.Point(99, 56);
            this.tboxDesReqData.Name = "tboxDesReqData";
            this.tboxDesReqData.Size = new System.Drawing.Size(676, 21);
            this.tboxDesReqData.TabIndex = 3;
            this.tboxDesReqData.TextChanged += new System.EventHandler(this.tboxDesReqData_TextChanged);
            // 
            // tboxDesKey
            // 
            this.tboxDesKey.Location = new System.Drawing.Point(99, 21);
            this.tboxDesKey.MaxLength = 48;
            this.tboxDesKey.Name = "tboxDesKey";
            this.tboxDesKey.Size = new System.Drawing.Size(676, 21);
            this.tboxDesKey.TabIndex = 3;
            this.tboxDesKey.TextChanged += new System.EventHandler(this.tboxDesKey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "结果";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "密钥";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabCtrl);
            this.Name = "mainForm";
            this.Text = "POSP工具箱";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tbPgEncrypt.ResumeLayout(false);
            this.gpBoxMac.ResumeLayout(false);
            this.gpBoxMac.PerformLayout();
            this.gpBoxDesEncrypt.ResumeLayout(false);
            this.gpBoxDesEncrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tbPgEncrypt;
        private System.Windows.Forms.GroupBox gpBoxDesEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxDesResult;
        private System.Windows.Forms.TextBox tboxDesReqData;
        private System.Windows.Forms.TextBox tboxDesKey;
        private System.Windows.Forms.Button btnDesEncrypt;
        private System.Windows.Forms.Button btnDesDecrypt;
        private System.Windows.Forms.Label lbDesKeyLength;
        private System.Windows.Forms.Label lbDesReqDataLength;
        private System.Windows.Forms.GroupBox gpBoxMac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMacMasterKeyLength;
        private System.Windows.Forms.Button btnMacEncryptX99;
        private System.Windows.Forms.TextBox tboxMacMacKey;
        private System.Windows.Forms.TextBox tboxMacMasterKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxMacResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMacReqDataLength;
        private System.Windows.Forms.Label lbMacMacKeyLength;
        private System.Windows.Forms.Button btnX99Mac;
        private System.Windows.Forms.Button btnTerminalMac;
        private System.Windows.Forms.TextBox tboxMacReqData;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

