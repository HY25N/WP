using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity; // EF6 네임스페이스
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using 강의;


namespace pr3
{

    public partial class Form1 : Form
    {
        public ApplicationDbContext context;
        private StudentControl studentListViewControl;


        public Form1()
        {
            // LoginForm logInForm = new LoginForm();
            // logInForm.ShowDialog();
            //
            // if (!logInForm.isAuthenticated)
            // {
            //     // 로그인 실패 시 애플리케이션 종료
            //     Application.Exit();
            //     return;
            // }

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Repository repo = new Repository("db");
            context = repo.context;


            studentListViewControl = new StudentControl(context);

            UpdateStudentGridView();

            repo.CreateStudentsDummy();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            UpdateStudentGridView();
        }


        private void UpdateStudentGridView()
        {
            // 유저컨트롤의 경우, 디자이너 화면에는 dock 속성이 보이질 않아 코드로 작성함. 
            studentListViewControl.Dock = DockStyle.Fill;

            var students = context.Students.ToList();

            studentListViewControl.CreateView(students, null);

            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(studentListViewControl);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Debug.WriteLine("최상위 부모 창: " + this.Width);
            Debug.WriteLine("최상위 부모 창의 뷰 패널: " + viewPanel.Width);
        }

        private void lectureButton_Click(object sender, EventArgs e)
        {
            lectureControl lc = new lectureControl();
            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(lc);
        }

        private void rToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scorebutton_Click(object sender, EventArgs e)
        {
            score lc = new score();
            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(lc);
        }

        private void 파일저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 파일 탐색기(내 컴퓨터)를 여는 명령어 실행
                Process.Start("explorer.exe", "shell:::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
            }
            catch (Exception ex)
            {
                // 예외 발생 시 메시지 박스를 띄운다.
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void 파일저장하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            // SaveFileDialog 생성
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // 초기 파일 이름 설정 (선택사항)
            saveFileDialog.FileName = "새로운 파일.txt";

            // 필터 설정 (선택사항)
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";

            // 대화상자를 표시하고, 사용자가 '저장'을 클릭하면
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 사용자가 지정한 경로에 파일 저장
                    string filePath = saveFileDialog.FileName;

                    // 파일에 내용을 저장 (예시로 "Hello, World!"라는 텍스트를 저장)
                    File.WriteAllText(filePath, "Hello, World!");

                    MessageBox.Show($"파일이 저장되었습니다: {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"파일 저장 중 오류가 발생했습니다: {ex.Message}");
                }
            }
        }
    }
}
