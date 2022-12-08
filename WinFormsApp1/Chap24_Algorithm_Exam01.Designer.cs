namespace MyFirstCSharp
{
    partial class Chap24_Algorithm_Exam01
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFindDoubleValue
            // 
            this.btnFindDoubleValue.Location = new System.Drawing.Point(117, 237);
            this.btnFindDoubleValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindDoubleValue.Name = "btnFindDoubleValue";
            this.btnFindDoubleValue.Size = new System.Drawing.Size(685, 63);
            this.btnFindDoubleValue.TabIndex = 0;
            this.btnFindDoubleValue.Text = "없는수 합하기";
            this.btnFindDoubleValue.UseVisualStyleBackColor = true;
            this.btnFindDoubleValue.Click += new System.EventHandler(this.btnMakeRandomAndSum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "랜덤함수 로 0 부터 20까지의 수를 20개를 받아 배열에 담아 텍스트 박스에 표현후";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "0 부터 20까지 수 중 없는 수를 모두 합한 결과를 메세지로 표현하시오.";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(117, 179);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(685, 27);
            this.txtResult.TabIndex = 2;
            // 
            // Chap30_Algorithm_TestCode_9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 336);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindDoubleValue);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Chap30_Algorithm_TestCode_9";
            this.Text = "난수 중 없는 수 합하기 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDoubleValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
    }
}