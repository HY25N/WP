namespace pr3
{
    partial class StudentControl
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.studentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.studentInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(24, 260);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 48);
            this.deleteButton.TabIndex = 56;
            this.deleteButton.Text = "삭 제";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(24, 157);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(200, 48);
            this.editButton.TabIndex = 55;
            this.editButton.Text = "수 정";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(24, 65);
            this.createButton.Margin = new System.Windows.Forms.Padding(4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(200, 48);
            this.createButton.TabIndex = 54;
            this.createButton.Text = "등 록";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToResizeRows = false;
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.departmentColum,
            this.nameColum,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.gradeColum,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressColum});
            this.tableLayoutPanel1.SetColumnSpan(this.studentDataGridView, 2);
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDataGridView.Location = new System.Drawing.Point(4, 398);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersVisible = false;
            this.studentDataGridView.RowHeadersWidth = 72;
            this.studentDataGridView.RowTemplate.Height = 23;
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(1806, 640);
            this.studentDataGridView.TabIndex = 53;
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // studentInfoGroupBox
            // 
            this.studentInfoGroupBox.Controls.Add(this.textBox5);
            this.studentInfoGroupBox.Controls.Add(this.label8);
            this.studentInfoGroupBox.Controls.Add(this.maskedTextBox1);
            this.studentInfoGroupBox.Controls.Add(this.label7);
            this.studentInfoGroupBox.Controls.Add(this.label6);
            this.studentInfoGroupBox.Controls.Add(this.dateTimePicker1);
            this.studentInfoGroupBox.Controls.Add(this.comboBox2);
            this.studentInfoGroupBox.Controls.Add(this.radioButton1);
            this.studentInfoGroupBox.Controls.Add(this.textBox4);
            this.studentInfoGroupBox.Controls.Add(this.radioButton2);
            this.studentInfoGroupBox.Controls.Add(this.textBox2);
            this.studentInfoGroupBox.Controls.Add(this.comboBox1);
            this.studentInfoGroupBox.Controls.Add(this.textBox1);
            this.studentInfoGroupBox.Controls.Add(this.label4);
            this.studentInfoGroupBox.Controls.Add(this.label5);
            this.studentInfoGroupBox.Controls.Add(this.label3);
            this.studentInfoGroupBox.Controls.Add(this.textBox3);
            this.studentInfoGroupBox.Controls.Add(this.label2);
            this.studentInfoGroupBox.Controls.Add(this.label1);
            this.studentInfoGroupBox.Location = new System.Drawing.Point(4, 4);
            this.studentInfoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentInfoGroupBox.Name = "studentInfoGroupBox";
            this.studentInfoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.studentInfoGroupBox.Size = new System.Drawing.Size(1506, 318);
            this.studentInfoGroupBox.TabIndex = 57;
            this.studentInfoGroupBox.TabStop = false;
            this.studentInfoGroupBox.Text = "학생 정보";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(704, 122);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(237, 28);
            this.textBox5.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = " 이메일";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(704, 76);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "000-9000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(141, 28);
            this.maskedTextBox1.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = " 연락처";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "생년월일";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(704, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 28);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            " 1 학기",
            " 2 학기"});
            this.comboBox2.Location = new System.Drawing.Point(159, 122);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 26);
            this.comboBox2.TabIndex = 60;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(261, 126);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 22);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "재학";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 34);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 28);
            this.textBox4.TabIndex = 54;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(337, 126);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 22);
            this.radioButton2.TabIndex = 59;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "휴학";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(531, 34);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 28);
            this.textBox2.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(59, 122);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 26);
            this.comboBox1.TabIndex = 57;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 28);
            this.textBox1.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "주소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "학년";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "학과";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 78);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(551, 28);
            this.textBox3.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "학번";
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "학번";
            this.StudentID.MinimumWidth = 9;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 175;
            // 
            // departmentColum
            // 
            this.departmentColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.departmentColum.DataPropertyName = "Department";
            this.departmentColum.HeaderText = "학과";
            this.departmentColum.MinimumWidth = 150;
            this.departmentColum.Name = "departmentColum";
            this.departmentColum.ReadOnly = true;
            this.departmentColum.Width = 280;
            // 
            // nameColum
            // 
            this.nameColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameColum.DataPropertyName = "Name";
            this.nameColum.HeaderText = "이름";
            this.nameColum.MinimumWidth = 9;
            this.nameColum.Name = "nameColum";
            this.nameColum.Width = 150;
            // 
            // gradeColum
            // 
            this.gradeColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gradeColum.DataPropertyName = "Grade";
            this.gradeColum.HeaderText = "학년";
            this.gradeColum.MinimumWidth = 9;
            this.gradeColum.Name = "gradeColum";
            this.gradeColum.ReadOnly = true;
            this.gradeColum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gradeColum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gradeColum.Width = 60;
            // 
            // addressColum
            // 
            this.addressColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.addressColum.DataPropertyName = "Address";
            this.addressColum.HeaderText = "주소";
            this.addressColum.MinimumWidth = 9;
            this.addressColum.Name = "addressColum";
            this.addressColum.ReadOnly = true;
            this.addressColum.Width = 400;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 133;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 159;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 86;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(pr3.Student);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.studentDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.studentInfoGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1814, 1042);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Location = new System.Drawing.Point(1575, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 388);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // StudentControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(1814, 1042);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.studentInfoGroupBox.ResumeLayout(false);
            this.studentInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.GroupBox studentInfoGroupBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColum;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
