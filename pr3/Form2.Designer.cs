namespace pr3
{
    partial class LoginForm
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
            this.loginTitle = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInputLabel = new System.Windows.Forms.Label();
            this.passwordInputLabel = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginTitle.Location = new System.Drawing.Point(137, 42);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(429, 48);
            this.loginTitle.TabIndex = 0;
            this.loginTitle.Text = "학사관리 프로그램";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.usernameInput.Location = new System.Drawing.Point(286, 147);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(189, 29);
            this.usernameInput.TabIndex = 1;
            this.usernameInput.Enter += new System.EventHandler(this.usernameInput_Enter);
            this.usernameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameInput_KeyDown);
            this.usernameInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usernameInput_KeyUp);
            this.usernameInput.Leave += new System.EventHandler(this.usernameInput_Leave);
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordInput.Location = new System.Drawing.Point(286, 201);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(189, 29);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.Enter += new System.EventHandler(this.passwordInput_Enter);
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyDown);
            this.passwordInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyUp);
            this.passwordInput.Leave += new System.EventHandler(this.passwordInput_Leave);
            // 
            // usernameInputLabel
            // 
            this.usernameInputLabel.AutoSize = true;
            this.usernameInputLabel.Font = new System.Drawing.Font("굴림", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.usernameInputLabel.Location = new System.Drawing.Point(199, 147);
            this.usernameInputLabel.Name = "usernameInputLabel";
            this.usernameInputLabel.Size = new System.Drawing.Size(70, 33);
            this.usernameInputLabel.TabIndex = 3;
            this.usernameInputLabel.Text = "ID :";
            // 
            // passwordInputLabel
            // 
            this.passwordInputLabel.AutoSize = true;
            this.passwordInputLabel.Font = new System.Drawing.Font("굴림", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordInputLabel.Location = new System.Drawing.Point(181, 197);
            this.passwordInputLabel.Name = "passwordInputLabel";
            this.passwordInputLabel.Size = new System.Drawing.Size(88, 33);
            this.passwordInputLabel.TabIndex = 4;
            this.passwordInputLabel.Text = "PW :";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login.Location = new System.Drawing.Point(261, 265);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(152, 42);
            this.login.TabIndex = 3;
            this.login.Text = "로그인";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pr3.Properties.Resources.loginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 335);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordInputLabel);
            this.Controls.Add(this.usernameInputLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.loginTitle);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "머씻는 학사관리 프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label usernameInputLabel;
        private System.Windows.Forms.Label passwordInputLabel;
        private System.Windows.Forms.Button login;
    }
}