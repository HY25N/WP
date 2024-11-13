using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Enter += (sender, e) =>
            {
                if (textBox1.Text == "아이디를 입력해주세요")  // 기본 텍스트일 경우
                {
                    textBox1.Clear();  // 텍스트 지우기
                    textBox1.ForeColor = Color.Black;  // 텍스트 색상 변경
                }
            };
            textBox1.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = "아이디를 입력해주세요";  // 기본 텍스트 복원
                    textBox1.ForeColor = Color.Gray;  // 기본 색상 회색으로 복원
                }


            };
            textBox2.Enter += (sender, e) =>
            {
                if (textBox2.Text == "비밀번호를 입력해주세요")  // 기본 텍스트일 경우
                {
                    textBox2.Clear();  // 텍스트 지우기
                    textBox2.ForeColor = Color.Black;  // 텍스트 색상 변경
                }
            };
            textBox2.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    textBox2.Text = "비밀번호를 입력해주세요";  // 기본 텍스트 복원
                    textBox2.ForeColor = Color.Gray;  // 기본 색상 회색으로 복원
                }


            };
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

       
    }
}

