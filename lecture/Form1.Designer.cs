namespace 강의
{
    partial class Form1
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
            this.viewPanel = new System.Windows.Forms.Panel();
            this.lecturelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewPanel
            // 
            this.viewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewPanel.Location = new System.Drawing.Point(56, 8);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1176, 719);
            this.viewPanel.TabIndex = 0;
            // 
            // lecturelabel
            // 
            this.lecturelabel.AutoSize = true;
            this.lecturelabel.Location = new System.Drawing.Point(12, 9);
            this.lecturelabel.Name = "lecturelabel";
            this.lecturelabel.Size = new System.Drawing.Size(43, 12);
            this.lecturelabel.TabIndex = 1;
            this.lecturelabel.Text = "lecture";
            this.lecturelabel.Click += new System.EventHandler(this.lecturelabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 720);
            this.Controls.Add(this.lecturelabel);
            this.Controls.Add(this.viewPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Label lecturelabel;
    }
}