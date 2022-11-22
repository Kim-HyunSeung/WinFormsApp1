namespace MyFirstCSharp
{
    partial class Chap17_Loop01_ForTest12
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTwoMSum = new System.Windows.Forms.Button();
            this.btnFivMSum = new System.Windows.Forms.Button();
            this.btnTenMSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "For 문을 한번만 코딩 하여 범위안의 수 중 2,5,10 의 배수 의 합 을";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "버튼을 클릭 하였을때 메세지로 표현하는 프로그램을 구현하세요.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "  . 텍스트 박스의 문자는 반드시 숫자 만 입력 되어야 함";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "  . 음수 는 입력 받을 수 없음.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "입력 받을 범위";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(225, 184);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(57, 23);
            this.txtStart.TabIndex = 5;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(309, 184);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(57, 23);
            this.txtEnd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "~";
            // 
            // btnTwoMSum
            // 
            this.btnTwoMSum.Location = new System.Drawing.Point(101, 240);
            this.btnTwoMSum.Name = "btnTwoMSum";
            this.btnTwoMSum.Size = new System.Drawing.Size(118, 36);
            this.btnTwoMSum.TabIndex = 8;
            this.btnTwoMSum.Text = "2 의 배수 합 표현";
            this.btnTwoMSum.UseVisualStyleBackColor = true;
            this.btnTwoMSum.Click += new System.EventHandler(this.btnTwoMSum_Click);
            // 
            // btnFivMSum
            // 
            this.btnFivMSum.Location = new System.Drawing.Point(225, 240);
            this.btnFivMSum.Name = "btnFivMSum";
            this.btnFivMSum.Size = new System.Drawing.Size(126, 36);
            this.btnFivMSum.TabIndex = 9;
            this.btnFivMSum.Text = "5 의 배수 합 표현";
            this.btnFivMSum.UseVisualStyleBackColor = true;
            this.btnFivMSum.Click += new System.EventHandler(this.btnFivMSum_Click);
            // 
            // btnTenMSum
            // 
            this.btnTenMSum.Location = new System.Drawing.Point(357, 240);
            this.btnTenMSum.Name = "btnTenMSum";
            this.btnTenMSum.Size = new System.Drawing.Size(125, 36);
            this.btnTenMSum.TabIndex = 10;
            this.btnTenMSum.Text = "10 의 배수 합 표현";
            this.btnTenMSum.UseVisualStyleBackColor = true;
            this.btnTenMSum.Click += new System.EventHandler(this.btnTenMSum_Click);
            // 
            // Chap17_Loop01_ForTest11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 337);
            this.Controls.Add(this.btnTenMSum);
            this.Controls.Add(this.btnFivMSum);
            this.Controls.Add(this.btnTwoMSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap17_Loop01_ForTest11";
            this.Text = "For 문 실습 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Label label6;
        private Button btnTwoMSum;
        private Button btnFivMSum;
        private Button btnTenMSum;
    }
}