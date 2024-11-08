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
        public StudentControl()
        {
            InitializeComponent();
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void UpdateView(List<Student> students)
        {

            studentDataGridView.DataSource = students;


            // todo 디버깅용
            foreach (var student in students)
            {
                Debug.WriteLine($"ID: {student.StudentID}, Name: {student.Name}, Age: {student.DateOfBirth}, Major: {student.Department}");
            }
        }
    }
}
