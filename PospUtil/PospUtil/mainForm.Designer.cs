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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tbPgEncrypt = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnEncSha1 = new System.Windows.Forms.RadioButton();
            this.rbtnEncMd5 = new System.Windows.Forms.RadioButton();
            this.tboxEncResult = new System.Windows.Forms.TextBox();
            this.tboxEncReqData = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEncEncrypt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.gpBoxPinEncrypt = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPinDecrypt = new System.Windows.Forms.Button();
            this.btnPinEncrypt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbPinPasswordLength = new System.Windows.Forms.Label();
            this.lbPinCardNoLength = new System.Windows.Forms.Label();
            this.lbPinMasterKeyLength = new System.Windows.Forms.Label();
            this.lbPinKeyLength = new System.Windows.Forms.Label();
            this.tboxPinResult = new System.Windows.Forms.TextBox();
            this.tboxPinPassword = new System.Windows.Forms.TextBox();
            this.tboxPinCardNo = new System.Windows.Forms.TextBox();
            this.tboxPinMasterKey = new System.Windows.Forms.TextBox();
            this.tboxPinKey = new System.Windows.Forms.TextBox();
            this.gpBoxXor = new System.Windows.Forms.GroupBox();
            this.lbXorReqDataLength = new System.Windows.Forms.Label();
            this.tboxXorReqData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxXorResult = new System.Windows.Forms.TextBox();
            this.gpBoxMac = new System.Windows.Forms.GroupBox();
            this.tboxMacReqData = new System.Windows.Forms.TextBox();
            this.lbMacReqDataLength = new System.Windows.Forms.Label();
            this.lbMacMacKeyLength = new System.Windows.Forms.Label();
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
            this.toolTipMacEncrypt = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.密钥ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyZmkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyZpkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTmkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyZakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyZekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEdkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrl.SuspendLayout();
            this.tbPgEncrypt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpBoxPinEncrypt.SuspendLayout();
            this.gpBoxXor.SuspendLayout();
            this.gpBoxMac.SuspendLayout();
            this.gpBoxDesEncrypt.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tbPgEncrypt);
            this.tabCtrl.Location = new System.Drawing.Point(12, 28);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(984, 621);
            this.tabCtrl.TabIndex = 0;
            // 
            // tbPgEncrypt
            // 
            this.tbPgEncrypt.Controls.Add(this.groupBox1);
            this.tbPgEncrypt.Controls.Add(this.gpBoxPinEncrypt);
            this.tbPgEncrypt.Controls.Add(this.gpBoxXor);
            this.tbPgEncrypt.Controls.Add(this.gpBoxMac);
            this.tbPgEncrypt.Controls.Add(this.gpBoxDesEncrypt);
            this.tbPgEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tbPgEncrypt.Name = "tbPgEncrypt";
            this.tbPgEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEncrypt.Size = new System.Drawing.Size(976, 595);
            this.tbPgEncrypt.TabIndex = 0;
            this.tbPgEncrypt.Text = "加密";
            this.tbPgEncrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnEncSha1);
            this.groupBox1.Controls.Add(this.rbtnEncMd5);
            this.groupBox1.Controls.Add(this.tboxEncResult);
            this.groupBox1.Controls.Add(this.tboxEncReqData);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnEncEncrypt);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(499, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常用算法";
            // 
            // rbtnEncSha1
            // 
            this.rbtnEncSha1.AutoSize = true;
            this.rbtnEncSha1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnEncSha1.Location = new System.Drawing.Point(183, 20);
            this.rbtnEncSha1.Name = "rbtnEncSha1";
            this.rbtnEncSha1.Size = new System.Drawing.Size(47, 16);
            this.rbtnEncSha1.TabIndex = 5;
            this.rbtnEncSha1.Text = "SHA1";
            this.rbtnEncSha1.UseVisualStyleBackColor = true;
            // 
            // rbtnEncMd5
            // 
            this.rbtnEncMd5.AutoSize = true;
            this.rbtnEncMd5.Checked = true;
            this.rbtnEncMd5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnEncMd5.Location = new System.Drawing.Point(99, 20);
            this.rbtnEncMd5.Name = "rbtnEncMd5";
            this.rbtnEncMd5.Size = new System.Drawing.Size(41, 16);
            this.rbtnEncMd5.TabIndex = 5;
            this.rbtnEncMd5.TabStop = true;
            this.rbtnEncMd5.Text = "MD5";
            this.rbtnEncMd5.UseVisualStyleBackColor = true;
            // 
            // tboxEncResult
            // 
            this.tboxEncResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxEncResult.Location = new System.Drawing.Point(99, 129);
            this.tboxEncResult.Multiline = true;
            this.tboxEncResult.Name = "tboxEncResult";
            this.tboxEncResult.ReadOnly = true;
            this.tboxEncResult.Size = new System.Drawing.Size(299, 58);
            this.tboxEncResult.TabIndex = 1;
            this.tboxEncResult.TextChanged += new System.EventHandler(this.tboxMacReqData_TextChanged);
            // 
            // tboxEncReqData
            // 
            this.tboxEncReqData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxEncReqData.Location = new System.Drawing.Point(99, 56);
            this.tboxEncReqData.Multiline = true;
            this.tboxEncReqData.Name = "tboxEncReqData";
            this.tboxEncReqData.Size = new System.Drawing.Size(299, 58);
            this.tboxEncReqData.TabIndex = 1;
            this.tboxEncReqData.TextChanged += new System.EventHandler(this.tboxMacReqData_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(25, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "结果";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(25, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "数据";
            // 
            // btnEncEncrypt
            // 
            this.btnEncEncrypt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEncEncrypt.Location = new System.Drawing.Point(323, 198);
            this.btnEncEncrypt.Name = "btnEncEncrypt";
            this.btnEncEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncEncrypt.TabIndex = 4;
            this.btnEncEncrypt.Text = "加密";
            this.btnEncEncrypt.UseVisualStyleBackColor = true;
            this.btnEncEncrypt.Click += new System.EventHandler(this.btnEncEncrypt_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(23, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "算法";
            // 
            // gpBoxPinEncrypt
            // 
            this.gpBoxPinEncrypt.Controls.Add(this.label16);
            this.gpBoxPinEncrypt.Controls.Add(this.label15);
            this.gpBoxPinEncrypt.Controls.Add(this.label12);
            this.gpBoxPinEncrypt.Controls.Add(this.btnPinDecrypt);
            this.gpBoxPinEncrypt.Controls.Add(this.btnPinEncrypt);
            this.gpBoxPinEncrypt.Controls.Add(this.label11);
            this.gpBoxPinEncrypt.Controls.Add(this.label10);
            this.gpBoxPinEncrypt.Controls.Add(this.lbPinPasswordLength);
            this.gpBoxPinEncrypt.Controls.Add(this.lbPinCardNoLength);
            this.gpBoxPinEncrypt.Controls.Add(this.lbPinMasterKeyLength);
            this.gpBoxPinEncrypt.Controls.Add(this.lbPinKeyLength);
            this.gpBoxPinEncrypt.Controls.Add(this.tboxPinResult);
            this.gpBoxPinEncrypt.Controls.Add(this.tboxPinPassword);
            this.gpBoxPinEncrypt.Controls.Add(this.tboxPinCardNo);
            this.gpBoxPinEncrypt.Controls.Add(this.tboxPinMasterKey);
            this.gpBoxPinEncrypt.Controls.Add(this.tboxPinKey);
            this.gpBoxPinEncrypt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpBoxPinEncrypt.Location = new System.Drawing.Point(22, 347);
            this.gpBoxPinEncrypt.Name = "gpBoxPinEncrypt";
            this.gpBoxPinEncrypt.Size = new System.Drawing.Size(453, 232);
            this.gpBoxPinEncrypt.TabIndex = 2;
            this.gpBoxPinEncrypt.TabStop = false;
            this.gpBoxPinEncrypt.Text = "PIN加密";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(23, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "结果";
            this.label16.Click += new System.EventHandler(this.label3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(23, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "密码";
            this.label15.Click += new System.EventHandler(this.label3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(23, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "卡号";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnPinDecrypt
            // 
            this.btnPinDecrypt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPinDecrypt.Location = new System.Drawing.Point(323, 198);
            this.btnPinDecrypt.Name = "btnPinDecrypt";
            this.btnPinDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnPinDecrypt.TabIndex = 4;
            this.btnPinDecrypt.Text = "解密";
            this.btnPinDecrypt.UseVisualStyleBackColor = true;
            this.btnPinDecrypt.Click += new System.EventHandler(this.btnPinDecrypt_Click);
            // 
            // btnPinEncrypt
            // 
            this.btnPinEncrypt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPinEncrypt.Location = new System.Drawing.Point(227, 198);
            this.btnPinEncrypt.Name = "btnPinEncrypt";
            this.btnPinEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnPinEncrypt.TabIndex = 4;
            this.btnPinEncrypt.Text = "加密";
            this.btnPinEncrypt.UseVisualStyleBackColor = true;
            this.btnPinEncrypt.Click += new System.EventHandler(this.btnPinEncrypt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(23, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "主密钥";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(23, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "PIN密钥";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbPinPasswordLength
            // 
            this.lbPinPasswordLength.AutoSize = true;
            this.lbPinPasswordLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPinPasswordLength.Location = new System.Drawing.Point(404, 132);
            this.lbPinPasswordLength.Name = "lbPinPasswordLength";
            this.lbPinPasswordLength.Size = new System.Drawing.Size(11, 12);
            this.lbPinPasswordLength.TabIndex = 6;
            this.lbPinPasswordLength.Text = "0";
            // 
            // lbPinCardNoLength
            // 
            this.lbPinCardNoLength.AutoSize = true;
            this.lbPinCardNoLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPinCardNoLength.Location = new System.Drawing.Point(404, 96);
            this.lbPinCardNoLength.Name = "lbPinCardNoLength";
            this.lbPinCardNoLength.Size = new System.Drawing.Size(11, 12);
            this.lbPinCardNoLength.TabIndex = 6;
            this.lbPinCardNoLength.Text = "0";
            // 
            // lbPinMasterKeyLength
            // 
            this.lbPinMasterKeyLength.AutoSize = true;
            this.lbPinMasterKeyLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPinMasterKeyLength.Location = new System.Drawing.Point(404, 24);
            this.lbPinMasterKeyLength.Name = "lbPinMasterKeyLength";
            this.lbPinMasterKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbPinMasterKeyLength.TabIndex = 6;
            this.lbPinMasterKeyLength.Text = "0";
            // 
            // lbPinKeyLength
            // 
            this.lbPinKeyLength.AutoSize = true;
            this.lbPinKeyLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPinKeyLength.Location = new System.Drawing.Point(404, 60);
            this.lbPinKeyLength.Name = "lbPinKeyLength";
            this.lbPinKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbPinKeyLength.TabIndex = 6;
            this.lbPinKeyLength.Text = "0";
            // 
            // tboxPinResult
            // 
            this.tboxPinResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxPinResult.Location = new System.Drawing.Point(99, 165);
            this.tboxPinResult.MaxLength = 48;
            this.tboxPinResult.Name = "tboxPinResult";
            this.tboxPinResult.ReadOnly = true;
            this.tboxPinResult.Size = new System.Drawing.Size(299, 21);
            this.tboxPinResult.TabIndex = 3;
            this.tboxPinResult.TextChanged += new System.EventHandler(this.tboxDesKey_TextChanged);
            // 
            // tboxPinPassword
            // 
            this.tboxPinPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxPinPassword.Location = new System.Drawing.Point(99, 129);
            this.tboxPinPassword.MaxLength = 48;
            this.tboxPinPassword.Name = "tboxPinPassword";
            this.tboxPinPassword.Size = new System.Drawing.Size(299, 21);
            this.tboxPinPassword.TabIndex = 3;
            this.tboxPinPassword.TextChanged += new System.EventHandler(this.tboxPinPassword_TextChanged);
            // 
            // tboxPinCardNo
            // 
            this.tboxPinCardNo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxPinCardNo.Location = new System.Drawing.Point(99, 93);
            this.tboxPinCardNo.MaxLength = 48;
            this.tboxPinCardNo.Name = "tboxPinCardNo";
            this.tboxPinCardNo.Size = new System.Drawing.Size(299, 21);
            this.tboxPinCardNo.TabIndex = 3;
            this.tboxPinCardNo.TextChanged += new System.EventHandler(this.tboxPinCardNo_TextChanged);
            // 
            // tboxPinMasterKey
            // 
            this.tboxPinMasterKey.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxPinMasterKey.Location = new System.Drawing.Point(99, 21);
            this.tboxPinMasterKey.MaxLength = 48;
            this.tboxPinMasterKey.Name = "tboxPinMasterKey";
            this.tboxPinMasterKey.Size = new System.Drawing.Size(299, 21);
            this.tboxPinMasterKey.TabIndex = 3;
            this.tboxPinMasterKey.TextChanged += new System.EventHandler(this.tboxPinMasterKey_TextChanged);
            // 
            // tboxPinKey
            // 
            this.tboxPinKey.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxPinKey.Location = new System.Drawing.Point(99, 57);
            this.tboxPinKey.MaxLength = 48;
            this.tboxPinKey.Name = "tboxPinKey";
            this.tboxPinKey.Size = new System.Drawing.Size(299, 21);
            this.tboxPinKey.TabIndex = 3;
            this.tboxPinKey.TextChanged += new System.EventHandler(this.tboxPinKey_TextChanged);
            // 
            // gpBoxXor
            // 
            this.gpBoxXor.Controls.Add(this.lbXorReqDataLength);
            this.gpBoxXor.Controls.Add(this.tboxXorReqData);
            this.gpBoxXor.Controls.Add(this.label4);
            this.gpBoxXor.Controls.Add(this.btnXor);
            this.gpBoxXor.Controls.Add(this.label5);
            this.gpBoxXor.Controls.Add(this.tboxXorResult);
            this.gpBoxXor.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpBoxXor.Location = new System.Drawing.Point(22, 181);
            this.gpBoxXor.Name = "gpBoxXor";
            this.gpBoxXor.Size = new System.Drawing.Size(453, 157);
            this.gpBoxXor.TabIndex = 1;
            this.gpBoxXor.TabStop = false;
            this.gpBoxXor.Text = "分组异或";
            // 
            // lbXorReqDataLength
            // 
            this.lbXorReqDataLength.AutoSize = true;
            this.lbXorReqDataLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbXorReqDataLength.Location = new System.Drawing.Point(404, 21);
            this.lbXorReqDataLength.Name = "lbXorReqDataLength";
            this.lbXorReqDataLength.Size = new System.Drawing.Size(11, 12);
            this.lbXorReqDataLength.TabIndex = 7;
            this.lbXorReqDataLength.Text = "0";
            this.lbXorReqDataLength.Click += new System.EventHandler(this.lbReqDataLength_Click);
            // 
            // tboxXorReqData
            // 
            this.tboxXorReqData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxXorReqData.Location = new System.Drawing.Point(99, 18);
            this.tboxXorReqData.Multiline = true;
            this.tboxXorReqData.Name = "tboxXorReqData";
            this.tboxXorReqData.Size = new System.Drawing.Size(299, 92);
            this.tboxXorReqData.TabIndex = 1;
            this.tboxXorReqData.TextChanged += new System.EventHandler(this.tboxXorReqData_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "数据";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnXor
            // 
            this.btnXor.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXor.Location = new System.Drawing.Point(323, 120);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(75, 23);
            this.btnXor.TabIndex = 4;
            this.btnXor.Text = "异或";
            this.btnXor.UseVisualStyleBackColor = true;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(25, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "结果";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // tboxXorResult
            // 
            this.tboxXorResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxXorResult.Location = new System.Drawing.Point(99, 120);
            this.tboxXorResult.Name = "tboxXorResult";
            this.tboxXorResult.ReadOnly = true;
            this.tboxXorResult.Size = new System.Drawing.Size(203, 21);
            this.tboxXorResult.TabIndex = 3;
            // 
            // gpBoxMac
            // 
            this.gpBoxMac.Controls.Add(this.tboxMacReqData);
            this.gpBoxMac.Controls.Add(this.lbMacReqDataLength);
            this.gpBoxMac.Controls.Add(this.lbMacMacKeyLength);
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
            this.gpBoxMac.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpBoxMac.Location = new System.Drawing.Point(499, 14);
            this.gpBoxMac.Name = "gpBoxMac";
            this.gpBoxMac.Size = new System.Drawing.Size(454, 324);
            this.gpBoxMac.TabIndex = 0;
            this.gpBoxMac.TabStop = false;
            this.gpBoxMac.Text = "MAC计算";
            // 
            // tboxMacReqData
            // 
            this.tboxMacReqData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxMacReqData.Location = new System.Drawing.Point(99, 94);
            this.tboxMacReqData.Multiline = true;
            this.tboxMacReqData.Name = "tboxMacReqData";
            this.tboxMacReqData.Size = new System.Drawing.Size(299, 141);
            this.tboxMacReqData.TabIndex = 1;
            this.tboxMacReqData.TextChanged += new System.EventHandler(this.tboxMacReqData_TextChanged);
            // 
            // lbMacReqDataLength
            // 
            this.lbMacReqDataLength.AutoSize = true;
            this.lbMacReqDataLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMacReqDataLength.Location = new System.Drawing.Point(404, 94);
            this.lbMacReqDataLength.Name = "lbMacReqDataLength";
            this.lbMacReqDataLength.Size = new System.Drawing.Size(11, 12);
            this.lbMacReqDataLength.TabIndex = 7;
            this.lbMacReqDataLength.Text = "0";
            this.lbMacReqDataLength.Click += new System.EventHandler(this.lbReqDataLength_Click);
            // 
            // lbMacMacKeyLength
            // 
            this.lbMacMacKeyLength.AutoSize = true;
            this.lbMacMacKeyLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMacMacKeyLength.Location = new System.Drawing.Point(404, 59);
            this.lbMacMacKeyLength.Name = "lbMacMacKeyLength";
            this.lbMacMacKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbMacMacKeyLength.TabIndex = 7;
            this.lbMacMacKeyLength.Text = "0";
            this.lbMacMacKeyLength.Click += new System.EventHandler(this.lbReqDataLength_Click);
            // 
            // lbMacMasterKeyLength
            // 
            this.lbMacMasterKeyLength.AutoSize = true;
            this.lbMacMasterKeyLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMacMasterKeyLength.Location = new System.Drawing.Point(404, 26);
            this.lbMacMasterKeyLength.Name = "lbMacMasterKeyLength";
            this.lbMacMasterKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbMacMasterKeyLength.TabIndex = 6;
            this.lbMacMasterKeyLength.Text = "0";
            // 
            // btnTerminalMac
            // 
            this.btnTerminalMac.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTerminalMac.Location = new System.Drawing.Point(304, 288);
            this.btnTerminalMac.Name = "btnTerminalMac";
            this.btnTerminalMac.Size = new System.Drawing.Size(94, 23);
            this.btnTerminalMac.TabIndex = 4;
            this.btnTerminalMac.Text = "终端MAC计算";
            this.btnTerminalMac.UseVisualStyleBackColor = true;
            this.btnTerminalMac.Click += new System.EventHandler(this.btnTerminalMac_Click);
            this.btnTerminalMac.MouseHover += new System.EventHandler(this.btnTerminalMac_MouseHover);
            // 
            // btnX99Mac
            // 
            this.btnX99Mac.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnX99Mac.Location = new System.Drawing.Point(201, 288);
            this.btnX99Mac.Name = "btnX99Mac";
            this.btnX99Mac.Size = new System.Drawing.Size(94, 23);
            this.btnX99Mac.TabIndex = 4;
            this.btnX99Mac.Text = "X919-MAC计算";
            this.btnX99Mac.UseVisualStyleBackColor = true;
            this.btnX99Mac.Click += new System.EventHandler(this.btnMacEncryptX919_Click);
            // 
            // btnMacEncryptX99
            // 
            this.btnMacEncryptX99.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMacEncryptX99.Location = new System.Drawing.Point(99, 288);
            this.btnMacEncryptX99.Name = "btnMacEncryptX99";
            this.btnMacEncryptX99.Size = new System.Drawing.Size(94, 23);
            this.btnMacEncryptX99.TabIndex = 4;
            this.btnMacEncryptX99.Text = "X99-MAC计算";
            this.btnMacEncryptX99.UseVisualStyleBackColor = true;
            this.btnMacEncryptX99.Click += new System.EventHandler(this.btnMacEncryptX99_Click);
            // 
            // tboxMacResult
            // 
            this.tboxMacResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxMacResult.Location = new System.Drawing.Point(99, 251);
            this.tboxMacResult.Name = "tboxMacResult";
            this.tboxMacResult.ReadOnly = true;
            this.tboxMacResult.Size = new System.Drawing.Size(299, 21);
            this.tboxMacResult.TabIndex = 3;
            // 
            // tboxMacMacKey
            // 
            this.tboxMacMacKey.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxMacMacKey.Location = new System.Drawing.Point(99, 56);
            this.tboxMacMacKey.MaxLength = 48;
            this.tboxMacMacKey.Name = "tboxMacMacKey";
            this.tboxMacMacKey.Size = new System.Drawing.Size(299, 21);
            this.tboxMacMacKey.TabIndex = 3;
            this.tboxMacMacKey.TextChanged += new System.EventHandler(this.tboxMacMacKey_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(25, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "结果";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // tboxMacMasterKey
            // 
            this.tboxMacMasterKey.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxMacMasterKey.Location = new System.Drawing.Point(99, 21);
            this.tboxMacMasterKey.MaxLength = 48;
            this.tboxMacMasterKey.Name = "tboxMacMasterKey";
            this.tboxMacMasterKey.Size = new System.Drawing.Size(299, 21);
            this.tboxMacMasterKey.TabIndex = 3;
            this.tboxMacMasterKey.TextChanged += new System.EventHandler(this.tboxMacMasterKey_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(25, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "MAC密钥";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.gpBoxDesEncrypt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpBoxDesEncrypt.Location = new System.Drawing.Point(22, 14);
            this.gpBoxDesEncrypt.Name = "gpBoxDesEncrypt";
            this.gpBoxDesEncrypt.Size = new System.Drawing.Size(453, 161);
            this.gpBoxDesEncrypt.TabIndex = 0;
            this.gpBoxDesEncrypt.TabStop = false;
            this.gpBoxDesEncrypt.Text = "3DES加密";
            // 
            // lbDesReqDataLength
            // 
            this.lbDesReqDataLength.AutoSize = true;
            this.lbDesReqDataLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDesReqDataLength.Location = new System.Drawing.Point(404, 59);
            this.lbDesReqDataLength.Name = "lbDesReqDataLength";
            this.lbDesReqDataLength.Size = new System.Drawing.Size(11, 12);
            this.lbDesReqDataLength.TabIndex = 7;
            this.lbDesReqDataLength.Text = "0";
            this.lbDesReqDataLength.Click += new System.EventHandler(this.lbReqDataLength_Click);
            // 
            // lbDesKeyLength
            // 
            this.lbDesKeyLength.AutoSize = true;
            this.lbDesKeyLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDesKeyLength.Location = new System.Drawing.Point(404, 26);
            this.lbDesKeyLength.Name = "lbDesKeyLength";
            this.lbDesKeyLength.Size = new System.Drawing.Size(11, 12);
            this.lbDesKeyLength.TabIndex = 6;
            this.lbDesKeyLength.Text = "0";
            // 
            // btnDesDecrypt
            // 
            this.btnDesDecrypt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDesDecrypt.Location = new System.Drawing.Point(323, 130);
            this.btnDesDecrypt.Name = "btnDesDecrypt";
            this.btnDesDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDesDecrypt.TabIndex = 5;
            this.btnDesDecrypt.Text = "解密";
            this.btnDesDecrypt.UseVisualStyleBackColor = true;
            this.btnDesDecrypt.Click += new System.EventHandler(this.btnDesDecrypt_Click);
            // 
            // btnDesEncrypt
            // 
            this.btnDesEncrypt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDesEncrypt.Location = new System.Drawing.Point(227, 130);
            this.btnDesEncrypt.Name = "btnDesEncrypt";
            this.btnDesEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDesEncrypt.TabIndex = 4;
            this.btnDesEncrypt.Text = "加密";
            this.btnDesEncrypt.UseVisualStyleBackColor = true;
            this.btnDesEncrypt.Click += new System.EventHandler(this.btnDesEncrypt_Click);
            // 
            // tboxDesResult
            // 
            this.tboxDesResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxDesResult.Location = new System.Drawing.Point(99, 91);
            this.tboxDesResult.Name = "tboxDesResult";
            this.tboxDesResult.ReadOnly = true;
            this.tboxDesResult.Size = new System.Drawing.Size(299, 21);
            this.tboxDesResult.TabIndex = 3;
            // 
            // tboxDesReqData
            // 
            this.tboxDesReqData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxDesReqData.Location = new System.Drawing.Point(99, 56);
            this.tboxDesReqData.Name = "tboxDesReqData";
            this.tboxDesReqData.Size = new System.Drawing.Size(299, 21);
            this.tboxDesReqData.TabIndex = 3;
            this.tboxDesReqData.TextChanged += new System.EventHandler(this.tboxDesReqData_TextChanged);
            // 
            // tboxDesKey
            // 
            this.tboxDesKey.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tboxDesKey.Location = new System.Drawing.Point(99, 21);
            this.tboxDesKey.MaxLength = 48;
            this.tboxDesKey.Name = "tboxDesKey";
            this.tboxDesKey.Size = new System.Drawing.Size(299, 21);
            this.tboxDesKey.TabIndex = 3;
            this.tboxDesKey.TextChanged += new System.EventHandler(this.tboxDesKey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "密钥";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolTipMacEncrypt
            // 
            this.toolTipMacEncrypt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密钥ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 密钥ToolStripMenuItem
            // 
            this.密钥ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyZmkToolStripMenuItem,
            this.copyZpkToolStripMenuItem,
            this.copyTmkToolStripMenuItem,
            this.copyTakToolStripMenuItem,
            this.copyZakToolStripMenuItem,
            this.copyZekToolStripMenuItem,
            this.copyEdkToolStripMenuItem});
            this.密钥ToolStripMenuItem.Name = "密钥ToolStripMenuItem";
            this.密钥ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.密钥ToolStripMenuItem.Text = "加密机默认密钥";
            // 
            // copyZmkToolStripMenuItem
            // 
            this.copyZmkToolStripMenuItem.Name = "copyZmkToolStripMenuItem";
            this.copyZmkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyZmkToolStripMenuItem.Text = "复制ZMK";
            this.copyZmkToolStripMenuItem.Click += new System.EventHandler(this.copyZmkToolStripMenuItem_Click);
            // 
            // copyZpkToolStripMenuItem
            // 
            this.copyZpkToolStripMenuItem.Name = "copyZpkToolStripMenuItem";
            this.copyZpkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyZpkToolStripMenuItem.Text = "复制ZPK";
            this.copyZpkToolStripMenuItem.Click += new System.EventHandler(this.copyZpkToolStripMenuItem_Click);
            // 
            // copyTmkToolStripMenuItem
            // 
            this.copyTmkToolStripMenuItem.Name = "copyTmkToolStripMenuItem";
            this.copyTmkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyTmkToolStripMenuItem.Text = "复制TMK";
            this.copyTmkToolStripMenuItem.Click += new System.EventHandler(this.copyTmkToolStripMenuItem_Click);
            // 
            // copyTakToolStripMenuItem
            // 
            this.copyTakToolStripMenuItem.Name = "copyTakToolStripMenuItem";
            this.copyTakToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyTakToolStripMenuItem.Text = "复制TAK";
            this.copyTakToolStripMenuItem.Click += new System.EventHandler(this.copyTakToolStripMenuItem_Click);
            // 
            // copyZakToolStripMenuItem
            // 
            this.copyZakToolStripMenuItem.Name = "copyZakToolStripMenuItem";
            this.copyZakToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyZakToolStripMenuItem.Text = "复制ZAK";
            this.copyZakToolStripMenuItem.Click += new System.EventHandler(this.copyZakToolStripMenuItem_Click);
            // 
            // copyZekToolStripMenuItem
            // 
            this.copyZekToolStripMenuItem.Name = "copyZekToolStripMenuItem";
            this.copyZekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyZekToolStripMenuItem.Text = "复制ZEK";
            this.copyZekToolStripMenuItem.Click += new System.EventHandler(this.copyZekToolStripMenuItem_Click);
            // 
            // copyEdkToolStripMenuItem
            // 
            this.copyEdkToolStripMenuItem.Name = "copyEdkToolStripMenuItem";
            this.copyEdkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyEdkToolStripMenuItem.Text = "复制EDK";
            this.copyEdkToolStripMenuItem.Click += new System.EventHandler(this.copyEdkToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "POSP工具箱";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tbPgEncrypt.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpBoxPinEncrypt.ResumeLayout(false);
            this.gpBoxPinEncrypt.PerformLayout();
            this.gpBoxXor.ResumeLayout(false);
            this.gpBoxXor.PerformLayout();
            this.gpBoxMac.ResumeLayout(false);
            this.gpBoxMac.PerformLayout();
            this.gpBoxDesEncrypt.ResumeLayout(false);
            this.gpBoxDesEncrypt.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox gpBoxXor;
        private System.Windows.Forms.TextBox tboxXorReqData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxXorResult;
        private System.Windows.Forms.Label lbXorReqDataLength;
        private System.Windows.Forms.GroupBox gpBoxPinEncrypt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbPinKeyLength;
        private System.Windows.Forms.TextBox tboxPinKey;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbPinPasswordLength;
        private System.Windows.Forms.Label lbPinCardNoLength;
        private System.Windows.Forms.TextBox tboxPinPassword;
        private System.Windows.Forms.TextBox tboxPinCardNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tboxPinResult;
        private System.Windows.Forms.Button btnPinEncrypt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbPinMasterKeyLength;
        private System.Windows.Forms.TextBox tboxPinMasterKey;
        private System.Windows.Forms.Button btnPinDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbtnEncSha1;
        private System.Windows.Forms.RadioButton rbtnEncMd5;
        private System.Windows.Forms.TextBox tboxEncResult;
        private System.Windows.Forms.TextBox tboxEncReqData;
        private System.Windows.Forms.Button btnEncEncrypt;
        private System.Windows.Forms.ToolTip toolTipMacEncrypt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 密钥ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyZmkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyZpkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTmkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyZakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyZekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyEdkToolStripMenuItem;
    }
}

