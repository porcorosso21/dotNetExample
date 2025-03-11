namespace dotNetExample.Example
{
    partial class fomRSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRSACreateKey = new System.Windows.Forms.Button();
            this.tbRSAPublicKey = new System.Windows.Forms.TextBox();
            this.tbRSAPrivateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnREAEncrypt = new System.Windows.Forms.Button();
            this.tbRSAEncrypt = new System.Windows.Forms.TextBox();
            this.btnRSADecrypt = new System.Windows.Forms.Button();
            this.tbRSADecrypt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAESCreateKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAESKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAESIV = new System.Windows.Forms.TextBox();
            this.tbAESEncrypt = new System.Windows.Forms.TextBox();
            this.btnAESEncrypt = new System.Windows.Forms.Button();
            this.tbAESDecrypt = new System.Windows.Forms.TextBox();
            this.btnAESDecrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRSACreateKey
            // 
            this.btnRSACreateKey.Location = new System.Drawing.Point(12, 18);
            this.btnRSACreateKey.Name = "btnRSACreateKey";
            this.btnRSACreateKey.Size = new System.Drawing.Size(116, 34);
            this.btnRSACreateKey.TabIndex = 0;
            this.btnRSACreateKey.Text = "產生金鑰";
            this.btnRSACreateKey.UseVisualStyleBackColor = true;
            this.btnRSACreateKey.Click += new System.EventHandler(this.btnRSACreateKey_Click);
            // 
            // tbRSAPublicKey
            // 
            this.tbRSAPublicKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRSAPublicKey.Location = new System.Drawing.Point(83, 58);
            this.tbRSAPublicKey.Name = "tbRSAPublicKey";
            this.tbRSAPublicKey.ReadOnly = true;
            this.tbRSAPublicKey.Size = new System.Drawing.Size(591, 22);
            this.tbRSAPublicKey.TabIndex = 1;
            // 
            // tbRSAPrivateKey
            // 
            this.tbRSAPrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRSAPrivateKey.Location = new System.Drawing.Point(84, 91);
            this.tbRSAPrivateKey.Name = "tbRSAPrivateKey";
            this.tbRSAPrivateKey.ReadOnly = true;
            this.tbRSAPrivateKey.Size = new System.Drawing.Size(590, 22);
            this.tbRSAPrivateKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "PublicKey：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "PrivateKey：";
            // 
            // btnREAEncrypt
            // 
            this.btnREAEncrypt.Location = new System.Drawing.Point(12, 119);
            this.btnREAEncrypt.Name = "btnREAEncrypt";
            this.btnREAEncrypt.Size = new System.Drawing.Size(116, 34);
            this.btnREAEncrypt.TabIndex = 5;
            this.btnREAEncrypt.Text = "加密字串\"Apple\"";
            this.btnREAEncrypt.UseVisualStyleBackColor = true;
            this.btnREAEncrypt.Click += new System.EventHandler(this.btnRSAEncrypt_Click);
            // 
            // tbRSAEncrypt
            // 
            this.tbRSAEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRSAEncrypt.Location = new System.Drawing.Point(12, 159);
            this.tbRSAEncrypt.Name = "tbRSAEncrypt";
            this.tbRSAEncrypt.ReadOnly = true;
            this.tbRSAEncrypt.Size = new System.Drawing.Size(662, 22);
            this.tbRSAEncrypt.TabIndex = 6;
            // 
            // btnRSADecrypt
            // 
            this.btnRSADecrypt.Location = new System.Drawing.Point(12, 187);
            this.btnRSADecrypt.Name = "btnRSADecrypt";
            this.btnRSADecrypt.Size = new System.Drawing.Size(116, 34);
            this.btnRSADecrypt.TabIndex = 7;
            this.btnRSADecrypt.Text = "解密";
            this.btnRSADecrypt.UseVisualStyleBackColor = true;
            this.btnRSADecrypt.Click += new System.EventHandler(this.btnRSADecrypt_Click);
            // 
            // tbRSADecrypt
            // 
            this.tbRSADecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRSADecrypt.Location = new System.Drawing.Point(12, 227);
            this.tbRSADecrypt.Name = "tbRSADecrypt";
            this.tbRSADecrypt.ReadOnly = true;
            this.tbRSADecrypt.Size = new System.Drawing.Size(662, 22);
            this.tbRSADecrypt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRSACreateKey);
            this.groupBox1.Controls.Add(this.tbRSADecrypt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRSADecrypt);
            this.groupBox1.Controls.Add(this.tbRSAPublicKey);
            this.groupBox1.Controls.Add(this.tbRSAEncrypt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnREAEncrypt);
            this.groupBox1.Controls.Add(this.tbRSAPrivateKey);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 268);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA加密";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAESDecrypt);
            this.groupBox2.Controls.Add(this.btnAESDecrypt);
            this.groupBox2.Controls.Add(this.tbAESEncrypt);
            this.groupBox2.Controls.Add(this.btnAESEncrypt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbAESKey);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbAESIV);
            this.groupBox2.Controls.Add(this.btnAESCreateKey);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 279);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES";
            // 
            // btnAESCreateKey
            // 
            this.btnAESCreateKey.Location = new System.Drawing.Point(12, 21);
            this.btnAESCreateKey.Name = "btnAESCreateKey";
            this.btnAESCreateKey.Size = new System.Drawing.Size(116, 43);
            this.btnAESCreateKey.TabIndex = 0;
            this.btnAESCreateKey.Text = "產生金鑰";
            this.btnAESCreateKey.UseVisualStyleBackColor = true;
            this.btnAESCreateKey.Click += new System.EventHandler(this.btnAESCreateKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key：";
            // 
            // tbAESKey
            // 
            this.tbAESKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAESKey.Location = new System.Drawing.Point(54, 70);
            this.tbAESKey.Name = "tbAESKey";
            this.tbAESKey.ReadOnly = true;
            this.tbAESKey.Size = new System.Drawing.Size(620, 22);
            this.tbAESKey.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "IV：";
            // 
            // tbAESIV
            // 
            this.tbAESIV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAESIV.Location = new System.Drawing.Point(54, 99);
            this.tbAESIV.Name = "tbAESIV";
            this.tbAESIV.ReadOnly = true;
            this.tbAESIV.Size = new System.Drawing.Size(620, 22);
            this.tbAESIV.TabIndex = 6;
            // 
            // tbAESEncrypt
            // 
            this.tbAESEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAESEncrypt.Location = new System.Drawing.Point(12, 167);
            this.tbAESEncrypt.Name = "tbAESEncrypt";
            this.tbAESEncrypt.ReadOnly = true;
            this.tbAESEncrypt.Size = new System.Drawing.Size(662, 22);
            this.tbAESEncrypt.TabIndex = 10;
            // 
            // btnAESEncrypt
            // 
            this.btnAESEncrypt.Location = new System.Drawing.Point(12, 127);
            this.btnAESEncrypt.Name = "btnAESEncrypt";
            this.btnAESEncrypt.Size = new System.Drawing.Size(116, 34);
            this.btnAESEncrypt.TabIndex = 9;
            this.btnAESEncrypt.Text = "加密字串\"Banana\"";
            this.btnAESEncrypt.UseVisualStyleBackColor = true;
            this.btnAESEncrypt.Click += new System.EventHandler(this.btnAESEncrypt_Click);
            // 
            // tbAESDecrypt
            // 
            this.tbAESDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAESDecrypt.Location = new System.Drawing.Point(12, 235);
            this.tbAESDecrypt.Name = "tbAESDecrypt";
            this.tbAESDecrypt.ReadOnly = true;
            this.tbAESDecrypt.Size = new System.Drawing.Size(662, 22);
            this.tbAESDecrypt.TabIndex = 12;
            // 
            // btnAESDecrypt
            // 
            this.btnAESDecrypt.Location = new System.Drawing.Point(12, 195);
            this.btnAESDecrypt.Name = "btnAESDecrypt";
            this.btnAESDecrypt.Size = new System.Drawing.Size(116, 34);
            this.btnAESDecrypt.TabIndex = 11;
            this.btnAESDecrypt.Text = "解密";
            this.btnAESDecrypt.UseVisualStyleBackColor = true;
            this.btnAESDecrypt.Click += new System.EventHandler(this.btnAESDecrypt_Click);
            // 
            // fomRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 753);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fomRSA";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "RSA、AES加解密";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRSACreateKey;
        private System.Windows.Forms.TextBox tbRSAPublicKey;
        private System.Windows.Forms.TextBox tbRSAPrivateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnREAEncrypt;
        private System.Windows.Forms.TextBox tbRSAEncrypt;
        private System.Windows.Forms.Button btnRSADecrypt;
        private System.Windows.Forms.TextBox tbRSADecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAESCreateKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAESKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAESIV;
        private System.Windows.Forms.TextBox tbAESEncrypt;
        private System.Windows.Forms.Button btnAESEncrypt;
        private System.Windows.Forms.TextBox tbAESDecrypt;
        private System.Windows.Forms.Button btnAESDecrypt;
    }
}