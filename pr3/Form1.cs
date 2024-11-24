﻿using System;
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


        private void 데이터백업ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SaveFileDialog 객체 생성
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"; // 파일 형식 설정
            saveFileDialog.Title = "데이터 백업";

            // 사용자가 파일을 선택했을 경우
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 선택한 파일 경로에 파일 저장
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, "저장할 텍스트 내용"); // 파일에 텍스트 저장
                    MessageBox.Show("데이터가 백업되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // 오류 발생 시 메시지 출력
                    MessageBox.Show($"데이터 백업 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void 파일불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenFileDialog 객체 생성
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"; // 파일 형식 필터
            openFileDialog.Title = "파일 불러오기";

            // 사용자가 파일을 선택했을 경우
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 선택한 파일 경로
                    string filePath = openFileDialog.FileName;

                    // 파일 읽기
                    string fileContent = File.ReadAllText(filePath);

                    // 파일 내용을 텍스트박스나 다른 UI에 표시
                    MessageBox.Show("파일 내용:\n" + fileContent, "파일 내용", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // 오류 처리
                    MessageBox.Show($"파일을 불러오는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }
    }
}
    

        
    
