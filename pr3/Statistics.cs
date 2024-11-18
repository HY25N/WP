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
using System.Windows.Forms.DataVisualization.Charting;

namespace pr3
{
    public partial class Statistics : UserControl
    {
        public ApplicationDbContext Context;

        public Statistics(ApplicationDbContext context)
        {
            InitializeComponent();
            Context = context;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            Chart chart = chart1;
            chart.DataSource = null;


            ChartArea chartArea = new ChartArea("GradeChartArea");
            chart.ChartAreas.Add(chartArea);
            
            var series = new Series("GradeStats")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "GradeChartArea"
            };
            
            List<GradeStats> stats = LoadStudentStatistics();
            foreach (var stat in stats) series.Points.AddXY(stat.Grade.ToString(), stat.Count);
            chart.Series.Add(series);





            ChartArea chartArea2 = new ChartArea("DepartmentChartArea");
            chart.ChartAreas.Add(chartArea2);

            var series2 = new Series("DepartmentStats")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "DepartmentChartArea"
            };

            List<DepartmentStats> stats2 = LoadDepartmentStatsStatistics();
            foreach (var stat in stats2) series2.Points.AddXY(stat.Department , stat.Count);
            chart.Series.Add(series2);
        }

        private void Statistics_Paint(object sender, PaintEventArgs e)
        {
            // Graphics g = e.Graphics;
        }

        private List<GradeStats> LoadStudentStatistics()
        {
            // 학생 데이터 가져오기
            List<Student>  students = Context.Students.ToList();

            // 학년별 학생 수 통계 계산
            var gradeStats = students
                .GroupBy(s => s.Grade)
                .Select(g => new GradeStats { Grade = g.Key, Count = g.Count() })
                .OrderBy(g => g.Grade)
                .ToList();

            return gradeStats;
        }

        private List<DepartmentStats> LoadDepartmentStatsStatistics()
        {
            // 학생 데이터 가져오기
            List<Student>  students = Context.Students.ToList();

            // 학년별 학생 수 통계 계산
            // 학과별 학생 수 통계 계산
            var departmentStats = students
                .GroupBy(s => s.Department)
                .Select(g => new DepartmentStats { Department = g.Key, Count = g.Count() })
                .ToList();

            return departmentStats;
        }
    }



    public class GradeStats
    {
        public int Grade { get; set; }
        public int Count { get; set; }
    }

    public class DepartmentStats
    {
        public String Department { get; set; }
        public int Count { get; set; }
    }
}
