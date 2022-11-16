namespace MyfirstCSharp
{
    partial class Chap13_Static_Const
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
            this.btnHello = new System.Windows.Forms.Button();
            this.btnNice = new System.Windows.Forms.Button();
            this.btnFighting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(32, 85);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(145, 100);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "안녕하세요";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnNice
            // 
            this.btnNice.Location = new System.Drawing.Point(214, 85);
            this.btnNice.Name = "btnNice";
            this.btnNice.Size = new System.Drawing.Size(143, 100);
            this.btnNice.TabIndex = 1;
            this.btnNice.Text = "반갑습니다";
            this.btnNice.UseVisualStyleBackColor = true;
            this.btnNice.Click += new System.EventHandler(this.btnNice_Click);
            // 
            // btnFighting
            // 
            this.btnFighting.Location = new System.Drawing.Point(383, 85);
            this.btnFighting.Name = "btnFighting";
            this.btnFighting.Size = new System.Drawing.Size(140, 100);
            this.btnFighting.TabIndex = 2;
            this.btnFighting.Text = "파이팅";
            this.btnFighting.UseVisualStyleBackColor = true;
            this.btnFighting.Click += new System.EventHandler(this.btnFighting_Click);
            // 
            // Chap13_Static_Const
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 396);
            this.Controls.Add(this.btnFighting);
            this.Controls.Add(this.btnNice);
            this.Controls.Add(this.btnHello);
            this.Name = "Chap13_Static_Const";
            this.Text = "Static 한정자와 변수";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHello;
        private Button btnNice;
        private Button btnFighting;
    }
}