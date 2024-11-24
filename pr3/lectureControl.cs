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
            InitializeDataTable();
            AddSampleData();
            lectureGridView.DataSource = lectureDataTable;
            this.context = context;
        }
                
        private DataTable lectureDataTable;
                
        private void InitializeDataTable()
        {
            lectureDataTable = new DataTable();
            lectureDataTable.Columns.Add("Code", typeof(string));    // 학수번호
            lectureDataTable.Columns.Add("Name", typeof(string));    // 교과목명
            lectureDataTable.Columns.Add("Completion", typeof(string)); // 이수구분
            lectureDataTable.Columns.Add("Manager", typeof(string)); // 교수명
            lectureDataTable.Columns.Add("Credit", typeof(int));     // 학점
            lectureDataTable.Columns.Add("Place", typeof(string));   // 강의 요일/시간
            lectureDataTable.Columns.Add("Capacity", typeof(int));   // 수강인원
        }

        private void AddSampleData()
        {
            // 기존 샘플 데이터
            lectureDataTable.Rows.Add("CS101", "프로그래밍 기초", "전공 필수", "홍길동", 3, "월/수 10:00-12:00", 40);
            lectureDataTable.Rows.Add("CS102", "자료구조", "전공 선택", "김철수", 3, "화/목 14:00-16:00", 35);
            lectureDataTable.Rows.Add("GE201", "기초영어", "교양 선택", "박영희", 2, "월/수 09:00-10:30", 50);
            lectureDataTable.Rows.Add("GE202", "논리학", "교양 필수", "이상훈", 2, "화/목 11:00-12:30", 30);

            // 추가된 샘플 데이터
            lectureDataTable.Rows.Add("CS201", "컴퓨터 네트워크", "전공 필수", "김민수", 3, "월/금 13:00-15:00", 40);
            lectureDataTable.Rows.Add("CS202", "운영체제", "전공 선택", "이성민", 3, "화/목 10:00-12:00", 45);
            lectureDataTable.Rows.Add("CS203", "알고리즘", "전공 필수", "최윤희", 3, "수/금 10:00-12:00", 50);
            lectureDataTable.Rows.Add("CS204", "디지털 논리 회로", "전공 선택", "박재현", 3, "월/수 15:00-17:00", 30);

            // 교양과목 샘플 추가
            lectureDataTable.Rows.Add("GE301", "심리학", "교양 선택", "김동수", 2, "월/목 10:00-12:00", 60);
            lectureDataTable.Rows.Add("GE302", "경제학 원론", "교양 필수", "황민지", 3, "화/금 14:00-16:00", 40);
            lectureDataTable.Rows.Add("GE303", "영어회화", "교양 선택", "이상민", 2, "월/수 11:00-12:30", 45);
            lectureDataTable.Rows.Add("GE304", "철학 개론", "교양 필수", "전지현", 2, "화/목 13:00-14:30", 50);

            // 다양한 학수번호, 교수명, 시간대 조합 추가
            lectureDataTable.Rows.Add("CS301", "인공지능", "전공 필수", "김세훈", 3, "월/금 14:00-16:00", 35);
            lectureDataTable.Rows.Add("CS302", "컴퓨터 그래픽스", "전공 선택", "조수미", 3, "수/금 13:00-15:00", 25);
            lectureDataTable.Rows.Add("CS303", "데이터베이스 시스템", "전공 필수", "홍수정", 3, "월/수 09:00-11:00", 40);
            lectureDataTable.Rows.Add("CS304", "소프트웨어 공학", "전공 선택", "이상철", 3, "화/목 09:00-11:00", 30);

            // 교양과목 추가 (교양 선택과 필수 포함)
            lectureDataTable.Rows.Add("GE401", "통계학", "교양 필수", "정명훈", 3, "월/금 13:00-15:00", 50);
            lectureDataTable.Rows.Add("GE402", "기후변화", "교양 선택", "박주희", 2, "화/목 11:00-12:30", 45);
            lectureDataTable.Rows.Add("GE403", "인문학의 이해", "교양 필수", "한예슬", 3, "수/금 10:00-12:00", 55);
            lectureDataTable.Rows.Add("GE404", "문화학 개론", "교양 선택", "최성훈", 2, "월/수 14:00-16:00", 50);

            // 추가적인 전공 필수와 선택 과목
            lectureDataTable.Rows.Add("CS401", "컴퓨터 비전", "전공 선택", "김유진", 3, "화/목 15:00-17:00", 40);
            lectureDataTable.Rows.Add("CS402", "기계학습", "전공 필수", "이하늘", 3, "월/금 11:00-13:00", 60);
            lectureDataTable.Rows.Add("CS403", "패턴 인식", "전공 선택", "오민수", 3, "수/목 10:00-12:00", 35);
            lectureDataTable.Rows.Add("CS404", "클라우드 컴퓨팅", "전공 필수", "정다운", 3, "월/수 16:00-18:00", 50);

            // 교양과목 추가
            lectureDataTable.Rows.Add("GE501", "세계 문화의 이해", "교양 선택", "이주은", 2, "화/목 13:00-14:30", 30);
            lectureDataTable.Rows.Add("GE502", "글쓰기", "교양 필수", "김동희", 2, "월/수 09:00-10:30", 45);
            lectureDataTable.Rows.Add("GE503", "사회학 개론", "교양 선택", "유지윤", 3, "화/금 15:00-17:00", 40);
            lectureDataTable.Rows.Add("GE504", "예술과 창의성", "교양 선택", "정유진", 2, "월/금 14:00-16:00", 50);
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
            lectureGridView.DataSource = lectureDataTable.Copy();
        }
    }
}