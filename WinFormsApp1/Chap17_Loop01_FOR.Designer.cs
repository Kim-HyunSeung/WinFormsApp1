namespace MyfirstCSharp
{
    partial class Chap17_Loop01_FOR
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
            this.btnFOR_01 = new System.Windows.Forms.Button();
            this.btnArraySum = new System.Windows.Forms.Button();
            this.txtGuGuDan = new System.Windows.Forms.TextBox();
            this.btnGuGuDan = new System.Windows.Forms.Button();
            this.btnImmutable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFOR_01
            // 
            this.btnFOR_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFOR_01.Location = new System.Drawing.Point(0, 0);
            this.btnFOR_01.Name = "btnFOR_01";
            this.btnFOR_01.Size = new System.Drawing.Size(672, 62);
            this.btnFOR_01.TabIndex = 0;
            this.btnFOR_01.Text = "1~100까지 더하기";
            this.btnFOR_01.UseVisualStyleBackColor = true;
            this.btnFOR_01.Click += new System.EventHandler(this.btnFOR_01_Click);
            // 
            // btnArraySum
            // 
            this.btnArraySum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArraySum.Location = new System.Drawing.Point(0, 62);
            this.btnArraySum.Name = "btnArraySum";
            this.btnArraySum.Size = new System.Drawing.Size(672, 62);
            this.btnArraySum.TabIndex = 1;
            this.btnArraySum.Text = "배열 값 더하기";
            this.btnArraySum.UseVisualStyleBackColor = true;
            this.btnArraySum.Click += new System.EventHandler(this.btnArraySum_Click);
            // 
            // txtGuGuDan
            // 
            this.txtGuGuDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGuGuDan.Location = new System.Drawing.Point(0, 124);
            this.txtGuGuDan.Multiline = true;
            this.txtGuGuDan.Name = "txtGuGuDan";
            this.txtGuGuDan.Size = new System.Drawing.Size(672, 174);
            this.txtGuGuDan.TabIndex = 2;
            // 
            // btnGuGuDan
            // 
            this.btnGuGuDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuGuDan.Location = new System.Drawing.Point(0, 298);
            this.btnGuGuDan.Name = "btnGuGuDan";
            this.btnGuGuDan.Size = new System.Drawing.Size(672, 75);
            this.btnGuGuDan.TabIndex = 3;
            this.btnGuGuDan.Text = "For int For (구구단예상)";
            this.btnGuGuDan.UseVisualStyleBackColor = true;
            this.btnGuGuDan.Click += new System.EventHandler(this.btnGuGuDan_Click);
            // 
            // btnImmutable
            // 
            this.btnImmutable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImmutable.Location = new System.Drawing.Point(0, 373);
            this.btnImmutable.Name = "btnImmutable";
            this.btnImmutable.Size = new System.Drawing.Size(672, 53);
            this.btnImmutable.TabIndex = 4;
            this.btnImmutable.Text = "Immutable";
            this.btnImmutable.UseVisualStyleBackColor = true;
            this.btnImmutable.Click += new System.EventHandler(this.btnImmutable_Click);
            // 
            // Chap17_Loop01_FOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 612);
            this.Controls.Add(this.btnImmutable);
            this.Controls.Add(this.btnGuGuDan);
            this.Controls.Add(this.txtGuGuDan);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnFOR_01);
            this.Name = "Chap17_Loop01_FOR";
            this.Text = "반복문 FOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFOR_01;
        private Button btnArraySum;
        private TextBox txtGuGuDan;
        private Button btnGuGuDan;
        private Button btnImmutable;
    }
}