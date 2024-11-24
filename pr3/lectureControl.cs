using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3
{
    public partial class LectureControl : UserControl
    {
        public ApplicationDbContext context;
        private DataTable lectureDataTable;
        private Repository repo;

        public LectureControl(ApplicationDbContext context, Repository repo)
        {
            InitializeComponent();
            this.context = context;
            this.repo = repo;
            InitializeDataTable();
            
            // lectureGridView.DataSource = lectureDataTable;
        }
        
                
        private void InitializeDataTable()
        {
            lectureDataTable = new DataTable();
            lectureDataTable.Columns.Add("Id", typeof(int));    // 학수번호
            lectureDataTable.Columns.Add("Code", typeof(string));    // 학수번호
            lectureDataTable.Columns.Add("Name", typeof(string));    // 교과목명
            lectureDataTable.Columns.Add("Completion", typeof(string)); // 이수구분
            lectureDataTable.Columns.Add("Manager", typeof(string)); // 교수명
            lectureDataTable.Columns.Add("Credit", typeof(int));     // 학점
            lectureDataTable.Columns.Add("Place", typeof(string));   // 강의 요일/시간
            lectureDataTable.Columns.Add("Capacity", typeof(int));   // 수강인원

            if (!context.Lectures.Any()) repo.AddLectureSampleData(lectureDataTable);
            

            // lectureGridView.DataSource = context.Lectures.ToList();
            // db를 읽어오고, 렉처그리드뷰의 데이터소스에 렉쳐테이블을 대입한다.
            foreach (var lecture in context.Lectures.ToList())
            {
                DataRow row = lectureDataTable.NewRow();
                row["Id"] = lecture.Id;
                row["Name"] = lecture.Name;
                row["Code"] = lecture.Code;
                row["Manager"] = lecture.Manager;
                row["Completion"] = lecture.Completion;
                row["Credit"] = lecture.Credit;
                row["Place"] = lecture.Place;
                row["Capacity"] = lecture.Capacity;
                lectureDataTable.Rows.Add(row);
            }

            lectureGridView.DataSource = lectureDataTable;
            if (lectureGridView.Columns.Contains("Id")) lectureGridView.Columns["Id"].Visible = false;
        }


        private void searchbutton_Click(object sender, EventArgs e)
        {
            string Code = numbertextBox.Text;
            string Name = subjecttextBox.Text;
            string Manager = professortextBox.Text;
            string Completion = choicecomboBox.SelectedItem?.ToString();

            string filterExpression = "";

            // 필터 조건이 비어있는 경우에도 잘 작동하도록 작성
            if (!string.IsNullOrEmpty(Code))
                filterExpression += $"Code LIKE '%{Code}%'";
            if (!string.IsNullOrEmpty(Name))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Name LIKE '%{Name}%'";
            if (!string.IsNullOrEmpty(Manager))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Manager LIKE '%{Manager}%'";
            if (!string.IsNullOrEmpty(Completion))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Completion LIKE '%{Completion}%'";

            try
            {
                DataRow[] filteredRows = lectureDataTable.Select(filterExpression);

                if (filteredRows.Length > 0)
                {
                    // 필터링된 데이터가 있을 경우 DataTable로 변환 후 DataGridView에 설정
                    DataTable filteredTable = filteredRows.CopyToDataTable();
                    lectureGridView.DataSource = filteredTable;
                }
                else
                {
                    // 검색된 강의가 없을 경우 메시지 출력
                    MessageBox.Show("검색된 강의가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                // 예외 처리
                MessageBox.Show($"필터링 오류: {ex.Message}");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // 검색 텍스트 초기화
            numbertextBox.Text = "";
            subjecttextBox.Text = "";
            professortextBox.Text = "";
            choicecomboBox.SelectedIndex = -1; // 선택된 항목을 없애기

            // 원본 데이터로 DataGridView의 데이터를 초기화
            lectureGridView.DataSource = context.Lectures.ToList();
        }

        // 데이터그리드뷰에서 선택한 값 텍스트 박스에 띄우기
        private void lectureGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            numbertextBox.Text = lectureGridView.Rows[e.RowIndex].Cells["CodeColumn"].Value.ToString() ?? "";
            professortextBox.Text = lectureGridView.Rows[e.RowIndex].Cells["managerColumn"].Value.ToString() ?? "";
            // todo 이하 작성 필요
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {
            int lectureId = int.Parse(lectureGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            Lecture lec = context.Lectures.SingleOrDefault(v => v.Id == lectureId);


            // todo 지금은 강좌명만 바꾸고 있다. 다른 값도 다 바꿔야 한다.
            lec.Name = subjecttextBox.Text;

            try
            {
                // 없는 것은 새로, 있는 것은 수정하는 메서드
                context.Lectures.AddOrUpdate(lec);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("알 수 없는 문제\n나중에 다시 시도해주세요." + ex.Message);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int lectureId = int.Parse(lectureGridView.SelectedRows[0].Cells["Id"].Value.ToString());

            try
            {
                Lecture lec = context.Lectures.SingleOrDefault(v => v.Id == lectureId);
                context.Lectures.Remove(lec);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("알 수 없는 문제\n나중에 다시 시도해주세요." + ex.Message);
                return;
            }

            DataRow[] dr = ((DataTable)lectureGridView.DataSource).Select($"Id = {lectureId}");
            foreach (DataRow dr2 in dr)
            {
                ((DataTable)lectureGridView.DataSource).Rows.Remove(dr2);
            }
            ((DataTable)lectureGridView.DataSource).AcceptChanges();
        }
    }
}