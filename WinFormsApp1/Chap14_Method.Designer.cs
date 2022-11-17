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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCatch2 = new System.Windows.Forms.Button();
            this.btnCatch1 = new System.Windows.Forms.Button();
            this.btnArrayArg = new System.Windows.Forms.Button();
            this.btnArrayReturn = new System.Windows.Forms.Button();
            this.btnClassMCall = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(13, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "a";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCatch2);
            this.groupBox1.Controls.Add(this.btnCatch1);
            this.groupBox1.Location = new System.Drawing.Point(35, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "술래잡기";
            // 
            // btnCatch2
            // 
            this.btnCatch2.Location = new System.Drawing.Point(181, 22);
            this.btnCatch2.Name = "btnCatch2";
            this.btnCatch2.Size = new System.Drawing.Size(122, 53);
            this.btnCatch2.TabIndex = 1;
            this.btnCatch2.UseVisualStyleBackColor = true;
            this.btnCatch2.Click += new System.EventHandler(this.btnCatch2_Click);
            // 
            // btnCatch1
            // 
            this.btnCatch1.Location = new System.Drawing.Point(17, 22);
            this.btnCatch1.Name = "btnCatch1";
            this.btnCatch1.Size = new System.Drawing.Size(122, 53);
            this.btnCatch1.TabIndex = 0;
            this.btnCatch1.Text = "나 잡아 봐라~~";
            this.btnCatch1.UseVisualStyleBackColor = true;
            this.btnCatch1.Click += new System.EventHandler(this.btnCatch1_Click);
            // 
            // btnArrayArg
            // 
            this.btnArrayArg.Location = new System.Drawing.Point(22, 495);
            this.btnArrayArg.Name = "btnArrayArg";
            this.btnArrayArg.Size = new System.Drawing.Size(108, 55);
            this.btnArrayArg.TabIndex = 9;
            this.btnArrayArg.Text = "Array Argument";
            this.btnArrayArg.UseVisualStyleBackColor = true;
            this.btnArrayArg.Click += new System.EventHandler(this.btnArrayArg_Click);
            // 
            // btnArrayReturn
            // 
            this.btnArrayReturn.Location = new System.Drawing.Point(153, 495);
            this.btnArrayReturn.Name = "btnArrayReturn";
            this.btnArrayReturn.Size = new System.Drawing.Size(108, 55);
            this.btnArrayReturn.TabIndex = 10;
            this.btnArrayReturn.Text = "Array Return";
            this.btnArrayReturn.UseVisualStyleBackColor = true;
            this.btnArrayReturn.Click += new System.EventHandler(this.btnArrayReturn_Click);
            // 
            // btnClassMCall
            // 
            this.btnClassMCall.Location = new System.Drawing.Point(282, 495);
            this.btnClassMCall.Name = "btnClassMCall";
            this.btnClassMCall.Size = new System.Drawing.Size(160, 55);
            this.btnClassMCall.TabIndex = 11;
            this.btnClassMCall.Text = "Class Method Call";
            this.btnClassMCall.UseVisualStyleBackColor = true;
            this.btnClassMCall.Click += new System.EventHandler(this.btnClassMCall_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(22, 573);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(60, 40);
            this.btnRef.TabIndex = 12;
            this.btnRef.Text = "Ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnout
            // 
            this.btnout.Location = new System.Drawing.Point(88, 573);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(60, 40);
            this.btnout.TabIndex = 13;
            this.btnout.Text = "out";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // Chap14_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 698);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnClassMCall);
            this.Controls.Add(this.btnArrayReturn);
            this.Controls.Add(this.btnArrayArg);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Button btnCatch2;
        private Button btnCatch1;
        private Button btnArrayArg;
        private Button btnArrayReturn;
        private Button btnClassMCall;
        private Button btnRef;
        private Button btnout;
    }
}