namespace MyfirstCSharp
{
    partial class Chap12_ClassTest_Run
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
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(113, 72);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(215, 160);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "가동";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Chap12_ClassTest_Run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 379);
            this.Controls.Add(this.btnRun);
            this.Name = "Chap12_ClassTest_Run";
            this.Text = "가동 시작";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRun;
    }
}