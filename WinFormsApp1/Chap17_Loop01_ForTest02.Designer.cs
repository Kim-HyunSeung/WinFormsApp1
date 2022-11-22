namespace MyFirstCSharp
{
    partial class Chap17_Loop01_ForTest02
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
            this.btnOddEvenSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOddEvenSum
            // 
            this.btnOddEvenSum.Location = new System.Drawing.Point(133, 59);
            this.btnOddEvenSum.Name = "btnOddEvenSum";
            this.btnOddEvenSum.Size = new System.Drawing.Size(252, 65);
            this.btnOddEvenSum.TabIndex = 0;
            this.btnOddEvenSum.Text = "짝수 홀수 합 표현하기";
            this.btnOddEvenSum.UseVisualStyleBackColor = true;
            this.btnOddEvenSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 부터 100 까지의 수 중 짝수의 합과 홀수의 합을 메세지 박스로 표현하세요. ";
            // 
            // Chap17_Loop01_ForTest01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOddEvenSum);
            this.Name = "Chap17_Loop01_ForTest01";
            this.Text = "짝수 홀수 합 표현하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOddEvenSum;
        private Label label1;
    }
}