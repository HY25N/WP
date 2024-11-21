namespace pr3
{
    partial class PasswordChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NowPassword = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.NewPasswordCheck = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "새로운 비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "새로운 비밀번호 확인";
            // 
            // NowPassword
            // 
            this.NowPassword.Location = new System.Drawing.Point(285, 51);
            this.NowPassword.Name = "NowPassword";
            this.NowPassword.Size = new System.Drawing.Size(304, 32);
            this.NowPassword.TabIndex = 3;
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(285, 130);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '*';
            this.NewPassword.Size = new System.Drawing.Size(304, 32);
            this.NewPassword.TabIndex = 4;
            // 
            // NewPasswordCheck
            // 
            this.NewPasswordCheck.Location = new System.Drawing.Point(285, 211);
            this.NewPasswordCheck.Name = "NewPasswordCheck";
            this.NewPasswordCheck.PasswordChar = '*';
            this.NewPasswordCheck.Size = new System.Drawing.Size(304, 32);
            this.NewPasswordCheck.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "비밀번호 변경";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewPasswordCheck);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NowPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PasswordChange";
            this.Text = "비밀번호 변경";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NowPassword;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox NewPasswordCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}