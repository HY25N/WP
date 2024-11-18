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
            this.splitter1 = new System.Windows.Forms.Splitter();
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
            this.sidebar.Location = new System.Drawing.Point(4, 4);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(244, 707);
            this.sidebar.TabIndex = 52;
            // 
            // scorebutton
            // 
            this.scorebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scorebutton.Font = new System.Drawing.Font("바탕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scorebutton.Location = new System.Drawing.Point(14, 210);
            this.scorebutton.Name = "scorebutton";
            this.scorebutton.Size = new System.Drawing.Size(215, 49);
            this.scorebutton.TabIndex = 2;
            this.scorebutton.Text = "성적관리";
            this.scorebutton.Click += new System.EventHandler(this.scorebutton_Click);
            // 
            // lectureButton
            // 
            this.lectureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lectureButton.Font = new System.Drawing.Font("바탕체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lectureButton.Location = new System.Drawing.Point(14, 120);
            this.lectureButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lectureButton.Name = "lectureButton";
            this.lectureButton.Size = new System.Drawing.Size(215, 49);
            this.lectureButton.TabIndex = 1;
            this.lectureButton.Text = "강의관리";
            this.lectureButton.Click += new System.EventHandler(this.lectureButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentButton.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentButton.Location = new System.Drawing.Point(14, 30);
            this.studentButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(215, 49);
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
            this.viewPanel.Location = new System.Drawing.Point(262, 11);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1688, 693);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1960, 42);
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
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(108, 36);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(323, 44);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            // 
            // 데이터불러오기ToolStripMenuItem
            // 
            this.데이터불러오기ToolStripMenuItem.Name = "데이터불러오기ToolStripMenuItem";
            this.데이터불러오기ToolStripMenuItem.Size = new System.Drawing.Size(323, 44);
            this.데이터불러오기ToolStripMenuItem.Text = "데이터 불러오기";
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계정수정미구현ToolStripMenuItem,
            this.데이터백업ToolStripMenuItem});
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.rToolStripMenuItem.Text = "관리(&M)";
            // 
            // 계정수정미구현ToolStripMenuItem
            // 
            this.계정수정미구현ToolStripMenuItem.Name = "계정수정미구현ToolStripMenuItem";
            this.계정수정미구현ToolStripMenuItem.Size = new System.Drawing.Size(337, 44);
            this.계정수정미구현ToolStripMenuItem.Text = "계정 수정(미구현)";
            // 
            // 데이터백업ToolStripMenuItem
            // 
            this.데이터백업ToolStripMenuItem.Name = "데이터백업ToolStripMenuItem";
            this.데이터백업ToolStripMenuItem.Size = new System.Drawing.Size(337, 44);
            this.데이터백업ToolStripMenuItem.Text = "데이터 백업";
            // 
            // rToolStripMenuItem2
            // 
            this.rToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기VToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem});
            this.rToolStripMenuItem2.Name = "rToolStripMenuItem2";
            this.rToolStripMenuItem2.Size = new System.Drawing.Size(137, 36);
            this.rToolStripMenuItem2.Text = "도움말(&H)";
            this.rToolStripMenuItem2.Click += new System.EventHandler(this.rToolStripMenuItem2_Click);
            // 
            // 도움말보기VToolStripMenuItem
            // 
            this.도움말보기VToolStripMenuItem.Name = "도움말보기VToolStripMenuItem";
            this.도움말보기VToolStripMenuItem.Size = new System.Drawing.Size(328, 44);
            this.도움말보기VToolStripMenuItem.Text = "도움말 보기(&V)";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(328, 44);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보(&V)";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1960, 715);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // rToolStripMenuItem1
            // 
            this.rToolStripMenuItem1.Name = "rToolStripMenuItem1";
            this.rToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.rToolStripMenuItem1.Text = "r";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 707);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1960, 757);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1531, 787);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
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
    }
}

