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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.studentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filterColum = new System.Windows.Forms.ComboBox();
            this.filterValue = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grade2Box = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.grade1Box = new System.Windows.Forms.ComboBox();
            this.studentIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.studentInfoGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(17, 231);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 48);
            this.deleteButton.TabIndex = 56;
            this.deleteButton.Text = "삭 제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(17, 175);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(119, 48);
            this.editButton.TabIndex = 55;
            this.editButton.Text = "수 정";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(17, 119);
            this.createButton.Margin = new System.Windows.Forms.Padding(4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(119, 48);
            this.createButton.TabIndex = 54;
            this.createButton.Text = "등 록";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AllowUserToResizeRows = false;
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.departmentColum,
            this.nameColum,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.gradeColum,
            this.phoneNumberColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressColum});
            this.tableLayoutPanel1.SetColumnSpan(this.studentDataGridView, 2);
            this.studentDataGridView.DataSource = this.studentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDataGridView.Location = new System.Drawing.Point(4, 308);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.RowHeadersVisible = false;
            this.studentDataGridView.RowHeadersWidth = 72;
            this.studentDataGridView.RowTemplate.Height = 28;
            this.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDataGridView.Size = new System.Drawing.Size(1735, 817);
            this.studentDataGridView.TabIndex = 53;
            this.studentDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_RowEnter);
            // 
            // studentInfoGroupBox
            // 
            this.studentInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentInfoGroupBox.AutoSize = true;
            this.studentInfoGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentInfoGroupBox.Controls.Add(this.resetButton);
            this.studentInfoGroupBox.Controls.Add(this.button1);
            this.studentInfoGroupBox.Controls.Add(this.filterColum);
            this.studentInfoGroupBox.Controls.Add(this.filterValue);
            this.studentInfoGroupBox.Controls.Add(this.emailBox);
            this.studentInfoGroupBox.Controls.Add(this.label8);
            this.studentInfoGroupBox.Controls.Add(this.phoneNumberBox);
            this.studentInfoGroupBox.Controls.Add(this.label7);
            this.studentInfoGroupBox.Controls.Add(this.label6);
            this.studentInfoGroupBox.Controls.Add(this.birthdayDateTimePicker);
            this.studentInfoGroupBox.Controls.Add(this.grade2Box);
            this.studentInfoGroupBox.Controls.Add(this.radioButton1);
            this.studentInfoGroupBox.Controls.Add(this.departmentBox);
            this.studentInfoGroupBox.Controls.Add(this.radioButton2);
            this.studentInfoGroupBox.Controls.Add(this.nameBox);
            this.studentInfoGroupBox.Controls.Add(this.grade1Box);
            this.studentInfoGroupBox.Controls.Add(this.studentIDBox);
            this.studentInfoGroupBox.Controls.Add(this.label4);
            this.studentInfoGroupBox.Controls.Add(this.label5);
            this.studentInfoGroupBox.Controls.Add(this.label3);
            this.studentInfoGroupBox.Controls.Add(this.addressBox);
            this.studentInfoGroupBox.Controls.Add(this.label2);
            this.studentInfoGroupBox.Controls.Add(this.label1);
            this.studentInfoGroupBox.Location = new System.Drawing.Point(4, 4);
            this.studentInfoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentInfoGroupBox.Name = "studentInfoGroupBox";
            this.studentInfoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.studentInfoGroupBox.Size = new System.Drawing.Size(1032, 296);
            this.studentInfoGroupBox.TabIndex = 57;
            this.studentInfoGroupBox.TabStop = false;
            this.studentInfoGroupBox.Text = "학생 정보";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resetButton.Location = new System.Drawing.Point(928, 229);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 38);
            this.resetButton.TabIndex = 71;
            this.resetButton.Text = "리셋";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(805, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 69;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterColum
            // 
            this.filterColum.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Grade", true));
            this.filterColum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.filterColum.FormattingEnabled = true;
            this.filterColum.Items.AddRange(new object[] {
            "이름",
            "학번",
            "이메일",
            "주소"});
            this.filterColum.Location = new System.Drawing.Point(10, 235);
            this.filterColum.Margin = new System.Windows.Forms.Padding(4);
            this.filterColum.Name = "filterColum";
            this.filterColum.Size = new System.Drawing.Size(114, 32);
            this.filterColum.TabIndex = 70;
            // 
            // filterValue
            // 
            this.filterValue.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.filterValue.Location = new System.Drawing.Point(144, 232);
            this.filterValue.Margin = new System.Windows.Forms.Padding(4);
            this.filterValue.Name = "filterValue";
            this.filterValue.Size = new System.Drawing.Size(653, 35);
            this.filterValue.TabIndex = 69;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.emailBox.Location = new System.Drawing.Point(665, 152);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(287, 35);
            this.emailBox.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(567, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 65;
            this.label8.Text = " 이메일";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneNumberBox.Location = new System.Drawing.Point(374, 95);
            this.phoneNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberBox.Mask = "000-9000-0000";
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(183, 35);
            this.phoneNumberBox.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(276, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = " 연락처";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(576, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "생년월일";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(690, 99);
            this.birthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(293, 35);
            this.birthdayDateTimePicker.TabIndex = 61;
            this.birthdayDateTimePicker.Value = new System.DateTime(2024, 11, 10, 21, 45, 29, 0);
            // 
            // grade2Box
            // 
            this.grade2Box.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade2Box.FormattingEnabled = true;
            this.grade2Box.Items.AddRange(new object[] {
            " 1",
            " 2"});
            this.grade2Box.Location = new System.Drawing.Point(786, 42);
            this.grade2Box.Margin = new System.Windows.Forms.Padding(4);
            this.grade2Box.Name = "grade2Box";
            this.grade2Box.Size = new System.Drawing.Size(93, 32);
            this.grade2Box.TabIndex = 60;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(900, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 28);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "재학";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // departmentBox
            // 
            this.departmentBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.departmentBox.Location = new System.Drawing.Point(72, 36);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(4);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(321, 35);
            this.departmentBox.TabIndex = 54;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(900, 59);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 28);
            this.radioButton2.TabIndex = 59;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "휴학";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameBox.Location = new System.Drawing.Point(72, 87);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(186, 35);
            this.nameBox.TabIndex = 52;
            // 
            // grade1Box
            // 
            this.grade1Box.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Grade", true));
            this.grade1Box.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade1Box.FormattingEnabled = true;
            this.grade1Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.grade1Box.Location = new System.Drawing.Point(690, 44);
            this.grade1Box.Margin = new System.Windows.Forms.Padding(4);
            this.grade1Box.Name = "grade1Box";
            this.grade1Box.Size = new System.Drawing.Size(88, 32);
            this.grade1Box.TabIndex = 57;
            // 
            // studentIDBox
            // 
            this.studentIDBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentIDBox.Location = new System.Drawing.Point(492, 39);
            this.studentIDBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentIDBox.Name = "studentIDBox";
            this.studentIDBox.Size = new System.Drawing.Size(87, 35);
            this.studentIDBox.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "주소";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(613, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "학년";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "학과";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addressBox.Location = new System.Drawing.Point(72, 141);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(464, 35);
            this.addressBox.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(426, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "학번";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1040F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.studentDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.studentInfoGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1743, 1129);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.modeLabel);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Location = new System.Drawing.Point(1490, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 297);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modeLabel.Location = new System.Drawing.Point(22, 24);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(175, 64);
            this.modeLabel.TabIndex = 68;
            this.modeLabel.Text = "현재 모드: \r\n읽기";
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "학번";
            this.StudentID.MinimumWidth = 100;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 140;
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
            this.nameColum.MinimumWidth = 70;
            this.nameColum.Name = "nameColum";
            this.nameColum.ReadOnly = true;
            this.nameColum.Width = 120;
            // 
            // gradeColum
            // 
            this.gradeColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gradeColum.DataPropertyName = "Grade";
            this.gradeColum.HeaderText = "학년";
            this.gradeColum.MinimumWidth = 20;
            this.gradeColum.Name = "gradeColum";
            this.gradeColum.ReadOnly = true;
            this.gradeColum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gradeColum.Width = 80;
            // 
            // addressColum
            // 
            this.addressColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressColum.DataPropertyName = "Address";
            this.addressColum.HeaderText = "주소";
            this.addressColum.MinimumWidth = 60;
            this.addressColum.Name = "addressColum";
            this.addressColum.ReadOnly = true;
            this.addressColum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 135;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneNumberColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberColumn.HeaderText = "PhoneNumber";
            this.phoneNumberColumn.MinimumWidth = 60;
            this.phoneNumberColumn.Name = "phoneNumberColumn";
            this.phoneNumberColumn.ReadOnly = true;
            this.phoneNumberColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.phoneNumberColumn.Width = 165;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.emailDataGridViewTextBoxColumn.Width = 180;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(pr3.Student);
            // 
            // StudentControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(1743, 1129);
            this.Load += new System.EventHandler(this.StudentControl_Load);
            this.Resize += new System.EventHandler(this.StudentControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.studentInfoGroupBox.ResumeLayout(false);
            this.studentInfoGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.GroupBox studentInfoGroupBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox phoneNumberBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.ComboBox grade2Box;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox grade1Box;
        private System.Windows.Forms.TextBox studentIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.TextBox filterValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox filterColum;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColum;
    }
}
