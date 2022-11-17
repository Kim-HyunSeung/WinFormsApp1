namespace MyfirstCSharp
{
    partial class Chap14_Method
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMethodCall = new System.Windows.Forms.Button();
            this.btnArg_Par = new System.Windows.Forms.Button();
            this.btnVoidReturn = new System.Windows.Forms.Button();
            this.btnStringReturn = new System.Windows.Forms.Button();
            this.btnIntReturn = new System.Windows.Forms.Button();
            this.btnDefaultToReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(22, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(152, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(56, 138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ddfdgdf";
            // 
            // btnMethodCall
            // 
            this.btnMethodCall.Location = new System.Drawing.Point(22, 185);
            this.btnMethodCall.Name = "btnMethodCall";
            this.btnMethodCall.Size = new System.Drawing.Size(108, 55);
            this.btnMethodCall.TabIndex = 2;
            this.btnMethodCall.Text = "함수호출";
            this.btnMethodCall.UseVisualStyleBackColor = true;
            this.btnMethodCall.Click += new System.EventHandler(this.btnMethodCall_Click);
            // 
            // btnArg_Par
            // 
            this.btnArg_Par.Location = new System.Drawing.Point(136, 185);
            this.btnArg_Par.Name = "btnArg_Par";
            this.btnArg_Par.Size = new System.Drawing.Size(108, 55);
            this.btnArg_Par.TabIndex = 3;
            this.btnArg_Par.Text = "인수 인자";
            this.btnArg_Par.UseVisualStyleBackColor = true;
            this.btnArg_Par.Click += new System.EventHandler(this.btnArg_Par_Click);
            // 
            // btnVoidReturn
            // 
            this.btnVoidReturn.Location = new System.Drawing.Point(22, 246);
            this.btnVoidReturn.Name = "btnVoidReturn";
            this.btnVoidReturn.Size = new System.Drawing.Size(108, 55);
            this.btnVoidReturn.TabIndex = 4;
            this.btnVoidReturn.Text = "Void Retun";
            this.btnVoidReturn.UseVisualStyleBackColor = true;
            this.btnVoidReturn.Click += new System.EventHandler(this.btnVoidReturn_Click);
            // 
            // btnStringReturn
            // 
            this.btnStringReturn.Location = new System.Drawing.Point(136, 246);
            this.btnStringReturn.Name = "btnStringReturn";
            this.btnStringReturn.Size = new System.Drawing.Size(108, 55);
            this.btnStringReturn.TabIndex = 5;
            this.btnStringReturn.Text = "String Return";
            this.btnStringReturn.UseVisualStyleBackColor = true;
            this.btnStringReturn.Click += new System.EventHandler(this.btnStringReturn_Click);
            // 
            // btnIntReturn
            // 
            this.btnIntReturn.Location = new System.Drawing.Point(250, 246);
            this.btnIntReturn.Name = "btnIntReturn";
            this.btnIntReturn.Size = new System.Drawing.Size(108, 55);
            this.btnIntReturn.TabIndex = 6;
            this.btnIntReturn.Text = "Int Return";
            this.btnIntReturn.UseVisualStyleBackColor = true;
            this.btnIntReturn.Click += new System.EventHandler(this.btnIntReturn_Click);
            // 
            // btnDefaultToReturn
            // 
            this.btnDefaultToReturn.Location = new System.Drawing.Point(364, 246);
            this.btnDefaultToReturn.Name = "btnDefaultToReturn";
            this.btnDefaultToReturn.Size = new System.Drawing.Size(108, 55);
            this.btnDefaultToReturn.TabIndex = 7;
            this.btnDefaultToReturn.Text = "Default Return";
            this.btnDefaultToReturn.UseVisualStyleBackColor = true;
            this.btnDefaultToReturn.Click += new System.EventHandler(this.btnDefaultToReturn_Click);
            // 
            // Chap14_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDefaultToReturn);
            this.Controls.Add(this.btnIntReturn);
            this.Controls.Add(this.btnStringReturn);
            this.Controls.Add(this.btnVoidReturn);
            this.Controls.Add(this.btnArg_Par);
            this.Controls.Add(this.btnMethodCall);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Name = "Chap14_Method";
            this.Text = "메서드를 공부합니다";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTitle;
        private Label lblTitle;
        private Button btnMethodCall;
        private Button btnArg_Par;
        private Button btnVoidReturn;
        private Button btnStringReturn;
        private Button btnIntReturn;
        private Button btnDefaultToReturn;
    }
}