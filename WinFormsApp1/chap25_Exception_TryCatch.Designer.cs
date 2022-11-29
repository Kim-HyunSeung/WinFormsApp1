namespace MyFirstCSharp
{
    partial class chap25_Exception_TryCatch
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
            this.btnException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(84, 22);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(171, 82);
            this.btnException.TabIndex = 0;
            this.btnException.Text = "시스템 오류 발생";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // chap25_Exception_TryCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnException);
            this.Name = "chap25_Exception_TryCatch";
            this.Text = "예외 처리";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnException;
    }
}