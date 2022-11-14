namespace MyfirstCSharp
{
    partial class Chap08_Test
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
            this.btnName = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSmart = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(32, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(749, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "안녕하세요 2022 스마트팩토리 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 SMARTFACTORY 교육이 되었으면 합니다" +
    ".";
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(49, 121);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(205, 68);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "OOO -본인이름 변경";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(278, 121);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(205, 68);
            this.btnLocation.TabIndex = 2;
            this.btnLocation.Text = "SW 위치 찾기";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(489, 121);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(205, 68);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "문자열 앞 뒤 KDT 입력";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSmart
            // 
            this.btnSmart.Location = new System.Drawing.Point(49, 216);
            this.btnSmart.Name = "btnSmart";
            this.btnSmart.Size = new System.Drawing.Size(313, 68);
            this.btnSmart.TabIndex = 4;
            this.btnSmart.Text = "SMARTFACTORY 소문자로변경";
            this.btnSmart.UseVisualStyleBackColor = true;
            this.btnSmart.Click += new System.EventHandler(this.btnSmart_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(368, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(285, 68);
            this.button5.TabIndex = 5;
            this.button5.Text = "모든 공백 없애기";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(720, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 68);
            this.button6.TabIndex = 6;
            this.button6.Text = "문자 원본파일 되돌리기";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Chap08_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSmart);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap08_Test";
            this.Text = "문자열 나누기 Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnName;
        private Button btnLocation;
        private Button btnFirst;
        private Button btnSmart;
        private Button button5;
        private Button button6;
    }
}