namespace MyFirstCSharp
{
    partial class CHap07_StringSplit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLength = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(29, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInterpolation);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "문자열 보간";
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Location = new System.Drawing.Point(17, 32);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(177, 23);
            this.btnInterpolation.TabIndex = 0;
            this.btnInterpolation.Text = "$";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(17, 22);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(177, 23);
            this.txtLength.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLength);
            this.groupBox2.Controls.Add(this.btnLength);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Length";
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(17, 51);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(177, 23);
            this.btnLength.TabIndex = 0;
            this.btnLength.Text = "LENGTH";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSplit);
            this.groupBox3.Controls.Add(this.btnSplit);
            this.groupBox3.Location = new System.Drawing.Point(12, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 89);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Split";
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(17, 22);
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(177, 23);
            this.txtSplit.TabIndex = 2;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(17, 51);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(177, 23);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCount);
            this.groupBox4.Controls.Add(this.txtIndex);
            this.groupBox4.Controls.Add(this.btnSubstring);
            this.groupBox4.Location = new System.Drawing.Point(12, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 148);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Substring";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(17, 22);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(61, 23);
            this.txtIndex.TabIndex = 2;
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(17, 51);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(177, 23);
            this.btnSubstring.TabIndex = 0;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(84, 22);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(61, 23);
            this.txtCount.TabIndex = 3;
            // 
            // CHap07_StringSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 505);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "CHap07_StringSplit";
            this.Text = "문자 나누기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBox1;
        private Button btnInterpolation;
        private TextBox txtLength;
        private GroupBox groupBox2;
        private Button btnLength;
        private GroupBox groupBox3;
        private TextBox txtSplit;
        private Button btnSplit;
        private GroupBox groupBox4;
        private TextBox txtIndex;
        private Button btnSubstring;
        private TextBox txtCount;
    }
}