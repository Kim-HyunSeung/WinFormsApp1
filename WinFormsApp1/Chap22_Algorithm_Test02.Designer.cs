namespace MyfirstCSharp
{
    partial class Chap22_Algorithm_Test02
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
            this.lblS = new System.Windows.Forms.Label();
            this.btnDrc = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 문자 열 중 중복되지 않는 문자 를 찾고, 왼쪽에서 가장 첫 번째 문자를 메세지 박스로 나타내시오.";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("맑은 고딕", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblS.Location = new System.Drawing.Point(172, 98);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(367, 46);
            this.lblS.TabIndex = 1;
            this.lblS.Text = "ABCLD/EML/BZAMDC/";
            // 
            // btnDrc
            // 
            this.btnDrc.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDrc.Location = new System.Drawing.Point(158, 172);
            this.btnDrc.Name = "btnDrc";
            this.btnDrc.Size = new System.Drawing.Size(396, 45);
            this.btnDrc.TabIndex = 2;
            this.btnDrc.Text = "찾기(Dictionary,Foreach)";
            this.btnDrc.UseVisualStyleBackColor = true;
            this.btnDrc.Click += new System.EventHandler(this.btnDrc_Click_1);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLast.Location = new System.Drawing.Point(158, 223);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(396, 45);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "찾기(LastindexOf())";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSerch.Location = new System.Drawing.Point(158, 274);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(396, 45);
            this.btnSerch.TabIndex = 4;
            this.btnSerch.Text = "찾기";
            this.btnSerch.UseVisualStyleBackColor = true;
            // 
            // Chap22_Algorithm_Test02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnDrc);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.label1);
            this.Name = "Chap22_Algorithm_Test02";
            this.Text = "중복되지않는 문자 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblS;
        private Button btnDrc;
        private Button btnLast;
        private Button btnSerch;
    }
}