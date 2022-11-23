namespace MyfirstCSharp
{
    partial class Chap20_Test
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
            this.btnC1 = new System.Windows.Forms.Button();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 2,4배열을 만들고 1행과 2행을 바꾸어 새로운 배열에 담아\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "배열의 결과를 테스트 박스에 표현하세요";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "{1,2,3,4} {5,6,7,8}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "{5,6,7,8} {1,2,3,4}";
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(12, 182);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(271, 68);
            this.btnC1.TabIndex = 4;
            this.btnC1.Text = "변경하기";
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(12, 274);
            this.txtC1.Multiline = true;
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(271, 172);
            this.txtC1.TabIndex = 5;
            // 
            // Chap20_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 512);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_Test";
            this.Text = "배열 실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnC1;
        private TextBox txtC1;
    }
}