namespace CHAP04_MiddleExam
{
    partial class Chap22_Algorithm_Test05
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
            this.btnFindDoubleValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindDoubleValue
            // 
            this.btnFindDoubleValue.Location = new System.Drawing.Point(165, 209);
            this.btnFindDoubleValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindDoubleValue.Name = "btnFindDoubleValue";
            this.btnFindDoubleValue.Size = new System.Drawing.Size(685, 63);
            this.btnFindDoubleValue.TabIndex = 0;
            this.btnFindDoubleValue.Text = "중복 값 찾기";
            this.btnFindDoubleValue.UseVisualStyleBackColor = true;
            this.btnFindDoubleValue.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "다음 문자열에 포함된 수를 정수 배열로 만들고 중복 되는 수 중 낮은 수 의 첫번째 값과 세번째 값을 메세지 박스로 나타내세요.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(313, 163);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "{1, 2 , 13, 15 , 17,  23,  8,  15, 8,  19,  3,  8,  13 }";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "  * 라벨에 입력 된  문자열을 받아 정수 배열로 만드는 로직을 작성할것";
            // 
            // Chap30_Algorithm_TestCode_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindDoubleValue);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Chap30_Algorithm_TestCode_6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDoubleValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
    }
}