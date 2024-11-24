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
            this.components = new System.ComponentModel.Container();
            this.professortextBox = new System.Windows.Forms.TextBox();
            this.professorlabel = new System.Windows.Forms.Label();
            this.choicecomboBox = new System.Windows.Forms.ComboBox();
            this.Completionlabel = new System.Windows.Forms.Label();
            this.subjecttextBox = new System.Windows.Forms.TextBox();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.subjectlabel = new System.Windows.Forms.Label();
            this.numberlabel = new System.Windows.Forms.Label();
            this.searchgroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Placelabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Capacitylabel = new System.Windows.Forms.Label();
            this.Creditlabel = new System.Windows.Forms.Label();
            this.lectureGridView = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editgroupBox = new System.Windows.Forms.GroupBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.modifybutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            this.editgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // professortextBox
            // 
            this.professortextBox.Location = new System.Drawing.Point(529, 46);
            this.professortextBox.Name = "professortextBox";
            this.professortextBox.Size = new System.Drawing.Size(120, 21);
            this.professortextBox.TabIndex = 14;
            // 
            // professorlabel
            // 
            this.professorlabel.AutoSize = true;
            this.professorlabel.Location = new System.Drawing.Point(470, 49);
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
            this.choicecomboBox.Location = new System.Drawing.Point(101, 102);
            this.choicecomboBox.Name = "choicecomboBox";
            this.choicecomboBox.Size = new System.Drawing.Size(121, 20);
            this.choicecomboBox.TabIndex = 12;
            // 
            // Completionlabel
            // 
            this.Completionlabel.AutoSize = true;
            this.Completionlabel.Location = new System.Drawing.Point(30, 105);
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
            // numberlabel
            // 
            this.numberlabel.AutoSize = true;
            this.numberlabel.Location = new System.Drawing.Point(30, 50);
            this.numberlabel.Name = "numberlabel";
            this.numberlabel.Size = new System.Drawing.Size(65, 12);
            this.numberlabel.TabIndex = 7;
            this.numberlabel.Text = "학수번호 : ";
            // 
            // searchgroupBox
            // 
            this.searchgroupBox.Controls.Add(this.textBox1);
            this.searchgroupBox.Controls.Add(this.Placelabel);
            this.searchgroupBox.Controls.Add(this.textBox2);
            this.searchgroupBox.Controls.Add(this.textBox3);
            this.searchgroupBox.Controls.Add(this.Capacitylabel);
            this.searchgroupBox.Controls.Add(this.Creditlabel);
            this.searchgroupBox.Controls.Add(this.professortextBox);
            this.searchgroupBox.Controls.Add(this.professorlabel);
            this.searchgroupBox.Controls.Add(this.choicecomboBox);
            this.searchgroupBox.Controls.Add(this.Completionlabel);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 21);
            this.textBox1.TabIndex = 20;
            // 
            // Placelabel
            // 
            this.Placelabel.AutoSize = true;
            this.Placelabel.Location = new System.Drawing.Point(470, 105);
            this.Placelabel.Name = "Placelabel";
            this.Placelabel.Size = new System.Drawing.Size(103, 12);
            this.Placelabel.TabIndex = 19;
            this.Placelabel.Text = "강의 요일 / 시간 :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(719, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 21);
            this.textBox3.TabIndex = 17;
            // 
            // Capacitylabel
            // 
            this.Capacitylabel.AutoSize = true;
            this.Capacitylabel.Location = new System.Drawing.Point(250, 105);
            this.Capacitylabel.Name = "Capacitylabel";
            this.Capacitylabel.Size = new System.Drawing.Size(61, 12);
            this.Capacitylabel.TabIndex = 16;
            this.Capacitylabel.Text = "수강인원 :";
            // 
            // Creditlabel
            // 
            this.Creditlabel.AutoSize = true;
            this.Creditlabel.Location = new System.Drawing.Point(676, 50);
            this.Creditlabel.Name = "Creditlabel";
            this.Creditlabel.Size = new System.Drawing.Size(37, 12);
            this.Creditlabel.TabIndex = 15;
            this.Creditlabel.Text = "학점 :";
            // 
            // lectureGridView
            // 
            this.lectureGridView.AutoGenerateColumns = false;
            this.lectureGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectureGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.lectureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectureGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ObjectDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.lectureGridView.DataSource = this.lectureBindingSource;
            this.lectureGridView.Location = new System.Drawing.Point(3, 197);
            this.lectureGridView.Name = "lectureGridView";
            this.lectureGridView.RowHeadersWidth = 62;
            this.lectureGridView.RowTemplate.Height = 23;
            this.lectureGridView.Size = new System.Drawing.Size(1600, 800);
            this.lectureGridView.TabIndex = 9;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "학수번호";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "교과목명";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ObjectDataGridViewTextBoxColumn
            // 
            this.ObjectDataGridViewTextBoxColumn.DataPropertyName = "Completion";
            this.ObjectDataGridViewTextBoxColumn.HeaderText = "이수구분";
            this.ObjectDataGridViewTextBoxColumn.Name = "ObjectDataGridViewTextBoxColumn";
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "Manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "교수명";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "학점";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "강의 요일 / 시간";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "수강인원";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataSource = typeof(pr3.Lecture);
            // 
            // editgroupBox
            // 
            this.editgroupBox.Controls.Add(this.deletebutton);
            this.editgroupBox.Controls.Add(this.modifybutton);
            this.editgroupBox.Controls.Add(this.resetbutton);
            this.editgroupBox.Controls.Add(this.searchbutton);
            this.editgroupBox.Location = new System.Drawing.Point(1031, 3);
            this.editgroupBox.Name = "editgroupBox";
            this.editgroupBox.Size = new System.Drawing.Size(562, 188);
            this.editgroupBox.TabIndex = 10;
            this.editgroupBox.TabStop = false;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(96, 104);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(159, 47);
            this.deletebutton.TabIndex = 19;
            this.deletebutton.Text = "삭제";
            this.deletebutton.UseVisualStyleBackColor = true;
            // 
            // modifybutton
            // 
            this.modifybutton.Location = new System.Drawing.Point(96, 32);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(159, 47);
            this.modifybutton.TabIndex = 18;
            this.modifybutton.Text = "수정";
            this.modifybutton.UseVisualStyleBackColor = true;
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(322, 105);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(159, 47);
            this.resetbutton.TabIndex = 17;
            this.resetbutton.Text = "초기화";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(322, 33);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(159, 47);
            this.searchbutton.TabIndex = 16;
            this.searchbutton.Text = "검색";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // lectureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editgroupBox);
            this.Controls.Add(this.searchgroupBox);
            this.Controls.Add(this.lectureGridView);
            this.Name = "lectureControl";
            this.Size = new System.Drawing.Size(1700, 1000);
            this.searchgroupBox.ResumeLayout(false);
            this.searchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            this.editgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox professortextBox;
        private System.Windows.Forms.Label professorlabel;
        private System.Windows.Forms.ComboBox choicecomboBox;
        private System.Windows.Forms.Label Completionlabel;
        private System.Windows.Forms.TextBox subjecttextBox;
        private System.Windows.Forms.TextBox numbertextBox;
        private System.Windows.Forms.Label subjectlabel;
        private System.Windows.Forms.Label numberlabel;
        private System.Windows.Forms.DataGridView lectureGridView;
        private System.Windows.Forms.GroupBox searchgroupBox;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Placelabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Capacitylabel;
        private System.Windows.Forms.Label Creditlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox editgroupBox;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button modifybutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button searchbutton;
    }
}
