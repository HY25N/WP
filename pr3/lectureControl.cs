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
            lec.Name = "교과목명";
            lec.Code = 1234;
            lec.Manager = "교수";
            lec.Capacity = 40;
            lec.Place = "강의실";
            lec.Credit = 3;
            lec.Object = "전공 선택";

            context.Lectures.Add(lec);
            context.SaveChanges();

            List<Lecture> lectures = context.Lectures.ToList();
            Debug.WriteLine(lectures[0].Name);
        }
    }
}
