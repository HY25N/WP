﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pr3
{
    public partial class StudentControl : UserControl
    {
        public ApplicationDbContext Context;

        public StudentControl(ApplicationDbContext context)
        {
            InitializeComponent();
            Context = context;
        }

        public void UpdateView(Func<DataRow, Boolean> filterFunc)
        {
            DataTable dataTable = (DataTable) studentDataGridView.DataSource;

            // 데이터 테이블의 행을 역순으로 순회 (삭제 시 인덱스 꼬임 방지)
            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dataTable.Rows[i];
                // 콜백 함수 조건에 맞으면 행 삭제
                if (!filterFunc(row)) dataTable.Rows.Remove(row);
            }
        }


        public void CreateView(List<Student> students, Func<Student, Boolean> filterFunc)
        {

            // BindingSource bindingSource = new BindingSource();
            // bindingSource.DataSource = students;
            // studentDataGridView.DataSource = bindingSource;


            var dataTable = new DataTable();

            dataTable.Columns.Add("StudentID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
            dataTable.Columns.Add("Department", typeof(string));
            dataTable.Columns.Add("Grade", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));

            foreach (var student in students)
            {

                if (filterFunc != null && !filterFunc(student)) continue;

                dataTable.Rows.Add(
                    student.StudentID,
                    student.Name,
                    student.DateOfBirth,
                    student.Department,
                    student.Grade,
                    student.PhoneNumber,
                    student.Email,
                    student.Address
                );
            }

            studentDataGridView.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            modeLabel.Text = "현재 모드:\n수정";

            int StudentID = CreateStudentByUserInterface().StudentID;
            Student student = Context.Students.SingleOrDefault(s => s.StudentID == StudentID);

            StudentID = int.Parse(studentIDBox.Text);
            student.Name = nameBox.Text;
            student.Department = departmentBox.Text;
            student.Address = addressBox.Text;
            student.DateOfBirth = birthdayDateTimePicker.Value;
            student.Email = emailBox.Text;
            student.PhoneNumber = phoneNumberBox.Text;
            student.Grade = int.Parse(grade1Box.Text) + int.Parse(grade2Box.Text);

            Context.Students.AddOrUpdate(student);
            Context.SaveChanges();
        }

        private void studentDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            departmentBox.Text = studentDataGridView.Rows[e.RowIndex].Cells["departmentColum"].Value.ToString() ?? "";
            studentIDBox.Text = studentDataGridView.Rows[e.RowIndex].Cells["StudentID"].Value?.ToString() ?? "";
            nameBox.Text = studentDataGridView.Rows[e.RowIndex].Cells["nameColum"].Value?.ToString() ?? "";
            addressBox.Text = studentDataGridView.Rows[e.RowIndex].Cells["addressColum"].Value.ToString() ?? "";
            phoneNumberBox.Text = studentDataGridView.Rows[e.RowIndex].Cells["phoneNumberColumn"].Value.ToString() ?? "";
            emailBox.Text = studentDataGridView.Rows[e.RowIndex].Cells["emailDataGridViewTextBoxColumn"].Value.ToString() ?? "";
            grade1Box.Text = (CalculateGrade((int)studentDataGridView.Rows[e.RowIndex].Cells["gradeColum"].Value).Item1).ToString() ?? "";
            grade2Box.Text = (CalculateGrade((int)studentDataGridView.Rows[e.RowIndex].Cells["gradeColum"].Value).Item2).ToString() ?? "";
            modeLabel.Text = "현재 모드:\n읽기";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            modeLabel.Text = "현재 모드:\n삭제";

            if (studentDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = studentDataGridView.SelectedRows[0];

                // 데이터 소스가 DataTable인지 확인
                if (studentDataGridView.DataSource is DataTable dataTable)
                {
                    // 선택된 행의 인덱스 가져오기
                    int rowIndex = selectedRow.Index;

                    int studentID = Convert.ToInt32(selectedRow.Cells["StudentID"].Value);


                    Student removeTarget = Context.Students.SingleOrDefault(student => student.StudentID == studentID);

                    DialogResult result1 = MessageBox.Show($"{removeTarget.StudentID} {removeTarget.Name}\n정말 삭제하시겠습니까?", "진짜로?", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.No) { MessageBox.Show("취소되었습니다."); return; }

                    Context.Students.Remove(removeTarget);
                    dataTable.Rows[rowIndex].Delete();

                    dataTable.AcceptChanges();
                    Context.SaveChanges();
                }
                MessageBox.Show("삭제되었습니다..");
            }
            else
            {
                MessageBox.Show("삭제할 행을 선택하세요.");
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            modeLabel.Text = "현재 모드:\n등록";
            Student student = CreateStudentByUserInterface();


            try 
            {
                Context.Students.Add(student);
                // Context.Students.Attach(student);
                Context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("이미 등록된 정보입니다.\n등록할 수 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("알 수 없는 오류가 발생했습니다.\n등록할 수 없습니다.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter1 = filterValue.Text;

            switch (filterColum.Text)
            {
                case "학번": UpdateView(row => row["StudentId"].ToString().Contains(filter1)); break;
                case "이름": UpdateView(row => row["Name"].ToString().Contains(filter1)); break;
                case "이메일": UpdateView(row => row["Email"].ToString().Contains(filter1)); break;
                case "주소": UpdateView(row => row["Address"].ToString().Contains(filter1)); break;
                default: UpdateView(row => row["Name"].ToString().Contains(filter1)); break;
            }
        }

        private void StudentControl_Resize(object sender, EventArgs e)
        {
            Debug.WriteLine(this.Width);
            // tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, this.Width - groupBox1.Width);
        }

        private Student CreateStudentByUserInterface()
        {
            Student student = new Student
            {
                StudentID = int.Parse(studentIDBox.Text),
                Name = nameBox.Text,
                Department = departmentBox.Text,
                Address = addressBox.Text,
                DateOfBirth = birthdayDateTimePicker.Value,
                Email = emailBox.Text,
                PhoneNumber = phoneNumberBox.Text,
                Grade = CalculateGrade(int.Parse(grade1Box.Text), int.Parse(grade2Box.Text))
            };

            return student;
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            // this.Dock = DockStyle.Fill;
            filterColum.SelectedIndex = 0;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            CreateView(Context.Students.ToList(), null);
        }



        // 디비에 저장된 단일 정수 값을 n학년 m학기 튜플로 반환
        public (int, int) CalculateGrade(int grade)
        {
            if (grade <= 1) return (grade, grade);

            int grade1 = (grade+1) / 2;
            int grade2 = (grade % 2 == 1) ? 1 : 2;

            return (grade1, grade2);
        }

        // 입력학 n학기 m학년을 디비에 저장하기 위해 단일 정수 값으로 변환
        public int CalculateGrade(int grade1, int grade2)
        {
            if (grade1 == 0) return 0;
            if (grade1 == 1) return grade2;

            return (grade1 - 1) * 2 + grade2;
        }

    }
}