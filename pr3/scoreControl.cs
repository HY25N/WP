using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3
{
    public partial class ScoreControl : UserControl
    {
        public ScoreControl()
        {
            InitializeComponent();
        }
        public ScoreControl(int studentId)
        {
            InitializeComponent();
            Statistics stat = new Statistics(Repository.GetContext());
            stat.GetRegistrationsByStudentid(studentId);
            stat.Dock = DockStyle.Fill;
            panel1.Controls.Add(stat);
        }
    }
}
