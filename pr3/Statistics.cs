using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
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
        // public ApplicationDbContext Context;

        public Statistics(ApplicationDbContext context)
        {
            InitializeComponent();
            // Context = context;
        }


        // chartArea 는 하나의 차트를 의미
        // 시리즈는 통계를 내는 하나의 덩어리를 의미
        private void Statistics_Load(object sender, EventArgs e)
        {

            // GetRegistrationsByStudentid(20240004);

            //
            // ChartArea chartArea2 = new ChartArea("DepartmentChartArea");
            // chart.ChartAreas.Add(chartArea2);
            //
            // var series2 = new Series("DepartmentStats")
            // {
            //     ChartType = SeriesChartType.Pie,
            //     ChartArea = "DepartmentChartArea"
            // };
            //
            // List<DepartmentStats> stats2 = LoadDepartmentStatsStatistics();
            // foreach (var stat in stats2) series2.Points.AddXY(stat.Department , stat.Count);
            // chart.Series.Add(series2);
        }

        private List<GradeStats> LoadStudentStatistics()
        {
            // 학생 데이터 가져오기
            List<Student>  students = Repository.GetContext().Students.ToList();

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
            List<Student>  students = Repository.GetContext().Students.ToList();

            // 학년별 학생 수 통계 계산
            // 학과별 학생 수 통계 계산
            var departmentStats = students
                .GroupBy(s => s.Department)
                .Select(g => new DepartmentStats { Department = g.Key, Count = g.Count() })
                .ToList();

            return departmentStats;
        }

        public void GetRegistrationsByStudentid(int studentId)
        {
            this.Controls.Remove(chart1);
            chart1 = new Chart();
            this.Controls.Add(chart1);
            chart1.Dock = DockStyle.Fill;

            // 데이터 가져오기
            Student s = Repository.GetContext().Students.FirstOrDefault(v => v.StudentID == studentId);
            List<Enrollment> enrollments = Repository.GetContext().Enrollments.Where(v => v.StudentId == studentId).ToList();

            List<Registration> registrations = new List<Registration>();

            foreach (var e in enrollments)
            {
                // registrations.AddRange(Context.Registrations.Where(v => v.EnrollmentId == e.Id).Include(r => r.Lecture));
                registrations.AddRange(Repository.GetContext().Registrations.Where(v => v.EnrollmentId == e.Id).Include(r => r.Lecture).ToList());
            }


            // ChartArea 생성
            ChartArea chartArea = new ChartArea("studentScoreChartArea");
            chartArea.AxisY.Title = "평균점수(취득점수 X 학점)";

            chart1.ChartAreas.Add(chartArea);

            // 중간고사 시리즈 생성
            Series midtermSeries = new Series("MidTermScores")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "studentScoreChartArea"
            };

            // 기말고사 시리즈 생성
            Series finaltermSeries = new Series("FinalTermScores")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "studentScoreChartArea"
            };


            // 성적 데이터 그룹화 및 평균 계산
            var groupedData = registrations
                .GroupBy(reg => $"{reg.Enrollment.Year}년 {reg.Enrollment.Semester}학기") // 레이블로 그룹화
                .Select(group => new
                {
                    XLabel = group.Key,                                // 그룹의 레이블
                    MidTermAvg = group.Average(reg => reg.MidTerm * reg.Lecture.Credit),    // 중간고사 평균
                    FinalTermAvg = group.Average(reg => reg.FinalTerm * reg.Lecture.Credit) // 기말고사 평균
                })
                .OrderBy(data => data.XLabel) // 레이블 기준으로 정렬
                .ToList();

            // 성적 데이터 추가
            foreach (var data in groupedData)
            {
                // 하나의 레이블을 가지는 값을 만든다. 이 값으로 특정 값에 누적한다.
                midtermSeries.Points.AddXY(data.XLabel, data.MidTermAvg);
                finaltermSeries.Points.AddXY(data.XLabel, data.FinalTermAvg);
            }

            // 시리즈 추가
            chart1.Series.Add(midtermSeries);
            chart1.Series.Add(finaltermSeries);
            chart1.Legends.Add(new Legend("midAndFinalLegend"));
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
