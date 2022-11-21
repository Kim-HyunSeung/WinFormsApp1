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
            // Chap17_Loop01_FOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 612);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnFOR_01);
            this.Name = "Chap17_Loop01_FOR";
            this.Text = "반복문 FOR";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFOR_01;
        private Button btnArraySum;
    }
}