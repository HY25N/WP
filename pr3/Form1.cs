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
            LoginForm logInForm = new LoginForm();
            logInForm.ShowDialog();

            if (!logInForm.isAuthenticated)
            {
                // 로그인 실패 시 애플리케이션 종료
                Application.Exit();
                return;
            }

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

        private void 파일저장하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // SaveFileDialog 설정
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"; // 파일 형식 필터
            saveFileDialog.Title = "파일 저장";

            // 저장 대화상자 열기
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 파일 경로 가져오기
                string filePath = saveFileDialog.FileName;

                // 파일에 저장할 내용 (예시로 텍스트)
                string content = "저장할 내용입니다.";

                // 파일 저장
                try
                {
                    File.WriteAllText(filePath, content);
                    MessageBox.Show("파일이 성공적으로 저장되었습니다.", "저장 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("파일 저장 중 오류가 발생했습니다: " + ex.Message, "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 파일저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenFileDialog 설정
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"; // 파일 형식 필터
            openFileDialog.Title = "파일 열기";

            // 파일 열기 대화상자 열기
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 선택한 파일 경로 가져오기
                string filePath = openFileDialog.FileName;

                // 선택한 파일 내용 읽기
                try
                {
                    string fileContent = File.ReadAllText(filePath);

                    // 파일 내용 화면에 표시 (예시로 MessageBox 사용)
                    MessageBox.Show(fileContent, "파일 내용", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("파일을 읽는 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
        

