namespace pr3
{
    partial class LectureControl
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
            this.components = new System.ComponentModel.Container();
            this.professortextBox = new System.Windows.Forms.TextBox();
            this.professorlabel = new System.Windows.Forms.Label();
            this.completioncomboBox = new System.Windows.Forms.ComboBox();
            this.completionlabel = new System.Windows.Forms.Label();
            this.subjecttextBox = new System.Windows.Forms.TextBox();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.subjectlabel = new System.Windows.Forms.Label();
            this.numberlabel = new System.Windows.Forms.Label();
            this.searchgroupBox = new System.Windows.Forms.GroupBox();
            this.creditcomboBox = new System.Windows.Forms.ComboBox();
            this.placetextBox = new System.Windows.Forms.TextBox();
            this.placelabel = new System.Windows.Forms.Label();
            this.capacitytextBox = new System.Windows.Forms.TextBox();
            this.capacitylabel = new System.Windows.Forms.Label();
            this.creditlabel = new System.Windows.Forms.Label();
            this.lectureGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editgroupBox = new System.Windows.Forms.GroupBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.modifybutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).BeginInit();
            this.editgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // professortextBox
            // 
            this.professortextBox.Location = new System.Drawing.Point(577, 59);
            this.professortextBox.Name = "professortextBox";
            this.professortextBox.Size = new System.Drawing.Size(120, 21);
            this.professortextBox.TabIndex = 14;
            // 
            // professorlabel
            // 
            this.professorlabel.AutoSize = true;
            this.professorlabel.Location = new System.Drawing.Point(518, 62);
            this.professorlabel.Name = "professorlabel";
            this.professorlabel.Size = new System.Drawing.Size(53, 12);
            this.professorlabel.TabIndex = 13;
            this.professorlabel.Text = "교수명 : ";
            // 
            // completioncomboBox
            // 
            this.completioncomboBox.FormattingEnabled = true;
            this.completioncomboBox.Items.AddRange(new object[] {
            "전공 필수",
            "전공 선택",
            "교양 필수",
            "교양 선택"});
            this.completioncomboBox.Location = new System.Drawing.Point(149, 115);
            this.completioncomboBox.Name = "completioncomboBox";
            this.completioncomboBox.Size = new System.Drawing.Size(121, 20);
            this.completioncomboBox.TabIndex = 12;
            // 
            // completionlabel
            // 
            this.completionlabel.AutoSize = true;
            this.completionlabel.Location = new System.Drawing.Point(78, 118);
            this.completionlabel.Name = "completionlabel";
            this.completionlabel.Size = new System.Drawing.Size(65, 12);
            this.completionlabel.TabIndex = 11;
            this.completionlabel.Text = "이수구분 : ";
            // 
            // subjecttextBox
            // 
            this.subjecttextBox.Location = new System.Drawing.Point(369, 59);
            this.subjecttextBox.Name = "subjecttextBox";
            this.subjecttextBox.Size = new System.Drawing.Size(120, 21);
            this.subjecttextBox.TabIndex = 10;
            // 
            // numbertextBox
            // 
            this.numbertextBox.Location = new System.Drawing.Point(149, 59);
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(120, 21);
            this.numbertextBox.TabIndex = 9;
            // 
            // subjectlabel
            // 
            this.subjectlabel.AutoSize = true;
            this.subjectlabel.Location = new System.Drawing.Point(298, 63);
            this.subjectlabel.Name = "subjectlabel";
            this.subjectlabel.Size = new System.Drawing.Size(65, 12);
            this.subjectlabel.TabIndex = 8;
            this.subjectlabel.Text = "교과목명 : ";
            // 
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.Location = new System.Drawing.Point(78, 63);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(65, 12);
            this.numberlabel.TabIndex = 7;
            this.numberlabel.Text = "학수번호 : ";
            // 
            // searchgroupBox
            // 
            this.searchgroupBox.Controls.Add(this.creditcomboBox);
            this.searchgroupBox.Controls.Add(this.placetextBox);
            this.searchgroupBox.Controls.Add(this.placelabel);
            this.searchgroupBox.Controls.Add(this.capacitytextBox);
            this.searchgroupBox.Controls.Add(this.capacitylabel);
            this.searchgroupBox.Controls.Add(this.creditlabel);
            this.searchgroupBox.Controls.Add(this.professortextBox);
            this.searchgroupBox.Controls.Add(this.professorlabel);
            this.searchgroupBox.Controls.Add(this.completioncomboBox);
            this.searchgroupBox.Controls.Add(this.completionlabel);
            this.searchgroupBox.Controls.Add(this.subjecttextBox);
            this.searchgroupBox.Controls.Add(this.numbertextBox);
            this.searchgroupBox.Controls.Add(this.subjectlabel);
            this.searchgroupBox.Controls.Add(this.numberlabel);
            this.searchgroupBox.Location = new System.Drawing.Point(3, 3);
            this.searchgroupBox.Name = "searchgroupBox";
            this.searchgroupBox.Size = new System.Drawing.Size(1022, 188);
            this.searchgroupBox.TabIndex = 8;
            this.searchgroupBox.TabStop = false;
            this.searchgroupBox.Text = "강의 검색";
            // 
            // creditcomboBox
            // 
            this.creditcomboBox.FormattingEnabled = true;
            this.creditcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.creditcomboBox.Location = new System.Drawing.Point(767, 59);
            this.creditcomboBox.Name = "creditcomboBox";
            this.creditcomboBox.Size = new System.Drawing.Size(71, 20);
            this.creditcomboBox.TabIndex = 21;
            // 
            // placetextBox
            // 
            this.placetextBox.Location = new System.Drawing.Point(627, 114);
            this.placetextBox.Name = "placetextBox";
            this.placetextBox.Size = new System.Drawing.Size(211, 21);
            this.placetextBox.TabIndex = 20;
            // 
            // placelabel
            // 
            this.placelabel.AutoSize = true;
            this.placelabel.Location = new System.Drawing.Point(518, 118);
            this.placelabel.Name = "placelabel";
            this.placelabel.Size = new System.Drawing.Size(103, 12);
            this.placelabel.TabIndex = 19;
            this.placelabel.Text = "강의 요일 / 시간 :";
            // 
            // capacitytextBox
            // 
            this.capacitytextBox.Location = new System.Drawing.Point(369, 114);
            this.capacitytextBox.Name = "capacitytextBox";
            this.capacitytextBox.Size = new System.Drawing.Size(120, 21);
            this.capacitytextBox.TabIndex = 18;
            // 
            // capacitylabel
            // 
            this.capacitylabel.AutoSize = true;
            this.capacitylabel.Location = new System.Drawing.Point(298, 118);
            this.capacitylabel.Name = "capacitylabel";
            this.capacitylabel.Size = new System.Drawing.Size(61, 12);
            this.capacitylabel.TabIndex = 16;
            this.capacitylabel.Text = "수강인원 :";
            // 
            // creditlabel
            // 
            this.creditlabel.AutoSize = true;
            this.creditlabel.Location = new System.Drawing.Point(724, 63);
            this.creditlabel.Name = "creditlabel";
            this.creditlabel.Size = new System.Drawing.Size(37, 12);
            this.creditlabel.TabIndex = 15;
            this.creditlabel.Text = "학점 :";
            // 
            // lectureGridView
            // 
            this.lectureGridView.AllowUserToAddRows = false;
            this.lectureGridView.AllowUserToDeleteRows = false;
            this.lectureGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lectureGridView.AutoGenerateColumns = false;
            this.lectureGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectureGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.lectureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectureGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodeColumn,
            this.nameColumn,
            this.CompletionColumn,
            this.managerColumn,
            this.Credit,
            this.PlaceColumn,
            this.CapacityColumn});
            this.lectureGridView.DataSource = this.lectureBindingSource;
            this.lectureGridView.Location = new System.Drawing.Point(3, 197);
            this.lectureGridView.Name = "lectureGridView";
            this.lectureGridView.ReadOnly = true;
            this.lectureGridView.RowHeadersWidth = 62;
            this.lectureGridView.RowTemplate.Height = 23;
            this.lectureGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lectureGridView.Size = new System.Drawing.Size(1697, 803);
            this.lectureGridView.TabIndex = 9;
            this.lectureGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectureGridView_CellEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 9;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CompletionColumn
            // 
            this.CompletionColumn.DataPropertyName = "Completion";
            this.CompletionColumn.HeaderText = "이수구분";
            this.CompletionColumn.MinimumWidth = 9;
            this.CompletionColumn.Name = "CompletionColumn";
            this.CompletionColumn.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "학점";
            this.Credit.MinimumWidth = 9;
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // editgroupBox
            // 
            this.editgroupBox.Controls.Add(this.createbutton);
            this.editgroupBox.Controls.Add(this.deletebutton);
            this.editgroupBox.Controls.Add(this.modifybutton);
            this.editgroupBox.Controls.Add(this.resetbutton);
            this.editgroupBox.Controls.Add(this.searchbutton);
            this.editgroupBox.Location = new System.Drawing.Point(1031, 3);
            this.editgroupBox.Name = "editgroupBox";
            this.editgroupBox.Size = new System.Drawing.Size(653, 188);
            this.editgroupBox.TabIndex = 10;
            this.editgroupBox.TabStop = false;
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(372, 21);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(159, 47);
            this.createbutton.TabIndex = 20;
            this.createbutton.Text = "등록";
            this.createbutton.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(372, 127);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(159, 47);
            this.deletebutton.TabIndex = 19;
            this.deletebutton.Text = "삭제";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // modifybutton
            // 
            this.modifybutton.Location = new System.Drawing.Point(372, 74);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(159, 47);
            this.modifybutton.TabIndex = 18;
            this.modifybutton.Text = "수정";
            this.modifybutton.UseVisualStyleBackColor = true;
            this.modifybutton.Click += new System.EventHandler(this.modifybutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(116, 99);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(159, 47);
            this.resetbutton.TabIndex = 17;
            this.resetbutton.Text = "초기화";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(116, 46);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(159, 47);
            this.searchbutton.TabIndex = 16;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // CodeColumn
            // 
            this.CodeColumn.DataPropertyName = "Code";
            this.CodeColumn.HeaderText = "학수번호";
            this.CodeColumn.MinimumWidth = 9;
            this.CodeColumn.Name = "CodeColumn";
            this.CodeColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "교과목명";
            this.nameColumn.MinimumWidth = 9;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // managerColumn
            // 
            this.managerColumn.DataPropertyName = "Manager";
            this.managerColumn.HeaderText = "교수명";
            this.managerColumn.MinimumWidth = 9;
            this.managerColumn.Name = "managerColumn";
            this.managerColumn.ReadOnly = true;
            // 
            // PlaceColumn
            // 
            this.PlaceColumn.DataPropertyName = "Place";
            this.PlaceColumn.HeaderText = "강의 요일 / 시간";
            this.PlaceColumn.MinimumWidth = 9;
            this.PlaceColumn.Name = "PlaceColumn";
            this.PlaceColumn.ReadOnly = true;
            // 
            // CapacityColumn
            // 
            this.CapacityColumn.DataPropertyName = "Capacity";
            this.CapacityColumn.HeaderText = "수강인원";
            this.CapacityColumn.MinimumWidth = 9;
            this.CapacityColumn.Name = "CapacityColumn";
            this.CapacityColumn.ReadOnly = true;
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataSource = typeof(pr3.Lecture);
            // 
            // LectureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editgroupBox);
            this.Controls.Add(this.searchgroupBox);
            this.Controls.Add(this.lectureGridView);
            this.Name = "LectureControl";
            this.Size = new System.Drawing.Size(1700, 1000);
            this.searchgroupBox.ResumeLayout(false);
            this.searchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).EndInit();
            this.editgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox professortextBox;
        private System.Windows.Forms.Label professorlabel;
        private System.Windows.Forms.ComboBox completioncomboBox;
        private System.Windows.Forms.Label completionlabel;
        private System.Windows.Forms.TextBox subjecttextBox;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.Label subjectlabel;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.DataGridView lectureGridView;
        private System.Windows.Forms.GroupBox searchgroupBox;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private System.Windows.Forms.TextBox placetextBox;
        private System.Windows.Forms.Label placelabel;
        private System.Windows.Forms.TextBox capacitytextBox;
        private System.Windows.Forms.Label capacitylabel;
        private System.Windows.Forms.Label creditlabel;
        private System.Windows.Forms.GroupBox editgroupBox;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button modifybutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.ComboBox creditcomboBox;
    }
}
