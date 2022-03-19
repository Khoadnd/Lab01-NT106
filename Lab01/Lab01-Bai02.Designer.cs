
namespace Lab01
{
    partial class Lab01_Bai02
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.firstText = new System.Windows.Forms.TextBox();
            this.secondText = new System.Windows.Forms.TextBox();
            this.thirdText = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.maxText = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minText = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(130, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tìm số lớn nhất, nhỏ nhất";
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstLabel.Location = new System.Drawing.Point(31, 44);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(85, 20);
            this.firstLabel.TabIndex = 1;
            this.firstLabel.Text = "Số thứ nhất";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondLabel.Location = new System.Drawing.Point(204, 44);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(76, 20);
            this.secondLabel.TabIndex = 2;
            this.secondLabel.Text = "Số thứ hai";
            // 
            // thirdLabel
            // 
            this.thirdLabel.AutoSize = true;
            this.thirdLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thirdLabel.Location = new System.Drawing.Point(363, 44);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(73, 20);
            this.thirdLabel.TabIndex = 3;
            this.thirdLabel.Text = "Số thứ ba";
            // 
            // firstText
            // 
            this.firstText.Location = new System.Drawing.Point(31, 67);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(85, 23);
            this.firstText.TabIndex = 4;
            // 
            // secondText
            // 
            this.secondText.Location = new System.Drawing.Point(204, 67);
            this.secondText.Name = "secondText";
            this.secondText.Size = new System.Drawing.Size(85, 23);
            this.secondText.TabIndex = 5;
            // 
            // thirdText
            // 
            this.thirdText.Location = new System.Drawing.Point(363, 67);
            this.thirdText.Name = "thirdText";
            this.thirdText.Size = new System.Drawing.Size(85, 23);
            this.thirdText.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Location = new System.Drawing.Point(72, 111);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(191, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(306, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // maxText
            // 
            this.maxText.Location = new System.Drawing.Point(117, 161);
            this.maxText.Name = "maxText";
            this.maxText.ReadOnly = true;
            this.maxText.Size = new System.Drawing.Size(85, 23);
            this.maxText.TabIndex = 11;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxLabel.Location = new System.Drawing.Point(27, 160);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(84, 20);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "Số lớn nhất";
            // 
            // minText
            // 
            this.minText.Location = new System.Drawing.Point(363, 161);
            this.minText.Name = "minText";
            this.minText.ReadOnly = true;
            this.minText.Size = new System.Drawing.Size(85, 23);
            this.minText.TabIndex = 13;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minLabel.Location = new System.Drawing.Point(273, 160);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(80, 20);
            this.minLabel.TabIndex = 12;
            this.minLabel.Text = "Số bé nhất";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Lab01_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 213);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.thirdText);
            this.Controls.Add(this.secondText);
            this.Controls.Add(this.firstText);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Lab01_Bai02";
            this.Text = "Lab01_Bai02";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.TextBox secondText;
        private System.Windows.Forms.TextBox thirdText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}