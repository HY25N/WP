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

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        public void UpdateView(List<Student> students, Func<Student, Boolean> filterFunc)
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


            // todo 디버깅용
            foreach (var student in students)
            {
                Debug.WriteLine($"ID: {student.StudentID}, Name: {student.Name}, Age: {student.DateOfBirth}, Major: {student.Department}");
            }
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
            studentDataGridView.Columns["gradeColum"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            modeLabel.Text = "현재 모드:\n등록";
            studentDataGridView.Columns["nameColum"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter1 = filterValue.Text;

            switch (filterColum.Text)
            {
                case "이름": UpdateView(Context.Students.ToList(), student => student.Name.Contains(filter1)); break;
                case "이메일": UpdateView(Context.Students.ToList(), student => student.Email.Contains(filter1)); break;
            }
        }
    }
}
