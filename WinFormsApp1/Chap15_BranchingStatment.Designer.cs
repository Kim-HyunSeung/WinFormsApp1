﻿namespace MyfirstCSharp
{
    partial class Chap15_BranchingStatment
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnIf = new System.Windows.Forms.Button();
            this.btnInIf = new System.Windows.Forms.Button();
            this.btnElseIf = new System.Windows.Forms.Button();
            this.btnAndIf = new System.Windows.Forms.Button();
            this.btnOrIf = new System.Windows.Forms.Button();
            this.btnBoolIf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(121, 23);
            this.txtInput.TabIndex = 0;
            // 
            // btnIf
            // 
            this.btnIf.Location = new System.Drawing.Point(12, 41);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(121, 48);
            this.btnIf.TabIndex = 1;
            this.btnIf.Text = "If";
            this.btnIf.UseVisualStyleBackColor = true;
            this.btnIf.Click += new System.EventHandler(this.btnIf_Click);
            // 
            // btnInIf
            // 
            this.btnInIf.Location = new System.Drawing.Point(150, 41);
            this.btnInIf.Name = "btnInIf";
            this.btnInIf.Size = new System.Drawing.Size(121, 48);
            this.btnInIf.TabIndex = 2;
            this.btnInIf.Text = "In If";
            this.btnInIf.UseVisualStyleBackColor = true;
            this.btnInIf.Click += new System.EventHandler(this.btnInIf_Click);
            // 
            // btnElseIf
            // 
            this.btnElseIf.Location = new System.Drawing.Point(290, 41);
            this.btnElseIf.Name = "btnElseIf";
            this.btnElseIf.Size = new System.Drawing.Size(118, 48);
            this.btnElseIf.TabIndex = 3;
            this.btnElseIf.Text = "Else If";
            this.btnElseIf.UseVisualStyleBackColor = true;
            this.btnElseIf.Click += new System.EventHandler(this.btnElseIf_Click);
            // 
            // btnAndIf
            // 
            this.btnAndIf.Location = new System.Drawing.Point(12, 95);
            this.btnAndIf.Name = "btnAndIf";
            this.btnAndIf.Size = new System.Drawing.Size(118, 48);
            this.btnAndIf.TabIndex = 4;
            this.btnAndIf.Text = "AndIf";
            this.btnAndIf.UseVisualStyleBackColor = true;
            this.btnAndIf.Click += new System.EventHandler(this.btnAndIf_Click);
            // 
            // btnOrIf
            // 
            this.btnOrIf.Location = new System.Drawing.Point(150, 95);
            this.btnOrIf.Name = "btnOrIf";
            this.btnOrIf.Size = new System.Drawing.Size(118, 48);
            this.btnOrIf.TabIndex = 5;
            this.btnOrIf.Text = "OR If";
            this.btnOrIf.UseVisualStyleBackColor = true;
            this.btnOrIf.Click += new System.EventHandler(this.btnOrIf_Click);
            // 
            // btnBoolIf
            // 
            this.btnBoolIf.Location = new System.Drawing.Point(290, 95);
            this.btnBoolIf.Name = "btnBoolIf";
            this.btnBoolIf.Size = new System.Drawing.Size(118, 48);
            this.btnBoolIf.TabIndex = 6;
            this.btnBoolIf.Text = "Bool If";
            this.btnBoolIf.UseVisualStyleBackColor = true;
            this.btnBoolIf.Click += new System.EventHandler(this.btnBoolIf_Click);
            // 
            // Chap15_BranchingStatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 703);
            this.Controls.Add(this.btnBoolIf);
            this.Controls.Add(this.btnOrIf);
            this.Controls.Add(this.btnAndIf);
            this.Controls.Add(this.btnElseIf);
            this.Controls.Add(this.btnInIf);
            this.Controls.Add(this.btnIf);
            this.Controls.Add(this.txtInput);
            this.Name = "Chap15_BranchingStatment";
            this.Text = "분기문";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private Button btnIf;
        private Button btnInIf;
        private Button btnElseIf;
        private Button btnAndIf;
        private Button btnOrIf;
        private Button btnBoolIf;
    }
}