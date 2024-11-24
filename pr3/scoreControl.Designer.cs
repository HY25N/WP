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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(182, 363);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(75, 30);
            this.btnCalculateAverage.TabIndex = 31;
            this.btnCalculateAverage.Text = "평균계산";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(106, 330);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(150, 25);
            this.txtAverage.TabIndex = 29;
            // 
            // dgvScores
            // 
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Location = new System.Drawing.Point(266, 15);
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.RowHeadersWidth = 51;
            this.dgvScores.RowTemplate.Height = 24;
            this.dgvScores.Size = new System.Drawing.Size(300, 300);
            this.dgvScores.TabIndex = 30;
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 15;
            this.lstScores.Location = new System.Drawing.Point(20, 185);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(240, 124);
            this.lstScores.TabIndex = 27;
            // 
            // btnDeleteScore
            // 
            this.btnDeleteScore.Location = new System.Drawing.Point(182, 149);
            this.btnDeleteScore.Name = "btnDeleteScore";
            this.btnDeleteScore.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteScore.TabIndex = 26;
            this.btnDeleteScore.Text = "삭제";
            this.btnDeleteScore.UseVisualStyleBackColor = true;
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Location = new System.Drawing.Point(101, 149);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateScore.TabIndex = 25;
            this.btnUpdateScore.Text = "수정";
            this.btnUpdateScore.UseVisualStyleBackColor = true;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(20, 149);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(75, 30);
            this.btnAddScore.TabIndex = 24;
            this.btnAddScore.Text = "추가";
            this.btnAddScore.UseVisualStyleBackColor = true;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(106, 111);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(150, 25);
            this.txtScore.TabIndex = 23;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(106, 79);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(150, 25);
            this.txtSubject.TabIndex = 21;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(106, 47);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(150, 25);
            this.txtStudentName.TabIndex = 19;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(106, 15);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(150, 25);
            this.txtStudentId.TabIndex = 17;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(20, 333);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(37, 15);
            this.lblAverage.TabIndex = 28;
            this.lblAverage.Text = "평균";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(20, 114);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(42, 15);
            this.lblScore.TabIndex = 22;
            this.lblScore.Text = "성적:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(20, 82);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(42, 15);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "과목:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(20, 50);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(42, 15);
            this.lblStudentName.TabIndex = 18;
            this.lblStudentName.Text = "이름:";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(20, 18);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(72, 15);
            this.lblStudentId.TabIndex = 16;
            this.lblStudentId.Text = "학번 (ID):";
            // 
            // scoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.dgvScores);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.btnDeleteScore);
            this.Controls.Add(this.btnUpdateScore);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentId);
            this.Name = "scoreControl";
            this.Size = new System.Drawing.Size(1167, 551);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentId;
    }
}
