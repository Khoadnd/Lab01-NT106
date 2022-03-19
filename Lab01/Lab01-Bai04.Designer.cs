
namespace Lab01
{
    partial class Lab01_Bai04
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.rateText = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(202, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Chuyển đổi tiền tệ";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputLabel.Location = new System.Drawing.Point(12, 58);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(108, 20);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Số tiền cần đổi";
            // 
            // cboCurrency
            // 
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Items.AddRange(new object[] {
            "USD (Đô-la Mỹ)",
            "EUR (Euro)",
            "GBP (Bảng Anh)",
            "SGD (Singapore dollar)",
            "JPY (Yen)"});
            this.cboCurrency.Location = new System.Drawing.Point(289, 55);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(146, 23);
            this.cboCurrency.TabIndex = 2;
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(126, 55);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(157, 23);
            this.inputText.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(43, 95);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(337, 28);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 143);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(102, 20);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Số tiền đã đổi";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(126, 140);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(157, 23);
            this.resultText.TabIndex = 6;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rateLabel.Location = new System.Drawing.Point(12, 178);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(103, 20);
            this.rateLabel.TabIndex = 7;
            this.rateLabel.Text = "Tỷ giá quy đổi";
            // 
            // rateText
            // 
            this.rateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rateText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rateText.Location = new System.Drawing.Point(126, 178);
            this.rateText.Name = "rateText";
            this.rateText.ReadOnly = true;
            this.rateText.Size = new System.Drawing.Size(309, 20);
            this.rateText.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab01_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rateText);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.cboCurrency);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Lab01_Bai04";
            this.Text = "Lab01_Bai04";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox rateText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnExit;
    }
}