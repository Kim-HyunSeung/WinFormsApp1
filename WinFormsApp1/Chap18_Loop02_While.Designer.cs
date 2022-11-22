namespace MyfirstCSharp
{
    partial class Chap18_Loop02_While
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnWhileRun = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(30, 76);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(125, 113);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While 기본원형";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnWhileRun
            // 
            this.btnWhileRun.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWhileRun.Location = new System.Drawing.Point(172, 76);
            this.btnWhileRun.Name = "btnWhileRun";
            this.btnWhileRun.Size = new System.Drawing.Size(118, 113);
            this.btnWhileRun.TabIndex = 1;
            this.btnWhileRun.Text = "무한 루프";
            this.btnWhileRun.UseVisualStyleBackColor = true;
            this.btnWhileRun.Click += new System.EventHandler(this.btnWhileRun_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDoWhile.Location = new System.Drawing.Point(315, 74);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(124, 115);
            this.btnDoWhile.TabIndex = 2;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // Chap18_Loop02_While
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 510);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhileRun);
            this.Controls.Add(this.btnWhile);
            this.Name = "Chap18_Loop02_While";
            this.Text = "Chap18_Loop02_While";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnWhile;
        private Button btnWhileRun;
        private Button btnDoWhile;
    }
}