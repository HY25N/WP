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
            // this.Dock = DockStyle.Fill;
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

            // if (!context.Lectures.Any()) repo.AddLectureSampleData(lectureDataTable);
            

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
            string Code = numbertextBox.Text.Trim();
            string Name = subjecttextBox.Text.Trim();
            string Manager = professortextBox.Text.Trim();
            string Completion = completioncomboBox.SelectedItem?.ToString();
            string Credit = creditcomboBox.SelectedItem?.ToString();
            string Place = placetextBox.Text.Trim();
            string Capacity = capacitytextBox.Text.Trim();

            // 검색 조건이 비어있는지 확인
            if (string.IsNullOrEmpty(Code) && string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Manager) && string.IsNullOrEmpty(Completion) &&
                string.IsNullOrEmpty(Credit) && string.IsNullOrEmpty(Place) && string.IsNullOrEmpty(Capacity))
            {
                MessageBox.Show("검색된 강의가 없습니다."); // 모든 조건이 비어있을 때 메시지 출력
                return;
            }

            string filterExpression = "";

            // 조건에 맞는 필터를 추가
            if (!string.IsNullOrEmpty(Code))
                filterExpression += $"Code LIKE '%{Code}%'";
            if (!string.IsNullOrEmpty(Name))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Name LIKE '%{Name}%'";
            if (!string.IsNullOrEmpty(Manager))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Manager LIKE '%{Manager}%'";
            if (!string.IsNullOrEmpty(Completion))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Completion LIKE '%{Completion}%'";

            // Credit과 Capacity는 숫자로 가정
            if (int.TryParse(Credit, out int parsedCredit))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Credit = {parsedCredit}";
            if (int.TryParse(Capacity, out int parsedCapacity))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Capacity = {parsedCapacity}";

            if (!string.IsNullOrEmpty(Place))
                filterExpression += (filterExpression.Length > 0 ? " AND " : "") + $"Place LIKE '%{Place}%'";

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
            completioncomboBox.SelectedIndex = -1; // 선택된 항목을 없애기
            creditcomboBox.SelectedIndex = -1; // Credit 콤보박스 초기화
            placetextBox.Text = "";
            capacitytextBox.Text = "";

            // 원본 데이터로 DataGridView의 데이터를 초기화
            lectureGridView.DataSource = context.Lectures.ToList();
        }

        // 데이터그리드뷰에서 선택한 값 텍스트 박스에 띄우기
        private void lectureGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            numbertextBox.Text = lectureGridView.Rows[e.RowIndex].Cells["CodeColumn"].Value.ToString() ?? "";
            subjecttextBox.Text = lectureGridView.Rows[e.RowIndex].Cells["NameColumn"].Value.ToString() ?? ""; // "NameColumn"을 실제 열 이름으로 수정
            professortextBox.Text = lectureGridView.Rows[e.RowIndex].Cells["ManagerColumn"].Value.ToString() ?? ""; // "ManagerColumn"을 실제 열 이름으로 수정
            completioncomboBox.SelectedItem = lectureGridView.Rows[e.RowIndex].Cells["CompletionColumn"].Value.ToString() ?? ""; // "CompletionColumn"을 실제 열 이름으로 수정
            creditcomboBox.SelectedItem = lectureGridView.Rows[e.RowIndex].Cells["Credit"].Value.ToString() ?? ""; // "Credit"을 실제 열 이름으로 수정
            placetextBox.Text = lectureGridView.Rows[e.RowIndex].Cells["PlaceColumn"].Value.ToString() ?? ""; // "PlaceColumn"을 실제 열 이름으로 수정
            capacitytextBox.Text = lectureGridView.Rows[e.RowIndex].Cells["CapacityColumn"].Value.ToString() ?? ""; // "CapacityColumn"을 실제 열 이름으로 수정
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (lectureGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("수정할 강의를 선택해주세요.");
                    return;
                }

                // Get the selected lecture ID
                int lectureId = int.Parse(lectureGridView.SelectedRows[0].Cells["Id"].Value.ToString());
                Lecture lec = context.Lectures.SingleOrDefault(v => v.Id == lectureId);

                if (lec == null)
                {
                    MessageBox.Show("선택한 강의를 찾을 수 없습니다.");
                    return;
                }

                // Update lecture properties with values from the input controls
                lec.Code = numbertextBox.Text;
                lec.Name = subjecttextBox.Text;
                lec.Manager = professortextBox.Text;
                lec.Completion = completioncomboBox.SelectedItem?.ToString();
                lec.Credit = int.TryParse(creditcomboBox.Text, out int creditValue) ? creditValue : lec.Credit;
                lec.Place = placetextBox.Text;
                lec.Capacity = int.TryParse(capacitytextBox.Text, out int capacityValue) ? capacityValue : lec.Capacity;

                // Save changes to the database
                context.Lectures.AddOrUpdate(lec);
                context.SaveChanges();

                // Update the corresponding row in the DataTable
                DataRow row = lectureDataTable.Select($"Id = {lectureId}").FirstOrDefault();
                if (row != null)
                {
                    row["Code"] = lec.Code;
                    row["Name"] = lec.Name;
                    row["Manager"] = lec.Manager;
                    row["Completion"] = lec.Completion;
                    row["Credit"] = lec.Credit;
                    row["Place"] = lec.Place;
                    row["Capacity"] = lec.Capacity;
                }

                lectureGridView.DataSource = lectureDataTable; // Refresh the grid view
                MessageBox.Show("강의 정보가 성공적으로 수정되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"강의를 수정하는 중 문제가 발생했습니다.\n{ex.Message}");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int lectureId = int.Parse(lectureGridView.SelectedRows[0].Cells["Id"].Value.ToString());
                // db 처리
                Lecture lec = context.Lectures.SingleOrDefault(v => v.Id == lectureId);
                context.Lectures.Remove(lec);
                context.SaveChanges();


                // 뷰(데이터테이블) 처리
                DataRow dr = ((DataTable)lectureGridView.DataSource).Select($"Id = {lectureId}")[0];
                // foreach (DataRow dr2 in dr)
                // {
                    ((DataTable)lectureGridView.DataSource).Rows.Remove(dr);
                    ((DataTable)lectureGridView.DataSource).AcceptChanges();
                // }
            }
            catch (Exception ex)
            {
                MessageBox.Show("알 수 없는 문제\n페이지를 다시 로드해 주세요." + ex.Message);
                return;
            }
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // 입력 데이터 검증
                if (string.IsNullOrEmpty(numbertextBox.Text) || string.IsNullOrEmpty(subjecttextBox.Text) ||
                    string.IsNullOrEmpty(professortextBox.Text) || completioncomboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("모든 강의를 입력해주세요.");
                    return;
                }

                string lectureCode = numbertextBox.Text.Trim();

                // 강의 코드 중복 체크
                var existingLecture = context.Lectures.FirstOrDefault(l => l.Code == lectureCode);
                if (existingLecture != null)
                {
                    MessageBox.Show("이미 존재하는 강의 코드입니다. 다른 강의 코드를 입력해주세요.");
                    return; // 중복된 코드가 있으면 강의를 추가하지 않음
                }

                // 새로운 강의 객체 생성
                Lecture newLecture = new Lecture
                {
                    Code = lectureCode,
                    Name = subjecttextBox.Text.Trim(),
                    Manager = professortextBox.Text.Trim(),
                    Completion = completioncomboBox.SelectedItem.ToString(),
                    Credit = int.TryParse(creditcomboBox.Text, out int creditValue) ? creditValue : 0,
                    Place = placetextBox.Text.Trim(),
                    Capacity = int.TryParse(capacitytextBox.Text, out int capacityValue) ? capacityValue : 0
                };

                // 강의를 데이터베이스에 추가
                context.Lectures.Add(newLecture);
                context.SaveChanges();

                // 새로운 강의를 DataTable에 추가
                DataRow newRow = lectureDataTable.NewRow();
                newRow["Id"] = newLecture.Id; // ID는 데이터베이스에서 자동으로 생성됨
                newRow["Code"] = newLecture.Code;
                newRow["Name"] = newLecture.Name;
                newRow["Completion"] = newLecture.Completion;
                newRow["Manager"] = newLecture.Manager;
                newRow["Credit"] = newLecture.Credit;
                newRow["Place"] = newLecture.Place;
                newRow["Capacity"] = newLecture.Capacity;
                lectureDataTable.Rows.Add(newRow);

                // 그리드뷰 갱신
                lectureGridView.DataSource = lectureDataTable;

                // 강의 추가 완료 메시지
                MessageBox.Show("새 강의가 추가되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("강의를 추가하는 중 문제가 발생했습니다.\n" + ex.Message);
            }
        }
    }
}