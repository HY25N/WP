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
            lec.Name = "즐거운 게임 만들기";
            lec.Code = 12344;
            lec.Manager = "박교수";
            lec.Capacity = 30;
            lec.Place = "운동장";
            lec.Credit = 3;

            context.Lectures.Add(lec);
            context.SaveChanges();

            List<Lecture> lectures = context.Lectures.ToList();
            Debug.WriteLine(lectures[0].Name);
        }
    }
}
