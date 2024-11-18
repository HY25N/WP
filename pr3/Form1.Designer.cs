namespace pr3
{
    partial class Form1
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.scorebutton = new System.Windows.Forms.Label();
            this.lectureButton = new System.Windows.Forms.Label();
            this.studentButton = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.데이터불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계정수정미구현ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.데이터백업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말보기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.satisticsLabel = new System.Windows.Forms.Label();
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
            this.sidebar.Controls.Add(this.splitter1);
            this.sidebar.Controls.Add(this.scorebutton);
            this.sidebar.Controls.Add(this.lectureButton);
            this.sidebar.Controls.Add(this.studentButton);
            this.sidebar.Location = new System.Drawing.Point(3, 3);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(188, 529);
            this.sidebar.TabIndex = 52;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 529);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // scorebutton
            // 
            this.scorebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scorebutton.Font = new System.Drawing.Font("바탕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scorebutton.Location = new System.Drawing.Point(11, 158);
            this.scorebutton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scorebutton.Name = "scorebutton";
            this.scorebutton.Size = new System.Drawing.Size(165, 37);
            this.scorebutton.TabIndex = 2;
            this.scorebutton.Text = "성적관리";
            this.scorebutton.Click += new System.EventHandler(this.scorebutton_Click);
            // 
            // lectureButton
            // 
            this.lectureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lectureButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lectureButton.Location = new System.Drawing.Point(27, 98);
            this.lectureButton.Name = "lectureButton";
            this.lectureButton.Size = new System.Drawing.Size(133, 28);
            this.lectureButton.TabIndex = 1;
            this.lectureButton.Text = "강의관리";
            this.lectureButton.Click += new System.EventHandler(this.lectureButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentButton.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentButton.Location = new System.Drawing.Point(11, 22);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(165, 37);
            this.studentButton.TabIndex = 0;
            this.studentButton.Text = "학생관리";
            this.studentButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.AutoSize = true;
            this.viewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewPanel.BackColor = System.Drawing.Color.DarkGray;
            this.viewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewPanel.Location = new System.Drawing.Point(202, 8);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1298, 519);
            this.viewPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.rToolStripMenuItem,
            this.rToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1508, 33);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기XToolStripMenuItem,
            this.데이터불러오기ToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            // 
            // 데이터불러오기ToolStripMenuItem
            // 
            this.데이터불러오기ToolStripMenuItem.Name = "데이터불러오기ToolStripMenuItem";
            this.데이터불러오기ToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.데이터불러오기ToolStripMenuItem.Text = "데이터 불러오기";
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계정수정미구현ToolStripMenuItem,
            this.데이터백업ToolStripMenuItem});
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.rToolStripMenuItem.Text = "관리(&M)";
            // 
            // 계정수정미구현ToolStripMenuItem
            // 
            this.계정수정미구현ToolStripMenuItem.Name = "계정수정미구현ToolStripMenuItem";
            this.계정수정미구현ToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.계정수정미구현ToolStripMenuItem.Text = "계정 수정(미구현)";
            // 
            // 데이터백업ToolStripMenuItem
            // 
            this.데이터백업ToolStripMenuItem.Name = "데이터백업ToolStripMenuItem";
            this.데이터백업ToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.데이터백업ToolStripMenuItem.Text = "데이터 백업";
            // 
            // rToolStripMenuItem2
            // 
            this.rToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기VToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem});
            this.rToolStripMenuItem2.Name = "rToolStripMenuItem2";
            this.rToolStripMenuItem2.Size = new System.Drawing.Size(105, 29);
            this.rToolStripMenuItem2.Text = "도움말(&H)";
            // 
            // 도움말보기VToolStripMenuItem
            // 
            this.도움말보기VToolStripMenuItem.Name = "도움말보기VToolStripMenuItem";
            this.도움말보기VToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.도움말보기VToolStripMenuItem.Text = "도움말 보기(&V)";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보(&V)";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1508, 535);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // rToolStripMenuItem1
            // 
            this.rToolStripMenuItem1.Name = "rToolStripMenuItem1";
            this.rToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.rToolStripMenuItem1.Text = "r";
            // 
            // satisticsLabel
            // 
            this.satisticsLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.satisticsLabel.Location = new System.Drawing.Point(52, 609);
            this.satisticsLabel.Name = "satisticsLabel";
            this.satisticsLabel.Size = new System.Drawing.Size(283, 38);
            this.satisticsLabel.TabIndex = 2;
            this.satisticsLabel.Text = "통계(테스트)";
            this.satisticsLabel.Click += new System.EventHandler(this.satisticsLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1183, 604);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "시스템";
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
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lecturelabel;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem1;
        private System.Windows.Forms.Label lectureButton;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 데이터불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계정수정미구현ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 데이터백업ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말보기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.Label scorebutton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label satisticsLabel;
    }
}

