using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pr3.Properties;

namespace pr3
{
    public partial class LoginForm : Form
    {
        public Boolean isAuthenticated = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            usernameInput.Text = Properties.Settings.Default.usernameInputPlaceholder;
            passwordInput.Text = Properties.Settings.Default.passwordInputPlaceholder;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isAuthenticated) Application.Exit();
        }


        private Boolean authentication()
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (username.Equals(Properties.Settings.Default.loginUsername) &&
                password.Equals(Properties.Settings.Default.loginPassword))
            {
                isAuthenticated = true;
                return true;
            }


            // 메시지박스의 엔터 입력이 부모 폼으로 전파되서 무한 반복되는 문제를 해결
            this.ActiveControl = null;
            MessageBox.Show("입력한 정보가 올바르지 않습니다.","로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            isAuthenticated = false;
            return false;
        }

        private void usernameInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, false, false, false);
            }
        }

        private void passwordInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (authentication()) this.Close();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (authentication()) this.Close();
        }

        private void passwordInput_Leave(object sender, EventArgs e)
        {
            if (passwordInput.Text.Equals(Properties.Settings.Default.passwordInputPlaceholder) ||
                passwordInput.Text.Equals(""))
            {
                passwordInput.Text = Properties.Settings.Default.passwordInputPlaceholder;
                passwordInput.PasswordChar = '\0';
            }
        }

        private void passwordInput_Enter(object sender, EventArgs e)
        {
            if (passwordInput.Text.Equals(Properties.Settings.Default.passwordInputPlaceholder))
            {
                passwordInput.Text = "";
                passwordInput.PasswordChar = '*';
            }
        }

        private void usernameInput_Enter(object sender, EventArgs e)
        {
            if (usernameInput.Text.Equals(Properties.Settings.Default.usernameInputPlaceholder))
            {
                usernameInput.Text = "";
            }
        }

        private void usernameInput_Leave(object sender, EventArgs e)
        {
            if (usernameInput.Text.Equals(Properties.Settings.Default.usernameInputPlaceholder) ||
                usernameInput.Text.Equals(""))
            {
                usernameInput.Text = Properties.Settings.Default.usernameInputPlaceholder;
            }
        }

        private void usernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void passwordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void loginTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
