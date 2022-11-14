namespace MyfirstCSharp
{
    partial class Chap06_StringFind
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
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.txtIndexOf = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLastIndex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.txtStartWith = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.txtEndWith = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtReplace2 = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplace1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(50, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "동해물과 백두산이 마르고 닳도록 하느님이 보우하사 우리 나라 만세";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIndexOf);
            this.groupBox1.Controls.Add(this.txtIndexOf);
            this.groupBox1.Location = new System.Drawing.Point(44, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index Of ()";
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(6, 65);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(75, 23);
            this.btnIndexOf.TabIndex = 2;
            this.btnIndexOf.Text = "찾기";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // txtIndexOf
            // 
            this.txtIndexOf.Location = new System.Drawing.Point(6, 36);
            this.txtIndexOf.Name = "txtIndexOf";
            this.txtIndexOf.Size = new System.Drawing.Size(100, 23);
            this.txtIndexOf.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtLastIndex);
            this.groupBox2.Location = new System.Drawing.Point(250, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LastIndexOf()";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLastIndex
            // 
            this.txtLastIndex.Location = new System.Drawing.Point(6, 36);
            this.txtLastIndex.Name = "txtLastIndex";
            this.txtLastIndex.Size = new System.Drawing.Size(100, 23);
            this.txtLastIndex.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartWith);
            this.groupBox3.Controls.Add(this.txtStartWith);
            this.groupBox3.Location = new System.Drawing.Point(456, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "StartWith()";
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(6, 65);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(75, 23);
            this.btnStartWith.TabIndex = 2;
            this.btnStartWith.Text = "판단하기";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // txtStartWith
            // 
            this.txtStartWith.Location = new System.Drawing.Point(6, 36);
            this.txtStartWith.Name = "txtStartWith";
            this.txtStartWith.Size = new System.Drawing.Size(100, 23);
            this.txtStartWith.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEndWith);
            this.groupBox4.Controls.Add(this.txtEndWith);
            this.groupBox4.Location = new System.Drawing.Point(662, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EndWith()";
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(6, 65);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(75, 23);
            this.btnEndWith.TabIndex = 2;
            this.btnEndWith.Text = "판단하기";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // txtEndWith
            // 
            this.txtEndWith.Location = new System.Drawing.Point(6, 36);
            this.txtEndWith.Name = "txtEndWith";
            this.txtEndWith.Size = new System.Drawing.Size(100, 23);
            this.txtEndWith.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnContains);
            this.groupBox5.Controls.Add(this.txtContains);
            this.groupBox5.Location = new System.Drawing.Point(50, 228);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 126);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contains()";
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(6, 65);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(75, 23);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "판단하기";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(6, 36);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(100, 23);
            this.txtContains.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnReturn);
            this.groupBox6.Controls.Add(this.txtReplace2);
            this.groupBox6.Controls.Add(this.btnReplace);
            this.groupBox6.Controls.Add(this.txtReplace1);
            this.groupBox6.Location = new System.Drawing.Point(266, 228);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(403, 126);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Replace()";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(171, 65);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(138, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "되돌리기";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtReplace2
            // 
            this.txtReplace2.Location = new System.Drawing.Point(171, 36);
            this.txtReplace2.Name = "txtReplace2";
            this.txtReplace2.Size = new System.Drawing.Size(138, 23);
            this.txtReplace2.TabIndex = 3;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(6, 65);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(137, 23);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "바꾸기";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtReplace1
            // 
            this.txtReplace1.Location = new System.Drawing.Point(6, 36);
            this.txtReplace1.Name = "txtReplace1";
            this.txtReplace1.Size = new System.Drawing.Size(137, 23);
            this.txtReplace1.TabIndex = 0;
            // 
            // Chap06_StringFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 669);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap06_StringFind";
            this.Text = "문자열 찾기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBox1;
        private Button btnIndexOf;
        private TextBox txtIndexOf;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox txtLastIndex;
        private GroupBox groupBox3;
        private Button btnStartWith;
        private TextBox txtStartWith;
        private GroupBox groupBox4;
        private Button btnEndWith;
        private TextBox txtEndWith;
        private GroupBox groupBox5;
        private Button btnContains;
        private TextBox txtContains;
        private GroupBox groupBox6;
        private Button btnReturn;
        private TextBox txtReplace2;
        private Button btnReplace;
        private TextBox txtReplace1;
    }
}