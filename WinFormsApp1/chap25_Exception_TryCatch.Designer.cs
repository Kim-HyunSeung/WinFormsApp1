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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFinarry = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(68, 63);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(171, 82);
            this.btnException.TabIndex = 0;
            this.btnException.Text = "시스템 오류 발생";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "시스템 오류 발생";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 82);
            this.button2.TabIndex = 2;
            this.button2.Text = "예외처리";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 82);
            this.button3.TabIndex = 3;
            this.button3.Text = "시스템 오류 발생";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFinarry
            // 
            this.btnFinarry.Location = new System.Drawing.Point(245, 165);
            this.btnFinarry.Name = "btnFinarry";
            this.btnFinarry.Size = new System.Drawing.Size(171, 82);
            this.btnFinarry.TabIndex = 4;
            this.btnFinarry.Text = "finally";
            this.btnFinarry.UseVisualStyleBackColor = true;
            this.btnFinarry.Click += new System.EventHandler(this.btnFinarry_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(422, 165);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(171, 82);
            this.btnThrow.TabIndex = 5;
            this.btnThrow.Text = "Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // chap25_Exception_TryCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnFinarry);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnException);
            this.Name = "chap25_Exception_TryCatch";
            this.Text = "예외 처리";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnException;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnFinarry;
        private Button btnThrow;
    }
}