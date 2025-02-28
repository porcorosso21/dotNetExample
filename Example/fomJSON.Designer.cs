namespace dotNetExample.Example
{
    partial class fomJSON
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbJson1 = new System.Windows.Forms.TextBox();
            this.btnDeserialize1 = new System.Windows.Forms.Button();
            this.btnSerialize1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbJson2 = new System.Windows.Forms.TextBox();
            this.btnDeserialize2 = new System.Windows.Forms.Button();
            this.btnSerialize2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbJson3 = new System.Windows.Forms.TextBox();
            this.btnDeserialize3 = new System.Windows.Forms.Button();
            this.btnSerialize3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbJson1);
            this.groupBox1.Controls.Add(this.btnDeserialize1);
            this.groupBox1.Controls.Add(this.btnSerialize1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System.Web.Script.Serialization";
            // 
            // tbJson1
            // 
            this.tbJson1.Location = new System.Drawing.Point(7, 51);
            this.tbJson1.Multiline = true;
            this.tbJson1.Name = "tbJson1";
            this.tbJson1.Size = new System.Drawing.Size(498, 51);
            this.tbJson1.TabIndex = 1;
            // 
            // btnDeserialize1
            // 
            this.btnDeserialize1.Location = new System.Drawing.Point(430, 22);
            this.btnDeserialize1.Name = "btnDeserialize1";
            this.btnDeserialize1.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize1.TabIndex = 0;
            this.btnDeserialize1.Text = "Deserialize";
            this.btnDeserialize1.UseVisualStyleBackColor = true;
            this.btnDeserialize1.Click += new System.EventHandler(this.btnDeserialize1_Click);
            // 
            // btnSerialize1
            // 
            this.btnSerialize1.Location = new System.Drawing.Point(6, 21);
            this.btnSerialize1.Name = "btnSerialize1";
            this.btnSerialize1.Size = new System.Drawing.Size(75, 23);
            this.btnSerialize1.TabIndex = 0;
            this.btnSerialize1.Text = "Serialize";
            this.btnSerialize1.UseVisualStyleBackColor = true;
            this.btnSerialize1.Click += new System.EventHandler(this.btnSerialize1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbJson2);
            this.groupBox2.Controls.Add(this.btnDeserialize2);
            this.groupBox2.Controls.Add(this.btnSerialize2);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System.Runtime.Serialization.Json";
            // 
            // tbJson2
            // 
            this.tbJson2.Location = new System.Drawing.Point(7, 51);
            this.tbJson2.Multiline = true;
            this.tbJson2.Name = "tbJson2";
            this.tbJson2.Size = new System.Drawing.Size(498, 51);
            this.tbJson2.TabIndex = 1;
            // 
            // btnDeserialize2
            // 
            this.btnDeserialize2.Location = new System.Drawing.Point(430, 22);
            this.btnDeserialize2.Name = "btnDeserialize2";
            this.btnDeserialize2.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize2.TabIndex = 0;
            this.btnDeserialize2.Text = "Deserialize";
            this.btnDeserialize2.UseVisualStyleBackColor = true;
            this.btnDeserialize2.Click += new System.EventHandler(this.btnDeserialize2_Click);
            // 
            // btnSerialize2
            // 
            this.btnSerialize2.Location = new System.Drawing.Point(6, 21);
            this.btnSerialize2.Name = "btnSerialize2";
            this.btnSerialize2.Size = new System.Drawing.Size(75, 23);
            this.btnSerialize2.TabIndex = 0;
            this.btnSerialize2.Text = "Serialize";
            this.btnSerialize2.UseVisualStyleBackColor = true;
            this.btnSerialize2.Click += new System.EventHandler(this.btnSerialize2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbJson3);
            this.groupBox3.Controls.Add(this.btnDeserialize3);
            this.groupBox3.Controls.Add(this.btnSerialize3);
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Newtonsoft.Json";
            // 
            // tbJson3
            // 
            this.tbJson3.Location = new System.Drawing.Point(7, 51);
            this.tbJson3.Multiline = true;
            this.tbJson3.Name = "tbJson3";
            this.tbJson3.Size = new System.Drawing.Size(498, 51);
            this.tbJson3.TabIndex = 1;
            // 
            // btnDeserialize3
            // 
            this.btnDeserialize3.Location = new System.Drawing.Point(430, 22);
            this.btnDeserialize3.Name = "btnDeserialize3";
            this.btnDeserialize3.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize3.TabIndex = 0;
            this.btnDeserialize3.Text = "Deserialize";
            this.btnDeserialize3.UseVisualStyleBackColor = true;
            this.btnDeserialize3.Click += new System.EventHandler(this.btnDeserialize3_Click);
            // 
            // btnSerialize3
            // 
            this.btnSerialize3.Location = new System.Drawing.Point(6, 21);
            this.btnSerialize3.Name = "btnSerialize3";
            this.btnSerialize3.Size = new System.Drawing.Size(75, 23);
            this.btnSerialize3.TabIndex = 0;
            this.btnSerialize3.Text = "Serialize";
            this.btnSerialize3.UseVisualStyleBackColor = true;
            this.btnSerialize3.Click += new System.EventHandler(this.btnSerialize3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(522, 120);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "System.Text.Json";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = ".NET Standard 2.0 及更新版本\r\n.NET framework 4.6.2 及更新版本\r\n.NET Core 2.0、2.1 與 2.2";
            // 
            // fomJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 525);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fomJSON";
            this.Text = "JSON";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbJson1;
        private System.Windows.Forms.Button btnSerialize1;
        private System.Windows.Forms.Button btnDeserialize1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbJson2;
        private System.Windows.Forms.Button btnDeserialize2;
        private System.Windows.Forms.Button btnSerialize2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbJson3;
        private System.Windows.Forms.Button btnDeserialize3;
        private System.Windows.Forms.Button btnSerialize3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
    }
}