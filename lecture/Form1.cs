using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 강의
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lecturelabel_Click(object sender, EventArgs e)
        {
            lectureView();
        }
        private void lectureView()
        {
            lectureControl lectureViewControl = new lectureControl();

            lectureViewControl.Dock = DockStyle.Fill;

            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(lectureViewControl);
        }
    }
}