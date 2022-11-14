namespace MyfirstCSharp
{
    partial class Chap03_DataTypeChang
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
            this.btnChangeStoI = new System.Windows.Forms.Button();
            this.btnChangeStoL = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeStoI
            // 
            this.btnChangeStoI.Location = new System.Drawing.Point(25, 67);
            this.btnChangeStoI.Name = "btnChangeStoI";
            this.btnChangeStoI.Size = new System.Drawing.Size(155, 95);
            this.btnChangeStoI.TabIndex = 0;
            this.btnChangeStoI.Text = "숫자 -> 문자";
            this.btnChangeStoI.UseVisualStyleBackColor = true;
            this.btnChangeStoI.Click += new System.EventHandler(this.btnChangeStoI_Click);
            // 
            // btnChangeStoL
            // 
            this.btnChangeStoL.Location = new System.Drawing.Point(196, 67);
            this.btnChangeStoL.Name = "btnChangeStoL";
            this.btnChangeStoL.Size = new System.Drawing.Size(151, 95);
            this.btnChangeStoL.TabIndex = 1;
            this.btnChangeStoL.Text = "문자 -> 숫자";
            this.btnChangeStoL.UseVisualStyleBackColor = true;
            this.btnChangeStoL.Click += new System.EventHandler(this.btnChangeStoL_Click);
            // 
            // btnNull
            // 
            this.btnNull.Location = new System.Drawing.Point(25, 168);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(155, 98);
            this.btnNull.TabIndex = 2;
            this.btnNull.Text = "NULL";
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.button3_Click);
            // 
            // Chap03_DataTypeChang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 532);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnChangeStoL);
            this.Controls.Add(this.btnChangeStoI);
            this.Name = "Chap03_DataTypeChang";
            this.Text = "데이터 형변환.";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChangeStoI;
        private Button btnChangeStoL;
        private Button btnNull;
    }
}