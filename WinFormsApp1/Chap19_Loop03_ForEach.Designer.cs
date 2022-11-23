namespace MyfirstCSharp
{
    partial class Chap19_Loop03_ForEach
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
            this.btnStringForEach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStringForEach = new System.Windows.Forms.TextBox();
            this.btnAFE = new System.Windows.Forms.Button();
            this.btnOFE = new System.Windows.Forms.Button();
            this.grbTextBoxInit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObj1 = new System.Windows.Forms.TextBox();
            this.txtObj2 = new System.Windows.Forms.TextBox();
            this.txtObj3 = new System.Windows.Forms.TextBox();
            this.txtObj4 = new System.Windows.Forms.TextBox();
            this.grbTextBoxInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStringForEach
            // 
            this.btnStringForEach.Location = new System.Drawing.Point(12, 12);
            this.btnStringForEach.Name = "btnStringForEach";
            this.btnStringForEach.Size = new System.Drawing.Size(125, 58);
            this.btnStringForEach.TabIndex = 0;
            this.btnStringForEach.Text = "string foreach";
            this.btnStringForEach.UseVisualStyleBackColor = true;
            this.btnStringForEach.Click += new System.EventHandler(this.btnStringForEach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "abcdefghijklmnopqrstu";
            // 
            // txtStringForEach
            // 
            this.txtStringForEach.Location = new System.Drawing.Point(155, 47);
            this.txtStringForEach.Name = "txtStringForEach";
            this.txtStringForEach.Size = new System.Drawing.Size(238, 23);
            this.txtStringForEach.TabIndex = 2;
            // 
            // btnAFE
            // 
            this.btnAFE.Location = new System.Drawing.Point(12, 118);
            this.btnAFE.Name = "btnAFE";
            this.btnAFE.Size = new System.Drawing.Size(125, 58);
            this.btnAFE.TabIndex = 3;
            this.btnAFE.Text = "ArrayForEach";
            this.btnAFE.UseVisualStyleBackColor = true;
            this.btnAFE.Click += new System.EventHandler(this.btnAFE_Click);
            // 
            // btnOFE
            // 
            this.btnOFE.Location = new System.Drawing.Point(12, 213);
            this.btnOFE.Name = "btnOFE";
            this.btnOFE.Size = new System.Drawing.Size(125, 58);
            this.btnOFE.TabIndex = 4;
            this.btnOFE.Text = "ObjectForEach";
            this.btnOFE.UseVisualStyleBackColor = true;
            this.btnOFE.Click += new System.EventHandler(this.btnOFE_Click);
            // 
            // grbTextBoxInit
            // 
            this.grbTextBoxInit.Controls.Add(this.txtObj4);
            this.grbTextBoxInit.Controls.Add(this.txtObj3);
            this.grbTextBoxInit.Controls.Add(this.txtObj2);
            this.grbTextBoxInit.Controls.Add(this.txtObj1);
            this.grbTextBoxInit.Controls.Add(this.label2);
            this.grbTextBoxInit.Location = new System.Drawing.Point(166, 118);
            this.grbTextBoxInit.Name = "grbTextBoxInit";
            this.grbTextBoxInit.Size = new System.Drawing.Size(248, 191);
            this.grbTextBoxInit.TabIndex = 5;
            this.grbTextBoxInit.TabStop = false;
            this.grbTextBoxInit.Text = "TextBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "foreachtxt박스 일괄 처리하기";
            // 
            // txtObj1
            // 
            this.txtObj1.Location = new System.Drawing.Point(20, 72);
            this.txtObj1.Name = "txtObj1";
            this.txtObj1.Size = new System.Drawing.Size(190, 23);
            this.txtObj1.TabIndex = 1;
            // 
            // txtObj2
            // 
            this.txtObj2.Location = new System.Drawing.Point(20, 101);
            this.txtObj2.Name = "txtObj2";
            this.txtObj2.Size = new System.Drawing.Size(190, 23);
            this.txtObj2.TabIndex = 2;
            // 
            // txtObj3
            // 
            this.txtObj3.Location = new System.Drawing.Point(20, 130);
            this.txtObj3.Name = "txtObj3";
            this.txtObj3.Size = new System.Drawing.Size(190, 23);
            this.txtObj3.TabIndex = 3;
            // 
            // txtObj4
            // 
            this.txtObj4.Location = new System.Drawing.Point(20, 159);
            this.txtObj4.Name = "txtObj4";
            this.txtObj4.Size = new System.Drawing.Size(190, 23);
            this.txtObj4.TabIndex = 4;
            // 
            // Chap19_Loop03_ForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTextBoxInit);
            this.Controls.Add(this.btnOFE);
            this.Controls.Add(this.btnAFE);
            this.Controls.Add(this.txtStringForEach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStringForEach);
            this.Name = "Chap19_Loop03_ForEach";
            this.Text = "ForEach";
            this.grbTextBoxInit.ResumeLayout(false);
            this.grbTextBoxInit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStringForEach;
        private Label label1;
        private TextBox txtStringForEach;
        private Button btnAFE;
        private Button btnOFE;
        private GroupBox grbTextBoxInit;
        private TextBox txtObj4;
        private TextBox txtObj3;
        private TextBox txtObj2;
        private TextBox txtObj1;
        private Label label2;
    }
}