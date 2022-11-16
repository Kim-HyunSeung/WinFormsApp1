namespace MyFirstCSharp
{
    partial class Chap05_StringChang
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
            this.btnLower = new System.Windows.Forms.Button();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.btnUpper = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtstring = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtStringCount = new System.Windows.Forms.TextBox();
            this.txtIndexS = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTrim = new System.Windows.Forms.TextBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtStartTrim = new System.Windows.Forms.TextBox();
            this.btnStartTrim = new System.Windows.Forms.Button();
            this.btnEndTrim = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtEndTrim = new System.Windows.Forms.TextBox();
            this.btnChang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(54, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(327, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "        abcde ABCDE fghij FGHIJ abcde ABCDE fghij FGHIJ   \r\n";
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(16, 24);
            this.btnLower.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(65, 23);
            this.btnLower.TabIndex = 1;
            this.btnLower.Text = "변형하기";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(16, 53);
            this.txtLower.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(565, 23);
            this.txtLower.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLower);
            this.groupBox1.Controls.Add(this.btnLower);
            this.groupBox1.Location = new System.Drawing.Point(40, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(594, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ToLower()";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(56, 32);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(65, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "되돌리기";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpper);
            this.groupBox2.Controls.Add(this.btnUpper);
            this.groupBox2.Location = new System.Drawing.Point(40, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(594, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ToUpper()";
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(16, 53);
            this.txtUpper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(565, 23);
            this.txtUpper.TabIndex = 2;
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(16, 24);
            this.btnUpper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(65, 23);
            this.btnUpper.TabIndex = 1;
            this.btnUpper.Text = "변형하기";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtInsert);
            this.groupBox3.Controls.Add(this.txtIndex);
            this.groupBox3.Controls.Add(this.txtstring);
            this.groupBox3.Controls.Add(this.btnInsert);
            this.groupBox3.Location = new System.Drawing.Point(40, 262);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(594, 85);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert()";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(16, 53);
            this.txtInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(565, 23);
            this.txtInsert.TabIndex = 4;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(86, 22);
            this.txtIndex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(63, 23);
            this.txtIndex.TabIndex = 3;
            // 
            // txtstring
            // 
            this.txtstring.Location = new System.Drawing.Point(16, 22);
            this.txtstring.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtstring.Name = "txtstring";
            this.txtstring.Size = new System.Drawing.Size(66, 23);
            this.txtstring.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(240, 24);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(65, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "삽입하기";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtRemove);
            this.groupBox4.Controls.Add(this.txtStringCount);
            this.groupBox4.Controls.Add(this.txtIndexS);
            this.groupBox4.Controls.Add(this.btnRemove);
            this.groupBox4.Location = new System.Drawing.Point(40, 353);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(594, 80);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remove()";
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(16, 53);
            this.txtRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(565, 23);
            this.txtRemove.TabIndex = 4;
            // 
            // txtStringCount
            // 
            this.txtStringCount.Location = new System.Drawing.Point(87, 24);
            this.txtStringCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStringCount.Name = "txtStringCount";
            this.txtStringCount.Size = new System.Drawing.Size(76, 23);
            this.txtStringCount.TabIndex = 3;
            // 
            // txtIndexS
            // 
            this.txtIndexS.Location = new System.Drawing.Point(16, 24);
            this.txtIndexS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIndexS.Name = "txtIndexS";
            this.txtIndexS.Size = new System.Drawing.Size(66, 23);
            this.txtIndexS.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(170, 24);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "삭제하기";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTrim);
            this.groupBox5.Controls.Add(this.btnTrim);
            this.groupBox5.Location = new System.Drawing.Point(40, 439);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(594, 98);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Trim()";
            // 
            // txtTrim
            // 
            this.txtTrim.Location = new System.Drawing.Point(16, 53);
            this.txtTrim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(565, 23);
            this.txtTrim.TabIndex = 2;
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(16, 24);
            this.btnTrim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(65, 23);
            this.btnTrim.TabIndex = 1;
            this.btnTrim.Text = "변형하기";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtStartTrim);
            this.groupBox6.Controls.Add(this.btnStartTrim);
            this.groupBox6.Location = new System.Drawing.Point(40, 543);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Size = new System.Drawing.Size(594, 98);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "StartTrim()";
            // 
            // txtStartTrim
            // 
            this.txtStartTrim.Location = new System.Drawing.Point(16, 53);
            this.txtStartTrim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtStartTrim.Name = "txtStartTrim";
            this.txtStartTrim.Size = new System.Drawing.Size(565, 23);
            this.txtStartTrim.TabIndex = 2;
            // 
            // btnStartTrim
            // 
            this.btnStartTrim.Location = new System.Drawing.Point(16, 24);
            this.btnStartTrim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStartTrim.Name = "btnStartTrim";
            this.btnStartTrim.Size = new System.Drawing.Size(65, 23);
            this.btnStartTrim.TabIndex = 1;
            this.btnStartTrim.Text = "StartTrim";
            this.btnStartTrim.UseVisualStyleBackColor = true;
            this.btnStartTrim.Click += new System.EventHandler(this.btnStartTrim_Click);
            // 
            // btnEndTrim
            // 
            this.btnEndTrim.Location = new System.Drawing.Point(16, 24);
            this.btnEndTrim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEndTrim.Name = "btnEndTrim";
            this.btnEndTrim.Size = new System.Drawing.Size(65, 23);
            this.btnEndTrim.TabIndex = 3;
            this.btnEndTrim.Text = "EndTrim";
            this.btnEndTrim.UseVisualStyleBackColor = true;
            this.btnEndTrim.Click += new System.EventHandler(this.btnEndTrim_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnEndTrim);
            this.groupBox7.Controls.Add(this.txtEndTrim);
            this.groupBox7.Location = new System.Drawing.Point(40, 647);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox7.Size = new System.Drawing.Size(594, 98);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "EndTrim()";
            // 
            // txtEndTrim
            // 
            this.txtEndTrim.Location = new System.Drawing.Point(16, 53);
            this.txtEndTrim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEndTrim.Name = "txtEndTrim";
            this.txtEndTrim.Size = new System.Drawing.Size(565, 23);
            this.txtEndTrim.TabIndex = 2;
            // 
            // btnChang
            // 
            this.btnChang.Location = new System.Drawing.Point(125, 32);
            this.btnChang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChang.Name = "btnChang";
            this.btnChang.Size = new System.Drawing.Size(65, 23);
            this.btnChang.TabIndex = 10;
            this.btnChang.Text = "임의변경";
            this.btnChang.UseVisualStyleBackColor = true;
            this.btnChang.Click += new System.EventHandler(this.btnChang_Click);
            // 
            // Chap05_StringChang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 754);
            this.Controls.Add(this.btnChang);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Chap05_StringChang";
            this.Text = "문자 바꾸기";
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtstring;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.TextBox txtStringCount;
        private System.Windows.Forms.TextBox txtIndexS;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTrim;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnEndTrim;
        private System.Windows.Forms.TextBox txtStartTrim;
        private System.Windows.Forms.Button btnStartTrim;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtEndTrim;
        private Button btnChang;
    }
}