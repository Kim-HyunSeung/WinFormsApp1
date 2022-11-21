namespace MyFirstCSharp
{
    partial class Chap16_Switch
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
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFruit = new System.Windows.Forms.TextBox();
            this.btnIf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(138, 89);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(97, 65);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "찾기(Switch)";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "과일 이름";
            // 
            // txtFruit
            // 
            this.txtFruit.Location = new System.Drawing.Point(77, 41);
            this.txtFruit.Name = "txtFruit";
            this.txtFruit.Size = new System.Drawing.Size(125, 23);
            this.txtFruit.TabIndex = 2;
            // 
            // btnIf
            // 
            this.btnIf.Location = new System.Drawing.Point(77, 89);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(55, 65);
            this.btnIf.TabIndex = 3;
            this.btnIf.Text = "찾기(IF)";
            this.btnIf.UseVisualStyleBackColor = true;
            this.btnIf.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // Chap16_Switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 348);
            this.Controls.Add(this.btnIf);
            this.Controls.Add(this.txtFruit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwitch);
            this.Name = "Chap16_Switch";
            this.Text = "Switch 분기문";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSwitch;
        private Label label1;
        private TextBox txtFruit;
        private Button btnIf;
    }
}