using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3
{
    public partial class ScoreControl : UserControl
    {
        // 성적 데이터를 저장할 리스트
        private List<Registration> scores = new List<Registration>();
        private Student student;

        public ScoreControl()
        {
            InitializeComponent();
        }

        public ScoreControl(int studentId)
        {
            InitializeComponent();
            this.student = Repository.GetContext().Students.SingleOrDefault(v => v.StudentID == studentId);
            if (this.student==null) return;


            // 과목선택 콤보박스의 값들을 db에서 불러온다.
            lectureComboBox.DataSource = Repository.GetContext().Lectures.ToList();
            lectureComboBox.DisplayMember = "Name"; // 사용자에게 표시할 항목
            lectureComboBox.ValueMember = "Id";

            txtStudentId.Text = student.StudentID.ToString();
            txtStudentName.Text = student.Name.ToString();

            ViewEnrollmentInfo(0);

            Statistics stat = new Statistics(Repository.GetContext());
            stat.GetRegistrationsByStudentid(student.StudentID);
            stat.Dock = DockStyle.Fill;
            panel1.Controls.Add(stat);
        }

        private void ViewEnrollmentInfo(int rowIndex)
        {
            EnrollmentDataGridView.DataSource =
                Repository.GetContext().Enrollments.Where(v => v.StudentId == student.StudentID).ToList();

            if (((List<Enrollment>)EnrollmentDataGridView.DataSource).Count ==0) return;

            txtYear.Text = EnrollmentDataGridView.Rows[rowIndex].Cells["yearDataGridViewTextBoxColumn"].Value.ToString();
            txtsemester.Text = EnrollmentDataGridView.Rows[rowIndex].Cells["semesterDataGridViewTextBoxColumn"].Value.ToString();

            int enroId = int.Parse(EnrollmentDataGridView.Rows[rowIndex].Cells["EnrollmentId"].Value.ToString());

            dgvScores.DataSource = Repository.GetContext()
                .Registrations
                .Where(v => v.EnrollmentId == enroId)
                .Include(r => r.Lecture)
                .Select(v => new
                {
                    Id = v.Lecture.Id,                // 기존 필드
                    v.MidTerm,           // 기존 필드
                    v.FinalTerm,         // 기존 필드
                    v.Attendance,
                    // TotalScore = (v.MidTerm ?? 0) + (v.FinalTerm ?? 0), // 새로운 필드
                    LectureName = v.Lecture.Name // 관계 데이터 추가
                })
                .ToList();
        }


        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                // 텍스트 박스 컨트롤에서 값들을 읽어온다.
                int studentId = int.Parse(txtStudentId.Text);
                string studentName = txtStudentName.Text;
                int year = int.Parse(txtYear.Text);
                int semester = int.Parse(txtsemester.Text);
                int lectureId = (int)lectureComboBox.SelectedValue;
                int midTerm = int.Parse(txtMidTerm.Text);
                int finalTerm = int.Parse(txtFinalTerm.Text);
                int attendance = int.Parse(txtAttendance.Text);

                // 위의 학생정보와 년도학기 정보를 기준으로 db의 등록학기 정보를 가져온다. 없으면 새로 만든다.
                Enrollment enroll = Repository.GetContext().Enrollments.SingleOrDefault(v =>
                                        v.StudentId == studentId && v.Year == year && v.Semester == semester) ??
                                    new Enrollment(studentId, year, semester);

                // 없어서 새로 만든 경우 새 학기의 점수를 등록할 것이니, 새로 만든 등록학기 정보를 컨텍스트에서 추적하게 한다.
                Repository.GetContext().Enrollments.AddOrUpdate(enroll);

                // 박스 컨드롤들을 기준으로 점수(registration) 를 만든다.
                Registration newScore = new Registration(enroll.Id, lectureId, midTerm, finalTerm, attendance);
                // 표 컨트롤에도 추가한다.
                scores.Add(newScore);

                // 리스트 박스에 추가
                // lstScores.Items.Add($"{newScore.Lecture.Name} ::: 중간:{newScore.MidTerm} | 기말:{newScore.FinalTerm}");

                // 영속성 컨텍스트에 점수 정보를 담는다.
                Repository.GetContext().Registrations.Add(newScore);
                // 변경된 db 사항을 영속화 한다.
                Repository.GetContext().SaveChanges();

                // DataGridView에 성적 데이터 갱신
                dgvScores.DataSource = scores.ToList();
                ClearFields();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("성적을 올바르게 입력해주세요." + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("문제가 발생했습니다." + ex.StackTrace);
            }
        }

        // 성적 수정 버튼 클릭 이벤트
        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            // if (lstScores.SelectedItem != null)
            // {
            //     // 선택된 성적 항목 수정
            //     Registration selectedScore = scores[lstScores.SelectedIndex];
            //     // subject는 과목명 아닌가요? 과목명은 과목페이지에서만 바꿉니다.?
            //     // selectedScore.Subject = txtSubject.Text;
            //     selectedScore.MidTerm = int.Parse(txtMidTerm.Text);
            //     selectedScore.FinalTerm = int.Parse(txtFinalTerm.Text);
            //
            //     // DataGridView 갱신
            //     dgvScores.DataSource = null;
            //     dgvScores.DataSource = scores.ToList();
            //     lstScores.Items[lstScores.SelectedIndex] = selectedScore.ToString();
            // }
        }
        // 성적 삭제 버튼 클릭 이벤트
        private void btnDeleteScore_Click(object sender, EventArgs e)
        {
            // if (lstScores.SelectedItem != null)
            // {
            //     // 선택된 항목 삭제
            //     scores.RemoveAt(lstScores.SelectedIndex);
            //     lstScores.Items.RemoveAt(lstScores.SelectedIndex);
            //
            //     // DataGridView 갱신
            //     dgvScores.DataSource = null;
            //     dgvScores.DataSource = scores.ToList();
            // }
        }
        // 평균 계산 버튼 클릭 이벤트
        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            if (scores.Count > 0)
            {
                double average = scores.Average(s => ((s.MidTerm ?? 0) + (s.FinalTerm ?? 0))/2);
                // txtAverage.Text = average.ToString("F2");
            }
            else
            {
                MessageBox.Show("성적 데이터가 없습니다.");
            }
        }
        // 입력 필드 초기화
        private void ClearFields()
        {
            // txtStudentId.Clear();
            // txtStudentName.Clear();
            // txtAttendance.Clear();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void EnrollmentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewEnrollmentInfo(e.RowIndex);
        }

        private void dgvScores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine(e.RowIndex + "\n::" +dgvScores.Rows[e.RowIndex].Cells["LectureId"].Value.ToString());
            lectureComboBox.SelectedValue = int.Parse(dgvScores.Rows[e.RowIndex].Cells["LectureId"].Value.ToString());
            txtMidTerm.Text = dgvScores.Rows[e.RowIndex].Cells["midTermDataGridViewTextBoxColumn"].Value.ToString();
            txtFinalTerm.Text = dgvScores.Rows[e.RowIndex].Cells["finalTermDataGridViewTextBoxColumn"].Value.ToString();
            txtAttendance.Text = dgvScores.Rows[e.RowIndex].Cells["attendanceDataGridViewTextBoxColumn"].Value.ToString();
        }
    }
    // 성적 정보 클래스
    // 이거는 db와 연동되는 엔티티 클래스를 이용할 것
    // 다만, 추가 필드나 기능이 필요하다면 상속이나 다른 방식으로 새 클래스를 만들 수는 있을 듯
    // public class Score
    // {
    //     public string StudentId { get; set; }
    //     public string StudentName { get; set; }
    //     public string Subject { get; set; }
    //     public double ScoreValue { get; set; }
    //     public double MidTerm { get; set; }
    //     public double FinalTerm { get; set; }
    //
    //     public Score(string studentId, string studentName, string subject, double scoreValue, double midTerm, double finalTerm)
    //     {
    //         StudentId = studentId;
    //         StudentName = studentName;
    //         Subject = subject;
    //         ScoreValue = scoreValue;
    //         MidTerm = midTerm;
    //         FinalTerm = finalTerm;
    //     }
    //
    //     public override string ToString()
    //     {
    //         return $"{Subject} - {ScoreValue}점 ({StudentName} - {StudentId})";
    //     }
    // }
}
