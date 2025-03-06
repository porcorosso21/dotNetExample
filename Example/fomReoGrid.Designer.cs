namespace dotNetExample.Example
{
    partial class fomReoGrid
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
            this.ucReoGrid1 = new dotNetExample.UserControls.ucReoGrid();
            this.SuspendLayout();
            // 
            // ucReoGrid1
            // 
            this.ucReoGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReoGrid1.Location = new System.Drawing.Point(0, 0);
            this.ucReoGrid1.Name = "ucReoGrid1";
            this.ucReoGrid1.Size = new System.Drawing.Size(777, 492);
            this.ucReoGrid1.TabIndex = 0;
            // 
            // fomReoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 492);
            this.Controls.Add(this.ucReoGrid1);
            this.Name = "fomReoGrid";
            this.Text = "ReoGrid";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucReoGrid ucReoGrid1;
    }
}