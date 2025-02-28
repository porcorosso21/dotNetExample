namespace dotNetExample.Examples
{
    partial class fomTask
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
            this.btnTask = new System.Windows.Forms.Button();
            this.rtbTask2 = new System.Windows.Forms.RichTextBox();
            this.rtbTask1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(12, 12);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(441, 42);
            this.btnTask.TabIndex = 6;
            this.btnTask.Text = "開始";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // rtbTask2
            // 
            this.rtbTask2.Location = new System.Drawing.Point(242, 60);
            this.rtbTask2.Name = "rtbTask2";
            this.rtbTask2.Size = new System.Drawing.Size(211, 359);
            this.rtbTask2.TabIndex = 5;
            this.rtbTask2.Text = "";
            // 
            // rtbTask1
            // 
            this.rtbTask1.Location = new System.Drawing.Point(12, 60);
            this.rtbTask1.Name = "rtbTask1";
            this.rtbTask1.Size = new System.Drawing.Size(211, 359);
            this.rtbTask1.TabIndex = 4;
            this.rtbTask1.Text = "";
            // 
            // fomTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(605, 454);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.rtbTask2);
            this.Controls.Add(this.rtbTask1);
            this.Name = "fomTask";
            this.Text = "Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.RichTextBox rtbTask2;
        private System.Windows.Forms.RichTextBox rtbTask1;
    }
}