namespace pr3
{
    partial class lectureControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professortextBox = new System.Windows.Forms.TextBox();
            this.professorlabel = new System.Windows.Forms.Label();
            this.choicecomboBox = new System.Windows.Forms.ComboBox();
            this.Completionlabel = new System.Windows.Forms.Label();
            this.subjecttextBox = new System.Windows.Forms.TextBox();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.subjectlabel = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberlabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbutton = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searhgroupBox = new System.Windows.Forms.GroupBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureGridView = new System.Windows.Forms.DataGridView();
            this.searhgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Column9
            // 
            this.Column9.HeaderText = "분반";
            this.Column9.Name = "Column9";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "강의실";
            this.Column7.Name = "Column7";
            // 
            // professortextBox
            // 
            this.professortextBox.Location = new System.Drawing.Point(749, 46);
            this.professortextBox.Name = "professortextBox";
            this.professortextBox.Size = new System.Drawing.Size(120, 21);
            this.professortextBox.TabIndex = 14;
            // 
            // professorlabel
            // 
            this.professorlabel.AutoSize = true;
            this.professorlabel.Location = new System.Drawing.Point(690, 50);
            this.professorlabel.Name = "professorlabel";
            this.professorlabel.Size = new System.Drawing.Size(53, 12);
            this.professorlabel.TabIndex = 13;
            this.professorlabel.Text = "교수명 : ";
            // 
            // choicecomboBox
            // 
            this.choicecomboBox.FormattingEnabled = true;
            this.choicecomboBox.Items.AddRange(new object[] {
            "전공 필수",
            "전공 선택",
            "교양 필수",
            "교양 선택"});
            this.choicecomboBox.Location = new System.Drawing.Point(541, 47);
            this.choicecomboBox.Name = "choicecomboBox";
            this.choicecomboBox.Size = new System.Drawing.Size(121, 20);
            this.choicecomboBox.TabIndex = 12;
            // 
            // Completionlabel
            // 
            this.Completionlabel.AutoSize = true;
            this.Completionlabel.Location = new System.Drawing.Point(470, 50);
            this.Completionlabel.Name = "Completionlabel";
            this.Completionlabel.Size = new System.Drawing.Size(65, 12);
            this.Completionlabel.TabIndex = 11;
            this.Completionlabel.Text = "이수구분 : ";
            // 
            // subjecttextBox
            // 
            this.subjecttextBox.Location = new System.Drawing.Point(321, 46);
            this.subjecttextBox.Name = "subjecttextBox";
            this.subjecttextBox.Size = new System.Drawing.Size(120, 21);
            this.subjecttextBox.TabIndex = 10;
            // 
            // numbertextBox
            // 
            this.numbertextBox.Location = new System.Drawing.Point(101, 46);
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(120, 21);
            this.numbertextBox.TabIndex = 9;
            // 
            // subjectlabel
            // 
            this.subjectlabel.AutoSize = true;
            this.subjectlabel.Location = new System.Drawing.Point(250, 50);
            this.subjectlabel.Name = "subjectlabel";
            this.subjectlabel.Size = new System.Drawing.Size(65, 12);
            this.subjectlabel.TabIndex = 8;
            this.subjectlabel.Text = "교과목명 : ";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "강의요일 / 시간";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "학점";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "이수구분";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "교수명";
            this.Column3.Name = "Column3";
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.Location = new System.Drawing.Point(30, 50);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(65, 12);
            this.numberlabel.TabIndex = 7;
            this.numberlabel.Text = "학수번호 : ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "학수번호";
            this.Column1.Name = "Column1";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(1204, 33);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(159, 47);
            this.searchbutton.TabIndex = 6;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "수강인원";
            this.Column8.Name = "Column8";
            // 
            // searhgroupBox
            // 
            this.searhgroupBox.Controls.Add(this.professortextBox);
            this.searhgroupBox.Controls.Add(this.professorlabel);
            this.searhgroupBox.Controls.Add(this.choicecomboBox);
            this.searhgroupBox.Controls.Add(this.Completionlabel);
            this.searhgroupBox.Controls.Add(this.subjecttextBox);
            this.searhgroupBox.Controls.Add(this.numbertextBox);
            this.searhgroupBox.Controls.Add(this.subjectlabel);
            this.searhgroupBox.Controls.Add(this.numberlabel);
            this.searhgroupBox.Controls.Add(this.searchbutton);
            this.searhgroupBox.Location = new System.Drawing.Point(3, 3);
            this.searhgroupBox.Name = "searhgroupBox";
            this.searhgroupBox.Size = new System.Drawing.Size(1369, 101);
            this.searhgroupBox.TabIndex = 8;
            this.searhgroupBox.TabStop = false;
            this.searhgroupBox.Text = "강의 검색";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "교과목명";
            this.Column2.Name = "Column2";
            // 
            // lectureGridView
            // 
            this.lectureGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectureGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.lectureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectureGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.lectureGridView.Location = new System.Drawing.Point(3, 110);
            this.lectureGridView.Name = "lectureGridView";
            this.lectureGridView.RowTemplate.Height = 23;
            this.lectureGridView.Size = new System.Drawing.Size(1369, 720);
            this.lectureGridView.TabIndex = 9;
            // 
            // lectureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searhgroupBox);
            this.Controls.Add(this.lectureGridView);
            this.Name = "lectureControl";
            this.Size = new System.Drawing.Size(1415, 858);
            this.searhgroupBox.ResumeLayout(false);
            this.searhgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox professortextBox;
        private System.Windows.Forms.Label professorlabel;
        private System.Windows.Forms.ComboBox choicecomboBox;
        private System.Windows.Forms.Label Completionlabel;
        private System.Windows.Forms.TextBox subjecttextBox;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.Label subjectlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox searhgroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView lectureGridView;
    }
}
