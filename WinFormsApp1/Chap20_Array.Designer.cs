namespace MyfirstCSharp
{
    partial class Chap20_Array
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
            this.btnArrayFunction = new System.Windows.Forms.Button();
            this.btnArrayCopy = new System.Windows.Forms.Button();
            this.btnTwoD = new System.Windows.Forms.Button();
            this.txt2D = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnArrayFunction
            // 
            this.btnArrayFunction.Location = new System.Drawing.Point(31, 32);
            this.btnArrayFunction.Name = "btnArrayFunction";
            this.btnArrayFunction.Size = new System.Drawing.Size(176, 93);
            this.btnArrayFunction.TabIndex = 0;
            this.btnArrayFunction.Text = "Array Function";
            this.btnArrayFunction.UseVisualStyleBackColor = true;
            this.btnArrayFunction.Click += new System.EventHandler(this.btnArrayFunction_Click);
            // 
            // btnArrayCopy
            // 
            this.btnArrayCopy.Location = new System.Drawing.Point(213, 32);
            this.btnArrayCopy.Name = "btnArrayCopy";
            this.btnArrayCopy.Size = new System.Drawing.Size(176, 93);
            this.btnArrayCopy.TabIndex = 1;
            this.btnArrayCopy.Text = "Array Copy";
            this.btnArrayCopy.UseVisualStyleBackColor = true;
            this.btnArrayCopy.Click += new System.EventHandler(this.btnArrayCopy_Click);
            // 
            // btnTwoD
            // 
            this.btnTwoD.Location = new System.Drawing.Point(395, 32);
            this.btnTwoD.Name = "btnTwoD";
            this.btnTwoD.Size = new System.Drawing.Size(176, 93);
            this.btnTwoD.TabIndex = 2;
            this.btnTwoD.Text = "2차원 배열";
            this.btnTwoD.UseVisualStyleBackColor = true;
            this.btnTwoD.Click += new System.EventHandler(this.btnTwoD_Click);
            // 
            // txt2D
            // 
            this.txt2D.Location = new System.Drawing.Point(31, 131);
            this.txt2D.Multiline = true;
            this.txt2D.Name = "txt2D";
            this.txt2D.Size = new System.Drawing.Size(540, 158);
            this.txt2D.TabIndex = 3;
            // 
            // Chap20_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 498);
            this.Controls.Add(this.txt2D);
            this.Controls.Add(this.btnTwoD);
            this.Controls.Add(this.btnArrayCopy);
            this.Controls.Add(this.btnArrayFunction);
            this.Name = "Chap20_Array";
            this.Text = "배열";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnArrayFunction;
        private Button btnArrayCopy;
        private Button btnTwoD;
        private TextBox txt2D;
    }
}