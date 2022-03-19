
namespace Lab01
{
    partial class Lab01_Bai06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lstScore = new System.Windows.Forms.ListBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMaxMin = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtMaxMin = new System.Windows.Forms.TextBox();
            this.lblPassCount = new System.Windows.Forms.Label();
            this.lblFailCount = new System.Windows.Forms.Label();
            this.txtPassCount = new System.Windows.Forms.TextBox();
            this.txtFailCount = new System.Windows.Forms.TextBox();
            this.lblRanked = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XỬ LÝ MẢNG VÀ TỔNG HỢP";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 70);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(305, 23);
            this.txtInput.TabIndex = 16;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInput.Location = new System.Drawing.Point(12, 47);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(171, 20);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Nhập điểm của sinh viên";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 99);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Nhập";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lstScore
            // 
            this.lstScore.FormattingEnabled = true;
            this.lstScore.ItemHeight = 15;
            this.lstScore.Location = new System.Drawing.Point(12, 143);
            this.lstScore.Name = "lstScore";
            this.lstScore.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstScore.Size = new System.Drawing.Size(306, 64);
            this.lstScore.TabIndex = 4;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 125);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(92, 15);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Danh sách điểm";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 214);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(94, 15);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Điểm trung bình";
            // 
            // lblMaxMin
            // 
            this.lblMaxMin.AutoSize = true;
            this.lblMaxMin.Location = new System.Drawing.Point(129, 214);
            this.lblMaxMin.Name = "lblMaxMin";
            this.lblMaxMin.Size = new System.Drawing.Size(168, 15);
            this.lblMaxMin.TabIndex = 7;
            this.lblMaxMin.Text = "Điểm môn cao nhất/thấp nhất";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(13, 233);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(91, 23);
            this.txtAverage.TabIndex = 8;
            // 
            // txtMaxMin
            // 
            this.txtMaxMin.Location = new System.Drawing.Point(129, 233);
            this.txtMaxMin.Name = "txtMaxMin";
            this.txtMaxMin.ReadOnly = true;
            this.txtMaxMin.Size = new System.Drawing.Size(168, 23);
            this.txtMaxMin.TabIndex = 9;
            // 
            // lblPassCount
            // 
            this.lblPassCount.AutoSize = true;
            this.lblPassCount.Location = new System.Drawing.Point(12, 270);
            this.lblPassCount.Name = "lblPassCount";
            this.lblPassCount.Size = new System.Drawing.Size(71, 15);
            this.lblPassCount.TabIndex = 10;
            this.lblPassCount.Text = "Số môn đậu";
            // 
            // lblFailCount
            // 
            this.lblFailCount.AutoSize = true;
            this.lblFailCount.Location = new System.Drawing.Point(129, 270);
            this.lblFailCount.Name = "lblFailCount";
            this.lblFailCount.Size = new System.Drawing.Size(66, 15);
            this.lblFailCount.TabIndex = 11;
            this.lblFailCount.Text = "Số môn rớt";
            // 
            // txtPassCount
            // 
            this.txtPassCount.Location = new System.Drawing.Point(12, 288);
            this.txtPassCount.Name = "txtPassCount";
            this.txtPassCount.ReadOnly = true;
            this.txtPassCount.Size = new System.Drawing.Size(92, 23);
            this.txtPassCount.TabIndex = 12;
            // 
            // txtFailCount
            // 
            this.txtFailCount.Location = new System.Drawing.Point(129, 288);
            this.txtFailCount.Name = "txtFailCount";
            this.txtFailCount.ReadOnly = true;
            this.txtFailCount.Size = new System.Drawing.Size(92, 23);
            this.txtFailCount.TabIndex = 13;
            // 
            // lblRanked
            // 
            this.lblRanked.AutoSize = true;
            this.lblRanked.Location = new System.Drawing.Point(13, 335);
            this.lblRanked.Name = "lblRanked";
            this.lblRanked.Size = new System.Drawing.Size(49, 15);
            this.lblRanked.TabIndex = 14;
            this.lblRanked.Text = "Xếp loại";
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(68, 332);
            this.txtRank.Name = "txtRank";
            this.txtRank.ReadOnly = true;
            this.txtRank.Size = new System.Drawing.Size(153, 23);
            this.txtRank.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Lab01_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 368);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.lblRanked);
            this.Controls.Add(this.txtFailCount);
            this.Controls.Add(this.txtPassCount);
            this.Controls.Add(this.lblFailCount);
            this.Controls.Add(this.lblPassCount);
            this.Controls.Add(this.txtMaxMin);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lblMaxMin);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "Lab01_Bai06";
            this.Text = "Lab01_Bai06";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ListBox lstScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMaxMin;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtMaxMin;
        private System.Windows.Forms.Label lblPassCount;
        private System.Windows.Forms.Label lblFailCount;
        private System.Windows.Forms.TextBox txtPassCount;
        private System.Windows.Forms.TextBox txtFailCount;
        private System.Windows.Forms.Label lblRanked;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}