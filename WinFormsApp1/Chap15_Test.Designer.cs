namespace MyfirstCSharp
{
    partial class Chap15_Test
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
            this.btnJubge = new System.Windows.Forms.Button();
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMultiE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBtnClickCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJubge
            // 
            this.btnJubge.Location = new System.Drawing.Point(353, 77);
            this.btnJubge.Name = "btnJubge";
            this.btnJubge.Size = new System.Drawing.Size(113, 23);
            this.btnJubge.TabIndex = 0;
            this.btnJubge.Text = "2,5공배수 판단";
            this.btnJubge.UseVisualStyleBackColor = true;
            this.btnJubge.Click += new System.EventHandler(this.btnJubge_Click);
            // 
            // txtInputValue
            // 
            this.txtInputValue.Location = new System.Drawing.Point(223, 74);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(100, 23);
            this.txtInputValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "입력받을 값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "8의 배수일경우 결과값과 곱";
            // 
            // txtMultiE
            // 
            this.txtMultiE.Location = new System.Drawing.Point(224, 125);
            this.txtMultiE.Name = "txtMultiE";
            this.txtMultiE.Size = new System.Drawing.Size(100, 23);
            this.txtMultiE.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "버튼을 클릭한 총 횟수";
            // 
            // txtBtnClickCount
            // 
            this.txtBtnClickCount.Location = new System.Drawing.Point(223, 176);
            this.txtBtnClickCount.Name = "txtBtnClickCount";
            this.txtBtnClickCount.Size = new System.Drawing.Size(100, 23);
            this.txtBtnClickCount.TabIndex = 6;
            // 
            // Chap15_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBtnClickCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMultiE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputValue);
            this.Controls.Add(this.btnJubge);
            this.Name = "Chap15_Test";
            this.Text = "분기문 테스트, 공배수 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnJubge;
        private TextBox txtInputValue;
        private Label label1;
        private Label label2;
        private TextBox txtMultiE;
        private Label label3;
        private TextBox txtBtnClickCount;
    }
}