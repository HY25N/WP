﻿namespace pr3
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
            this.satisticsLabel = new System.Windows.Forms.Label();
            this.lecturelabel = new System.Windows.Forms.Label();
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
            this.rToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lectureButton = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sidebar.Controls.Add(this.satisticsLabel);
            this.sidebar.Controls.Add(this.lecturelabel);
            this.sidebar.Controls.Add(this.studentButton);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(3, 3);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(294, 954);
            this.sidebar.TabIndex = 52;
            // 
            // satisticsLabel
            // 
            this.satisticsLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.satisticsLabel.Location = new System.Drawing.Point(11, 545);
            this.satisticsLabel.Name = "satisticsLabel";
            this.satisticsLabel.Size = new System.Drawing.Size(283, 38);
            this.satisticsLabel.TabIndex = 2;
            this.satisticsLabel.Text = "통계(테스트)";
            this.satisticsLabel.Click += new System.EventHandler(this.StatisticsLabel_Click);
            // 
            // lecturelabel
            // 
            this.lecturelabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lecturelabel.Location = new System.Drawing.Point(19, 216);
            this.lecturelabel.Name = "lecturelabel";
            this.lecturelabel.Size = new System.Drawing.Size(221, 38);
            this.lecturelabel.TabIndex = 1;
            this.lecturelabel.Text = "강의";
            this.lecturelabel.Click += new System.EventHandler(this.lecturelabel_Click);
            // 
            // studentButton
            // 
            this.studentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentButton.Location = new System.Drawing.Point(19, 98);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(241, 56);
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
            this.viewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewPanel.Location = new System.Drawing.Point(309, 9);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(9);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1820, 942);
            this.viewPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.rToolStripMenuItem,
            this.rToolStripMenuItem2,
            this.rToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2138, 42);
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
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(95, 38);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(285, 40);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            // 
            // 데이터불러오기ToolStripMenuItem
            // 
            this.데이터불러오기ToolStripMenuItem.Name = "데이터불러오기ToolStripMenuItem";
            this.데이터불러오기ToolStripMenuItem.Size = new System.Drawing.Size(285, 40);
            this.데이터불러오기ToolStripMenuItem.Text = "데이터 불러오기";
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계정수정미구현ToolStripMenuItem,
            this.데이터백업ToolStripMenuItem});
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(104, 38);
            this.rToolStripMenuItem.Text = "관리(&M)";
            // 
            // 계정수정미구현ToolStripMenuItem
            // 
            this.계정수정미구현ToolStripMenuItem.Name = "계정수정미구현ToolStripMenuItem";
            this.계정수정미구현ToolStripMenuItem.Size = new System.Drawing.Size(297, 40);
            this.계정수정미구현ToolStripMenuItem.Text = "계정 수정(미구현)";
            // 
            // 데이터백업ToolStripMenuItem
            // 
            this.데이터백업ToolStripMenuItem.Name = "데이터백업ToolStripMenuItem";
            this.데이터백업ToolStripMenuItem.Size = new System.Drawing.Size(297, 40);
            this.데이터백업ToolStripMenuItem.Text = "데이터 백업";
            // 
            // rToolStripMenuItem2
            // 
            this.rToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기VToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem});
            this.rToolStripMenuItem2.Name = "rToolStripMenuItem2";
            this.rToolStripMenuItem2.Size = new System.Drawing.Size(121, 38);
            this.rToolStripMenuItem2.Text = "도움말(&H)";
            // 
            // 도움말보기VToolStripMenuItem
            // 
            this.도움말보기VToolStripMenuItem.Name = "도움말보기VToolStripMenuItem";
            this.도움말보기VToolStripMenuItem.Size = new System.Drawing.Size(289, 40);
            this.도움말보기VToolStripMenuItem.Text = "도움말 보기(&V)";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(289, 40);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보(&V)";
            // 
            // rToolStripMenuItem3
            // 
            this.rToolStripMenuItem3.Name = "rToolStripMenuItem3";
            this.rToolStripMenuItem3.Size = new System.Drawing.Size(38, 38);
            this.rToolStripMenuItem3.Text = "r";
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2138, 960);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // rToolStripMenuItem1
            // 
            this.rToolStripMenuItem1.Name = "rToolStripMenuItem1";
            this.rToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.rToolStripMenuItem1.Text = "r";
            // 
            // lectureButton
            // 
            this.lectureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lectureButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lectureButton.Location = new System.Drawing.Point(34, 170);
            this.lectureButton.Name = "lectureButton";
            this.lectureButton.Size = new System.Drawing.Size(173, 37);
            this.lectureButton.TabIndex = 1;
            this.lectureButton.Text = "강의관리";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2138, 1002);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "원광학생관리 v1.0.0";
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
        private System.Windows.Forms.Label satisticsLabel;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem3;
    }
}

