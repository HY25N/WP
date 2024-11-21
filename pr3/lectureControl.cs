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

namespace pr3
{
    public partial class lectureControl : UserControl
    {
        public ApplicationDbContext context;

        public lectureControl(ApplicationDbContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void lectureControl_Load(object sender, EventArgs e)
        {
            Lecture lec = new Lecture();
            // lec.Name = "즐거운 게임 만들기";
            // lec.Code = 12344;
            // lec.Manager = "박교수";
            // lec.Capacity = 30;
            // lec.Place = "운동장";
            // lec.Credit = 3;

            // context.Lectures.Add(lec);
            // context.SaveChanges();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Code", typeof(int));
            dataTable.Columns.Add("Manager", typeof(string));
            dataTable.Columns.Add("Capacity", typeof(int));
            dataTable.Columns.Add("Place", typeof(string));
            dataTable.Columns.Add("Credit", typeof(int));


            List<Lecture> lectures = context.Lectures.ToList();

            lectureGridView.DataSource = lectures;

            foreach (var lecture in lectures)
            {

                // if (filterFunc != null && !filterFunc(student)) continue;

                dataTable.Rows.Add(
                    lecture.Id,
                    lecture.Name,
                    lecture.Code,
                    lecture.Manager,
                    lecture.Capacity,
                    lecture.Place,
                    lecture.Credit
                );
            }

            lectureGridView.DataSource = dataTable;
        }
    }
}
