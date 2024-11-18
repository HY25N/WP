using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity; // EF6 네임스페이스
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


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

            if (context.Students.ToList().Count == 0) repo.CreateStudentsDummy();
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

        private void lectureView()
        {
            lectureControl lectureViewControl = new lectureControl(context);

            lectureViewControl.Dock = DockStyle.Fill;

            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(lectureViewControl);
        }

        private void satisticsLabel_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics(context);

            s.Dock = DockStyle.Fill;

            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(s);
        }

        private void scorebutton_Click(object sender, EventArgs e)
        {
            score lc = new score();
            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(lc);
        }

        private void lectureButton_Click(object sender, EventArgs e)
        {
            lectureView();
        }
    }
}
