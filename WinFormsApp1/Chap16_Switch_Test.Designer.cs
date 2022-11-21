namespace MyfirstCSharp
{
    partial class Chap16_Switch_Test
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCount2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCount1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblA1);
            this.groupBox1.Controls.Add(this.lblCount);
            this.groupBox1.Location = new System.Drawing.Point(69, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사과";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(6, 51);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(128, 85);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "사과 주문";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnApple_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "개";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(140, 19);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(21, 15);
            this.lblA1.TabIndex = 1;
            this.lblA1.Text = "10";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(0, 19);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(134, 15);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "사과 2000원 남은 개수:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCount2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblA3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(600, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "수박";
            // 
            // btnCount2
            // 
            this.btnCount2.Location = new System.Drawing.Point(6, 51);
            this.btnCount2.Name = "btnCount2";
            this.btnCount2.Size = new System.Drawing.Size(128, 84);
            this.btnCount2.TabIndex = 3;
            this.btnCount2.Text = "수박 주문";
            this.btnCount2.UseVisualStyleBackColor = true;
            this.btnCount2.Click += new System.EventHandler(this.btnCount2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "개";
            // 
            // lblA3
            // 
            this.lblA3.AutoSize = true;
            this.lblA3.Location = new System.Drawing.Point(140, 19);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(21, 15);
            this.lblA3.TabIndex = 1;
            this.lblA3.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "수박 2000원 남은 개수:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCount1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblA2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(330, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 215);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "참외";
            // 
            // btnCount1
            // 
            this.btnCount1.Location = new System.Drawing.Point(6, 51);
            this.btnCount1.Name = "btnCount1";
            this.btnCount1.Size = new System.Drawing.Size(128, 84);
            this.btnCount1.TabIndex = 3;
            this.btnCount1.Text = "참외 주문";
            this.btnCount1.UseVisualStyleBackColor = true;
            this.btnCount1.Click += new System.EventHandler(this.btnCount1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "개";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Location = new System.Drawing.Point(140, 19);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(21, 15);
            this.lblA2.TabIndex = 1;
            this.lblA2.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "수박 2500원 남은 개수:";
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(233, 332);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(283, 95);
            this.btnPrice.TabIndex = 4;
            this.btnPrice.Text = "총 결제 금액 보기";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // Chap16_Switch_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 672);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chap16_Switch_Test";
            this.Text = "Chap16_Switch_Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCount;
        private Label label3;
        private Label lblA1;
        private Label lblCount;
        private GroupBox groupBox2;
        private Button btnCount2;
        private Label label9;
        private Label lblA3;
        private Label label11;
        private GroupBox groupBox3;
        private Button btnCount1;
        private Label label6;
        private Label lblA2;
        private Label label8;
        private Button btnPrice;
    }
}