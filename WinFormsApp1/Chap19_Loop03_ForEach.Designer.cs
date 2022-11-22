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
            // Chap19_Loop03_ForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStringForEach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStringForEach);
            this.Name = "Chap19_Loop03_ForEach";
            this.Text = "ForEach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStringForEach;
        private Label label1;
        private TextBox txtStringForEach;
    }
}