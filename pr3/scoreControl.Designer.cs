namespace pr3
{
    partial class ScoreControl
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
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.btnDeleteScore = new System.Windows.Forms.Button();
            this.btnUpdateScore = new System.Windows.Forms.Button();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtFinalTerm = new System.Windows.Forms.TextBox();
            this.txtMidTerm = new System.Windows.Forms.TextBox();
            this.lblFinalTerm = new System.Windows.Forms.Label();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(219, 573);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(103, 42);
            this.btnCalculateAverage.TabIndex = 31;
            this.btnCalculateAverage.Text = "평균계산";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(117, 516);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(205, 32);
            this.txtAverage.TabIndex = 29;
            // 
            // dgvScores
            // 
            this.dgvScores.AutoGenerateColumns = false;
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.enrollmentIdDataGridViewTextBoxColumn,
            this.enrollmentDataGridViewTextBoxColumn,
            this.lectureIdDataGridViewTextBoxColumn,
            this.lectureDataGridViewTextBoxColumn,
            this.midTermDataGridViewTextBoxColumn,
            this.finalTermDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn});
            this.dgvScores.DataSource = this.registrationBindingSource;
            this.dgvScores.Location = new System.Drawing.Point(389, 21);
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.RowHeadersWidth = 51;
            this.dgvScores.RowTemplate.Height = 24;
            this.dgvScores.Size = new System.Drawing.Size(883, 300);
            this.dgvScores.TabIndex = 30;
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 21;
            this.lstScores.Location = new System.Drawing.Point(19, 325);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(328, 172);
            this.lstScores.TabIndex = 27;
            // 
            // btnDeleteScore
            // 
            this.btnDeleteScore.Location = new System.Drawing.Point(248, 255);
            this.btnDeleteScore.Name = "btnDeleteScore";
            this.btnDeleteScore.Size = new System.Drawing.Size(103, 42);
            this.btnDeleteScore.TabIndex = 26;
            this.btnDeleteScore.Text = "삭제";
            this.btnDeleteScore.UseVisualStyleBackColor = true;
            this.btnDeleteScore.Click += new System.EventHandler(this.btnDeleteScore_Click);
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Location = new System.Drawing.Point(135, 255);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(103, 42);
            this.btnUpdateScore.TabIndex = 25;
            this.btnUpdateScore.Text = "수정";
            this.btnUpdateScore.UseVisualStyleBackColor = true;
            this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(3, 255);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(103, 42);
            this.btnAddScore.TabIndex = 24;
            this.btnAddScore.Text = "추가";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(146, 224);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(150, 32);
            this.txtAttendance.TabIndex = 23;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(146, 111);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(205, 32);
            this.txtSubject.TabIndex = 21;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(146, 66);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(205, 32);
            this.txtStudentName.TabIndex = 19;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(146, 21);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(205, 32);
            this.txtStudentId.TabIndex = 17;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(15, 527);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(52, 21);
            this.lblAverage.TabIndex = 28;
            this.lblAverage.Text = "평균";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Location = new System.Drawing.Point(20, 114);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(59, 21);
            this.lblAttendance.TabIndex = 22;
            this.lblAttendance.Text = "출석:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(28, 115);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 21);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "과목:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(28, 70);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(59, 21);
            this.lblStudentName.TabIndex = 18;
            this.lblStudentName.Text = "이름:";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(28, 25);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(94, 21);
            this.lblStudentId.TabIndex = 16;
            this.lblStudentId.Text = "학번 (ID):";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // txtFinalTerm
            // 
            this.txtFinalTerm.Location = new System.Drawing.Point(146, 186);
            this.txtFinalTerm.Name = "txtFinalTerm";
            this.txtFinalTerm.Size = new System.Drawing.Size(150, 32);
            this.txtFinalTerm.TabIndex = 35;
            // 
            // txtMidTerm
            // 
            this.txtMidTerm.Location = new System.Drawing.Point(146, 148);
            this.txtMidTerm.Name = "txtMidTerm";
            this.txtMidTerm.Size = new System.Drawing.Size(150, 32);
            this.txtMidTerm.TabIndex = 33;
            // 
            // lblFinalTerm
            // 
            this.lblFinalTerm.AutoSize = true;
            this.lblFinalTerm.Location = new System.Drawing.Point(20, 180);
            this.lblFinalTerm.Name = "lblFinalTerm";
            this.lblFinalTerm.Size = new System.Drawing.Size(108, 21);
            this.lblFinalTerm.TabIndex = 34;
            this.lblFinalTerm.Text = "기말 고사:";
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Location = new System.Drawing.Point(20, 149);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(108, 21);
            this.lblMidTerm.TabIndex = 32;
            this.lblMidTerm.Text = "중간 고사:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1157, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 379);
            this.panel1.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // enrollmentIdDataGridViewTextBoxColumn
            // 
            this.enrollmentIdDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentId";
            this.enrollmentIdDataGridViewTextBoxColumn.HeaderText = "EnrollmentId";
            this.enrollmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enrollmentIdDataGridViewTextBoxColumn.Name = "enrollmentIdDataGridViewTextBoxColumn";
            this.enrollmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // enrollmentDataGridViewTextBoxColumn
            // 
            this.enrollmentDataGridViewTextBoxColumn.DataPropertyName = "Enrollment";
            this.enrollmentDataGridViewTextBoxColumn.HeaderText = "Enrollment";
            this.enrollmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enrollmentDataGridViewTextBoxColumn.Name = "enrollmentDataGridViewTextBoxColumn";
            this.enrollmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // lectureIdDataGridViewTextBoxColumn
            // 
            this.lectureIdDataGridViewTextBoxColumn.DataPropertyName = "LectureId";
            this.lectureIdDataGridViewTextBoxColumn.HeaderText = "LectureId";
            this.lectureIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureIdDataGridViewTextBoxColumn.Name = "lectureIdDataGridViewTextBoxColumn";
            this.lectureIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lectureDataGridViewTextBoxColumn
            // 
            this.lectureDataGridViewTextBoxColumn.DataPropertyName = "Lecture";
            this.lectureDataGridViewTextBoxColumn.HeaderText = "Lecture";
            this.lectureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureDataGridViewTextBoxColumn.Name = "lectureDataGridViewTextBoxColumn";
            this.lectureDataGridViewTextBoxColumn.Width = 125;
            // 
            // midTermDataGridViewTextBoxColumn
            // 
            this.midTermDataGridViewTextBoxColumn.DataPropertyName = "MidTerm";
            this.midTermDataGridViewTextBoxColumn.HeaderText = "MidTerm";
            this.midTermDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midTermDataGridViewTextBoxColumn.Name = "midTermDataGridViewTextBoxColumn";
            this.midTermDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalTermDataGridViewTextBoxColumn
            // 
            this.finalTermDataGridViewTextBoxColumn.DataPropertyName = "FinalTerm";
            this.finalTermDataGridViewTextBoxColumn.HeaderText = "FinalTerm";
            this.finalTermDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalTermDataGridViewTextBoxColumn.Name = "finalTermDataGridViewTextBoxColumn";
            this.finalTermDataGridViewTextBoxColumn.Width = 125;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataSource = typeof(pr3.Registration);
            // 
            // ScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFinalTerm);
            this.Controls.Add(this.txtMidTerm);
            this.Controls.Add(this.lblFinalTerm);
            this.Controls.Add(this.lblMidTerm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.dgvScores);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.btnDeleteScore);
            this.Controls.Add(this.btnUpdateScore);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScoreControl";
            this.Size = new System.Drawing.Size(1605, 771);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Button btnDeleteScore;
        private System.Windows.Forms.Button btnUpdateScore;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtFinalTerm;
        private System.Windows.Forms.TextBox txtMidTerm;
        private System.Windows.Forms.Label lblFinalTerm;
        private System.Windows.Forms.Label lblMidTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}
