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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginTitle = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("바탕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginTitle.Location = new System.Drawing.Point(235, -1);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(651, 84);
            this.loginTitle.TabIndex = 0;
            this.loginTitle.Text = "원광대 학적관리";
            this.loginTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginTitle.Click += new System.EventHandler(this.loginTitle_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.usernameInput.Location = new System.Drawing.Point(390, 175);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(4);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(313, 40);
            this.usernameInput.TabIndex = 1;
            this.usernameInput.Text = "아이디를 입력해주세요";
            this.usernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameInput.Enter += new System.EventHandler(this.usernameInput_Enter);
            this.usernameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameInput_KeyDown);
            this.usernameInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usernameInput_KeyUp);
            this.usernameInput.Leave += new System.EventHandler(this.usernameInput_Leave);
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordInput.Location = new System.Drawing.Point(390, 247);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(313, 40);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.Text = "비밀번호를 입력해주세요";
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordInput.Enter += new System.EventHandler(this.passwordInput_Enter);
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyDown);
            this.passwordInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyUp);
            this.passwordInput.Leave += new System.EventHandler(this.passwordInput_Leave);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.Font = new System.Drawing.Font("굴림", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login.Location = new System.Drawing.Point(390, 309);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(132, 35);
            this.login.TabIndex = 3;
            this.login.Text = "로그인";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(529, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "비밀번호 변경";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.loginTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1097, 641);
            this.MinimumSize = new System.Drawing.Size(1097, 641);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "머씻는 학사관리 프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.LoginForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button1;
    }
}