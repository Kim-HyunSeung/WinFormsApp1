namespace MyFirstCSharp
{
    partial class Chap04_Operator
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
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSumEqual = new System.Windows.Forms.Button();
            this.btnMinusEqual = new System.Windows.Forms.Button();
            this.btnMulEqual = new System.Windows.Forms.Button();
            this.btnDivEqual = new System.Windows.Forms.Button();
            this.btnRemEuqal = new System.Windows.Forms.Button();
            this.btnSS = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(36, 29);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 30);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSumEqual
            // 
            this.btnSumEqual.Location = new System.Drawing.Point(117, 29);
            this.btnSumEqual.Name = "btnSumEqual";
            this.btnSumEqual.Size = new System.Drawing.Size(75, 30);
            this.btnSumEqual.TabIndex = 1;
            this.btnSumEqual.Text = "+=";
            this.btnSumEqual.UseVisualStyleBackColor = true;
            this.btnSumEqual.Click += new System.EventHandler(this.btnSumEqual_Click);
            // 
            // btnMinusEqual
            // 
            this.btnMinusEqual.Location = new System.Drawing.Point(36, 65);
            this.btnMinusEqual.Name = "btnMinusEqual";
            this.btnMinusEqual.Size = new System.Drawing.Size(75, 30);
            this.btnMinusEqual.TabIndex = 0;
            this.btnMinusEqual.Text = "-=";
            this.btnMinusEqual.UseVisualStyleBackColor = true;
            this.btnMinusEqual.Click += new System.EventHandler(this.btnMinusEqual_Click);
            // 
            // btnMulEqual
            // 
            this.btnMulEqual.Location = new System.Drawing.Point(117, 65);
            this.btnMulEqual.Name = "btnMulEqual";
            this.btnMulEqual.Size = new System.Drawing.Size(75, 30);
            this.btnMulEqual.TabIndex = 1;
            this.btnMulEqual.Text = "*=";
            this.btnMulEqual.UseVisualStyleBackColor = true;
            this.btnMulEqual.Click += new System.EventHandler(this.btnMulEqual_Click);
            // 
            // btnDivEqual
            // 
            this.btnDivEqual.Location = new System.Drawing.Point(36, 101);
            this.btnDivEqual.Name = "btnDivEqual";
            this.btnDivEqual.Size = new System.Drawing.Size(75, 30);
            this.btnDivEqual.TabIndex = 0;
            this.btnDivEqual.Text = "/=";
            this.btnDivEqual.UseVisualStyleBackColor = true;
            this.btnDivEqual.Click += new System.EventHandler(this.btnDivEqual_Click);
            // 
            // btnRemEuqal
            // 
            this.btnRemEuqal.Location = new System.Drawing.Point(117, 101);
            this.btnRemEuqal.Name = "btnRemEuqal";
            this.btnRemEuqal.Size = new System.Drawing.Size(75, 30);
            this.btnRemEuqal.TabIndex = 1;
            this.btnRemEuqal.Text = "%=";
            this.btnRemEuqal.UseVisualStyleBackColor = true;
            this.btnRemEuqal.Click += new System.EventHandler(this.btnRemEuqal_Click);
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(36, 137);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(75, 30);
            this.btnSS.TabIndex = 0;
            this.btnSS.Text = "++";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(117, 137);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(75, 30);
            this.btnMM.TabIndex = 1;
            this.btnMM.Text = "--";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // Chap04_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 200);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnRemEuqal);
            this.Controls.Add(this.btnMulEqual);
            this.Controls.Add(this.btnSumEqual);
            this.Controls.Add(this.btnSS);
            this.Controls.Add(this.btnDivEqual);
            this.Controls.Add(this.btnMinusEqual);
            this.Controls.Add(this.btnEqual);
            this.Name = "Chap04_Operator";
            this.Text = "연산자";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEqual;
        private Button btnSumEqual;
        private Button btnMinusEqual;
        private Button btnMulEqual;
        private Button btnDivEqual;
        private Button btnRemEuqal;
        private Button btnSS;
        private Button btnMM;
    }
}