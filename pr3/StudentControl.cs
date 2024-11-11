using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // StudentID = int.Parse(studentIDBox.Text),
            student.Name = nameBox.Text;
            student.Department = departmentBox.Text;
            student.Address = addressBox.Text;
            student.DateOfBirth = birthdayDateTimePicker.Value;
            student.Email = emailBox.Text;
            student.PhoneNumber = phoneNumberBox.Text;
            student.Grade = int.Parse(grade1Box.Text) + int.Parse(grade2Box.Text);

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
            grade1Box.Text = (((int)studentDataGridView.Rows[e.RowIndex].Cells["gradeColum"].Value + 1) / 2).ToString() ?? "";
            grade2Box.Text = ((int)studentDataGridView.Rows[e.RowIndex].Cells["gradeColum"].Value % 3).ToString() ?? "";
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
                    Context.Students.Remove(removeTarget);
                    dataTable.Rows[rowIndex].Delete();

                    dataTable.AcceptChanges();
                    Context.SaveChanges();
                }
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

            Context.Students.Add(student);
            Context.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter1 = filterValue.Text;

            switch (filterColum.Text)
            {
                case "이름": UpdateView(row => row["Name"].ToString().Contains(filter1)); break;
                case "이메일": UpdateView(row => row["Email"].ToString().Contains(filter1)); break;
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
                Grade = int.Parse(grade1Box.Text) + int.Parse(grade2Box.Text)
            };

            return student;
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            filterColum.SelectedIndex = 0;
            // this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            CreateView(Context.Students.ToList(), null);
        }
    }
}
