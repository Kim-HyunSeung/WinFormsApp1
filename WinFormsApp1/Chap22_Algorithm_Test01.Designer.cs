namespace MyfirstCSharp
{
    partial class Chap22_Algorithm_Test01
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
            this.btnSerach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(221, 203);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(263, 68);
            this.btnSerach.TabIndex = 0;
            this.btnSerach.Text = "찾기";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "아래에 나열된 정수 중에 두개를 도출하여 합이16이되는 쌍을 메세지박스로 표현하시오.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "1,  4,  6,  9,  10,  12,  16";
            // 
            // Chap22_Algorithm_Test01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSerach);
            this.Name = "Chap22_Algorithm_Test01";
            this.Text = "합의 쌍 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSerach;
        private Label label1;
        private Label label2;
    }
}