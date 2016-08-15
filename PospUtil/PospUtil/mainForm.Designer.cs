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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tbPgEncrypt = new System.Windows.Forms.TabPage();
            this.desEncrypt = new System.Windows.Forms.GroupBox();
            this.btnDesDecrypt = new System.Windows.Forms.Button();
            this.btnDesEncrypt = new System.Windows.Forms.Button();
            this.tboxDesResult = new System.Windows.Forms.TextBox();
            this.tboxDesReqData = new System.Windows.Forms.TextBox();
            this.tboxDesKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbKeyLength = new System.Windows.Forms.Label();
            this.lbReqDataLength = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tbPgEncrypt.SuspendLayout();
            this.desEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tbPgEncrypt);
            this.tabCtrl.Controls.Add(this.tabPage2);
            this.tabCtrl.Location = new System.Drawing.Point(12, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(984, 705);
            this.tabCtrl.TabIndex = 0;
            // 
            // tbPgEncrypt
            // 
            this.tbPgEncrypt.Controls.Add(this.desEncrypt);
            this.tbPgEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tbPgEncrypt.Name = "tbPgEncrypt";
            this.tbPgEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEncrypt.Size = new System.Drawing.Size(976, 679);
            this.tbPgEncrypt.TabIndex = 0;
            this.tbPgEncrypt.Text = "加密";
            this.tbPgEncrypt.UseVisualStyleBackColor = true;
            // 
            // desEncrypt
            // 
            this.desEncrypt.Controls.Add(this.lbReqDataLength);
            this.desEncrypt.Controls.Add(this.lbKeyLength);
            this.desEncrypt.Controls.Add(this.btnDesDecrypt);
            this.desEncrypt.Controls.Add(this.btnDesEncrypt);
            this.desEncrypt.Controls.Add(this.tboxDesResult);
            this.desEncrypt.Controls.Add(this.tboxDesReqData);
            this.desEncrypt.Controls.Add(this.tboxDesKey);
            this.desEncrypt.Controls.Add(this.label3);
            this.desEncrypt.Controls.Add(this.label2);
            this.desEncrypt.Controls.Add(this.label1);
            this.desEncrypt.Location = new System.Drawing.Point(42, 42);
            this.desEncrypt.Name = "desEncrypt";
            this.desEncrypt.Size = new System.Drawing.Size(893, 161);
            this.desEncrypt.TabIndex = 0;
            this.desEncrypt.TabStop = false;
            this.desEncrypt.Text = "3DES加密";
            // 
            // btnDesDecrypt
            // 
            this.btnDesDecrypt.Location = new System.Drawing.Point(789, 130);
            this.btnDesDecrypt.Name = "btnDesDecrypt";
            this.btnDesDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDesDecrypt.TabIndex = 5;
            this.btnDesDecrypt.Text = "解密";
            this.btnDesDecrypt.UseVisualStyleBackColor = true;
            this.btnDesDecrypt.Click += new System.EventHandler(this.btnDesDecrypt_Click);
            // 
            // btnDesEncrypt
            // 
            this.btnDesEncrypt.Location = new System.Drawing.Point(644, 130);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbKeyLength
            // 
            this.lbKeyLength.AutoSize = true;
            this.lbKeyLength.Location = new System.Drawing.Point(806, 26);
            this.lbKeyLength.Name = "lbKeyLength";
            this.lbKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbKeyLength.TabIndex = 6;
            this.lbKeyLength.Text = "0";
            // 
            // lbReqDataLength
            // 
            this.lbReqDataLength.AutoSize = true;
            this.lbReqDataLength.Location = new System.Drawing.Point(806, 59);
            this.lbReqDataLength.Name = "lbReqDataLength";
            this.lbReqDataLength.Size = new System.Drawing.Size(11, 12);
            this.lbReqDataLength.TabIndex = 7;
            this.lbReqDataLength.Text = "0";
            this.lbReqDataLength.Click += new System.EventHandler(this.lbReqDataLength_Click);
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
            this.desEncrypt.ResumeLayout(false);
            this.desEncrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tbPgEncrypt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox desEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxDesResult;
        private System.Windows.Forms.TextBox tboxDesReqData;
        private System.Windows.Forms.TextBox tboxDesKey;
        private System.Windows.Forms.Button btnDesEncrypt;
        private System.Windows.Forms.Button btnDesDecrypt;
        private System.Windows.Forms.Label lbKeyLength;
        private System.Windows.Forms.Label lbReqDataLength;
    }
}

