using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3
{
    public partial class score : UserControl
    {
        private List<Score> scores = new List<Score>();

        // 성적 추가 버튼 클릭 이벤트
        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                string studentId = txtStudentId.Text;
                string studentName = txtStudentName.Text;
                string subject = txtSubject.Text;
                double score = double.Parse(txtScore.Text);

                // 성적 추가
                Score newScore = new Score(studentId, studentName, subject, score);
                scores.Add(newScore);

                // 리스트 박스에 추가
                lstScores.Items.Add(newScore.ToString());

                // DataGridView에 성적 데이터 갱신
                dgvScores.DataSource = scores.ToList();
                ClearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("성적을 올바르게 입력해주세요.");
            }
        }
        // 성적 수정 버튼 클릭 이벤트
        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            if (lstScores.SelectedItem != null)
            {
                // 선택된 성적 항목 수정
                Score selectedScore = scores[lstScores.SelectedIndex];
                selectedScore.Subject = txtSubject.Text;
                selectedScore.ScoreValue = double.Parse(txtScore.Text);

                // DataGridView 갱신
                dgvScores.DataSource = null;
                dgvScores.DataSource = scores.ToList();
                lstScores.Items[lstScores.SelectedIndex] = selectedScore.ToString();
            }
        }
        // 성적 삭제 버튼 클릭 이벤트
        private void btnDeleteScore_Click(object sender, EventArgs e)
        {
            if (lstScores.SelectedItem != null)
            {
                // 선택된 항목 삭제
                scores.RemoveAt(lstScores.SelectedIndex);
                lstScores.Items.RemoveAt(lstScores.SelectedIndex);

                // DataGridView 갱신
                dgvScores.DataSource = null;
                dgvScores.DataSource = scores.ToList();
            }
        }
        // 평균 계산 버튼 클릭 이벤트
        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            if (scores.Count > 0)
            {
                double average = scores.Average(s => s.ScoreValue);
                txtAverage.Text = average.ToString("F2");
            }
            else
            {
                MessageBox.Show("성적 데이터가 없습니다.");
            }
        }
        // 입력 필드 초기화
        private void ClearFields()
        {
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtSubject.Clear();
            txtScore.Clear();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
    // 성적 정보 클래스
    public class Score
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public double ScoreValue { get; set; }

        public Score(string studentId, string studentName, string subject, double scoreValue)
        {
            StudentId = studentId;
            StudentName = studentName;
            Subject = subject;
            ScoreValue = scoreValue;
        }

        public override string ToString()
        {
            return $"{Subject} - {ScoreValue}점 ({StudentName} - {StudentId})";
        }
    }
}