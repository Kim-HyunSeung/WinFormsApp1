namespace MyFirstCSharp
{
    partial class Chap22_Algorithm_Test06
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFindAndReplace = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnFindAndReplaceFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "아래의 문자열 중 첫번째 ? 와 세번째 ? 의 Index 를 찾아 각 Index 의 합의 Index 에있는 문자열 3자리를 구하고 \"무궁화\" 로 " +
    "변경후 텍스트박스에 표현하세요";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(169, 72);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 15);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "동해물과 백두산이? 마르고닳?도록 하느님이 보우하사?우리 나라만세?진달래 삼천리? 화려강산";
            // 
            // btnFindAndReplace
            // 
            this.btnFindAndReplace.Location = new System.Drawing.Point(355, 102);
            this.btnFindAndReplace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFindAndReplace.Name = "btnFindAndReplace";
            this.btnFindAndReplace.Size = new System.Drawing.Size(163, 41);
            this.btnFindAndReplace.TabIndex = 7;
            this.btnFindAndReplace.Text = "위치 찾아 바꾸기";
            this.btnFindAndReplace.UseVisualStyleBackColor = true;
            this.btnFindAndReplace.Click += new System.EventHandler(this.btnFindAndReplace_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(11, 159);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(914, 23);
            this.txtResult.TabIndex = 8;
            // 
            // btnFindAndReplaceFor
            // 
            this.btnFindAndReplaceFor.Location = new System.Drawing.Point(527, 102);
            this.btnFindAndReplaceFor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFindAndReplaceFor.Name = "btnFindAndReplaceFor";
            this.btnFindAndReplaceFor.Size = new System.Drawing.Size(163, 41);
            this.btnFindAndReplaceFor.TabIndex = 9;
            this.btnFindAndReplaceFor.Text = "위치 찾아 바꾸기(Foreach)";
            this.btnFindAndReplaceFor.UseVisualStyleBackColor = true;
            this.btnFindAndReplaceFor.Click += new System.EventHandler(this.btnFindAndReplaceFor_Click);
            // 
            // Chap22_Algorithm_Test06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 212);
            this.Controls.Add(this.btnFindAndReplaceFor);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnFindAndReplace);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Chap22_Algorithm_Test06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFindAndReplace;
        private System.Windows.Forms.TextBox txtResult;
        private Button btnFindAndReplaceFor;
    }
}