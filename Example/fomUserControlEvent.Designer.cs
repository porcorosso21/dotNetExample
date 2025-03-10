namespace dotNetExample.Example
{
    partial class fomUserControlEvent
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
            this.ucUserControlEvent1 = new dotNetExample.UserControls.ucUserControlEvent();
            this.SuspendLayout();
            // 
            // ucUserControlEvent1
            // 
            this.ucUserControlEvent1.Location = new System.Drawing.Point(41, 32);
            this.ucUserControlEvent1.Name = "ucUserControlEvent1";
            this.ucUserControlEvent1.Size = new System.Drawing.Size(128, 131);
            this.ucUserControlEvent1.TabIndex = 0;
            // 
            // fomUserControlEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucUserControlEvent1);
            this.Name = "fomUserControlEvent";
            this.Text = "UserControl 事件綁定";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucUserControlEvent ucUserControlEvent1;
    }
}