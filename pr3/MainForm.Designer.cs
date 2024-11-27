namespace pr3
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.scorebutton = new System.Windows.Forms.Label();
            this.lectureButton = new System.Windows.Forms.Label();
            this.studentButton = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.파일불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계정수정미구현ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.데이터백업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.splitter1);
            this.sidebar.Controls.Add(this.scorebutton);
            this.sidebar.Controls.Add(this.lectureButton);
            this.sidebar.Controls.Add(this.studentButton);
            this.sidebar.Location = new System.Drawing.Point(3, 4);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(206, 775);
            this.sidebar.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 2);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 2);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 2);
            this.panel1.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 775);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // scorebutton
            // 
            this.scorebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scorebutton.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scorebutton.Location = new System.Drawing.Point(12, 192);
            this.scorebutton.Name = "scorebutton";
            this.scorebutton.Size = new System.Drawing.Size(182, 43);
            this.scorebutton.TabIndex = 2;
            this.scorebutton.Text = "성적관리";
            this.scorebutton.Click += new System.EventHandler(this.scorebutton_Click);
            // 
            // lectureButton
            // 
            this.lectureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lectureButton.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lectureButton.Location = new System.Drawing.Point(12, 109);
            this.lectureButton.Name = "lectureButton";
            this.lectureButton.Size = new System.Drawing.Size(182, 43);
            this.lectureButton.TabIndex = 1;
            this.lectureButton.Text = "강의관리";
            this.lectureButton.Click += new System.EventHandler(this.lectureButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentButton.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentButton.Location = new System.Drawing.Point(12, 24);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(182, 43);
            this.studentButton.TabIndex = 0;
            this.studentButton.Text = "학생관리";
            this.studentButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.AutoScroll = true;
            this.viewPanel.AutoSize = true;
            this.viewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewPanel.BackColor = System.Drawing.Color.DarkGray;
            this.viewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewPanel.Location = new System.Drawing.Point(220, 10);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1573, 763);
            this.viewPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.관리ToolStripMenuItem,
            this.도움말ToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1801, 40);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.파일불러오기ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.끝내기XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(95, 34);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(289, 6);
            // 
            // 파일불러오기ToolStripMenuItem
            // 
            this.파일불러오기ToolStripMenuItem.Name = "파일불러오기ToolStripMenuItem";
            this.파일불러오기ToolStripMenuItem.Size = new System.Drawing.Size(292, 40);
            this.파일불러오기ToolStripMenuItem.Text = "파일 불러오기(&O)";
            this.파일불러오기ToolStripMenuItem.Click += new System.EventHandler(this.파일불러오기ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(289, 6);
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(292, 40);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            this.끝내기XToolStripMenuItem.Click += new System.EventHandler(this.끝내기XToolStripMenuItem_Click);
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계정수정미구현ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.데이터백업ToolStripMenuItem});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(104, 34);
            this.관리ToolStripMenuItem.Text = "관리(&M)";
            // 
            // 계정수정미구현ToolStripMenuItem
            // 
            this.계정수정미구현ToolStripMenuItem.Name = "계정수정미구현ToolStripMenuItem";
            this.계정수정미구현ToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.계정수정미구현ToolStripMenuItem.Text = "비밀번호 변경";
            this.계정수정미구현ToolStripMenuItem.Click += new System.EventHandler(this.비밀번호변경ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(263, 6);
            // 
            // 데이터백업ToolStripMenuItem
            // 
            this.데이터백업ToolStripMenuItem.Name = "데이터백업ToolStripMenuItem";
            this.데이터백업ToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.데이터백업ToolStripMenuItem.Text = "데이터 백업&(S)";
            this.데이터백업ToolStripMenuItem.Click += new System.EventHandler(this.데이터백업ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem2
            // 
            this.도움말ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.프로그램정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem2.Name = "도움말ToolStripMenuItem2";
            this.도움말ToolStripMenuItem2.Size = new System.Drawing.Size(121, 34);
            this.도움말ToolStripMenuItem2.Text = "도움말(&H)";
            // 
            // 도움말보기ToolStripMenuItem
            // 
            this.도움말보기ToolStripMenuItem.Name = "도움말보기ToolStripMenuItem";
            this.도움말보기ToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.도움말보기ToolStripMenuItem.Text = "도움말 보기(&V)";
            this.도움말보기ToolStripMenuItem.Click += new System.EventHandler(this.도움말보기ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(287, 6);
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(290, 40);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보(&A)";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.sidebar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1801, 783);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // rToolStripMenuItem1
            // 
            this.rToolStripMenuItem1.Name = "rToolStripMenuItem1";
            this.rToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.rToolStripMenuItem1.Text = "r";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 823);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1298, 696);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "원광학사관리v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.Label studentButton;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem1;
        private System.Windows.Forms.Label lectureButton;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계정수정미구현ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 데이터백업ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.Label scorebutton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem 파일불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

