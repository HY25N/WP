namespace 강의
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
            this.searhgroupBox = new System.Windows.Forms.GroupBox();
            this.professortextBox = new System.Windows.Forms.TextBox();
            this.professorlabel = new System.Windows.Forms.Label();
            this.choicecomboBox = new System.Windows.Forms.ComboBox();
            this.Completionlabel = new System.Windows.Forms.Label();
            this.subjecttextBox = new System.Windows.Forms.TextBox();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.subjectlabel = new System.Windows.Forms.Label();
            this.numberlabel = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.lectureGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searhgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searhgroupBox
            // 
            this.searhgroupBox.BackColor = System.Drawing.SystemColors.Info;
            this.searhgroupBox.Controls.Add(this.professortextBox);
            this.searhgroupBox.Controls.Add(this.professorlabel);
            this.searhgroupBox.Controls.Add(this.choicecomboBox);
            this.searhgroupBox.Controls.Add(this.Completionlabel);
            this.searhgroupBox.Controls.Add(this.subjecttextBox);
            this.searhgroupBox.Controls.Add(this.numbertextBox);
            this.searhgroupBox.Controls.Add(this.subjectlabel);
            this.searhgroupBox.Controls.Add(this.numberlabel);
            this.searhgroupBox.Controls.Add(this.searchbutton);
            this.searhgroupBox.Location = new System.Drawing.Point(6, 6);
            this.searhgroupBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searhgroupBox.Name = "searhgroupBox";
            this.searhgroupBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searhgroupBox.Size = new System.Drawing.Size(2249, 202);
            this.searhgroupBox.TabIndex = 6;
            this.searhgroupBox.TabStop = false;
            this.searhgroupBox.Text = "강의 검색";
            // 
            // professortextBox
            // 
            this.professortextBox.Location = new System.Drawing.Point(1391, 92);
            this.professortextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.professortextBox.Name = "professortextBox";
            this.professortextBox.Size = new System.Drawing.Size(219, 35);
            this.professortextBox.TabIndex = 14;
            // 
            // professorlabel
            // 
            this.professorlabel.AutoSize = true;
            this.professorlabel.Location = new System.Drawing.Point(1281, 100);
            this.professorlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.professorlabel.Name = "professorlabel";
            this.professorlabel.Size = new System.Drawing.Size(106, 24);
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
            this.choicecomboBox.Location = new System.Drawing.Point(1005, 94);
            this.choicecomboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.choicecomboBox.Name = "choicecomboBox";
            this.choicecomboBox.Size = new System.Drawing.Size(221, 32);
            this.choicecomboBox.TabIndex = 12;
            // 
            // Completionlabel
            // 
            this.Completionlabel.AutoSize = true;
            this.Completionlabel.Location = new System.Drawing.Point(873, 100);
            this.Completionlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Completionlabel.Name = "Completionlabel";
            this.Completionlabel.Size = new System.Drawing.Size(130, 24);
            this.Completionlabel.TabIndex = 11;
            this.Completionlabel.Text = "이수구분 : ";
            // 
            // subjecttextBox
            // 
            this.subjecttextBox.Location = new System.Drawing.Point(596, 92);
            this.subjecttextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.subjecttextBox.Name = "subjecttextBox";
            this.subjecttextBox.Size = new System.Drawing.Size(219, 35);
            this.subjecttextBox.TabIndex = 10;
            // 
            // numbertextBox
            // 
            this.numbertextBox.Location = new System.Drawing.Point(188, 92);
            this.numbertextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(219, 35);
            this.numbertextBox.TabIndex = 9;
            // 
            // subjectlabel
            // 
            this.subjectlabel.AutoSize = true;
            this.subjectlabel.Location = new System.Drawing.Point(464, 100);
            this.subjectlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.subjectlabel.Name = "subjectlabel";
            this.subjectlabel.Size = new System.Drawing.Size(130, 24);
            this.subjectlabel.TabIndex = 8;
            this.subjectlabel.Text = "교과목명 : ";
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.Location = new System.Drawing.Point(56, 100);
            this.numberlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(130, 24);
            this.numberlabel.TabIndex = 7;
            this.numberlabel.Text = "학수번호 : ";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(1909, 64);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(295, 94);
            this.searchbutton.TabIndex = 6;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = true;
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
            this.lectureGridView.Location = new System.Drawing.Point(6, 220);
            this.lectureGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lectureGridView.Name = "lectureGridView";
            this.lectureGridView.RowHeadersWidth = 82;
            this.lectureGridView.RowTemplate.Height = 23;
            this.lectureGridView.Size = new System.Drawing.Size(2249, 1278);
            this.lectureGridView.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "학수번호";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "교과목명";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "교수명";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "이수구분";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "학점";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "강의요일 / 시간";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "강의실";
            this.Column7.MinimumWidth = 10;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "수강인원";
            this.Column8.MinimumWidth = 10;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "분반";
            this.Column9.MinimumWidth = 10;
            this.Column9.Name = "Column9";
            // 
            // lectureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lectureGridView);
            this.Controls.Add(this.searhgroupBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "lectureControl";
            this.Size = new System.Drawing.Size(2260, 1504);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.searhgroupBox.ResumeLayout(false);
            this.searhgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox searhgroupBox;
        private System.Windows.Forms.TextBox subjecttextBox;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.Label subjectlabel;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridView lectureGridView;
        private System.Windows.Forms.Label Completionlabel;
        private System.Windows.Forms.ComboBox choicecomboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox professortextBox;
        private System.Windows.Forms.Label professorlabel;
    }
}
