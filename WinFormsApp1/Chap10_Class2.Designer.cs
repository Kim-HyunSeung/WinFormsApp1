namespace MyfirstCSharp
{
    partial class Chap10_Class2
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
            this.btnCalssInstance = new System.Windows.Forms.Button();
            this.btnCalssinstance2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalssInstance
            // 
            this.btnCalssInstance.Location = new System.Drawing.Point(56, 52);
            this.btnCalssInstance.Name = "btnCalssInstance";
            this.btnCalssInstance.Size = new System.Drawing.Size(186, 71);
            this.btnCalssInstance.TabIndex = 0;
            this.btnCalssInstance.Text = "클래스 객체 및 호출";
            this.btnCalssInstance.UseVisualStyleBackColor = true;
            this.btnCalssInstance.Click += new System.EventHandler(this.btnCalssInstance_Click);
            // 
            // btnCalssinstance2
            // 
            this.btnCalssinstance2.Location = new System.Drawing.Point(296, 52);
            this.btnCalssinstance2.Name = "btnCalssinstance2";
            this.btnCalssinstance2.Size = new System.Drawing.Size(186, 71);
            this.btnCalssinstance2.TabIndex = 1;
            this.btnCalssinstance2.Text = "클래스 생성 및 호출2";
            this.btnCalssinstance2.UseVisualStyleBackColor = true;
            this.btnCalssinstance2.Click += new System.EventHandler(this.btnCalssinstance2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "다른 클래스 매서드 호출하기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Chap10_Class2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCalssinstance2);
            this.Controls.Add(this.btnCalssInstance);
            this.Name = "Chap10_Class2";
            this.Text = "Chap10_Class2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCalssInstance;
        private Button btnCalssinstance2;
        private Button button3;
    }
}