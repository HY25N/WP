using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace pr1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
    }


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            Repository repo = new Repository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }
}
