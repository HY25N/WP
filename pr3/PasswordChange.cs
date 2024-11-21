using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3
{
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 현재 비밀번호 확인
            if (NowPassword.Text == Properties.Settings.Default.loginPassword)
            {
                // 새로운 비밀번호와 확인 입력 비교
                if (NewPassword.Text == NewPasswordCheck.Text)
                {
                    // 비밀번호 변경
                    Properties.Settings.Default.loginPassword = NewPassword.Text;
                    Properties.Settings.Default.Save(); // 변경된 비밀번호를 저장

                    MessageBox.Show("비밀번호가 성공적으로 변경되었습니다.", "변경 완료",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); // 창 닫기
                }
                else
                {
                    MessageBox.Show("새 비밀번호와 확인 비밀번호가 일치하지 않습니다.", "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("현재 비밀번호가 올바르지 않습니다.", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 취소 버튼을 눌렀을 때 폼 닫기
            this.Close();

        }
    }
}
