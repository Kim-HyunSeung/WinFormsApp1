namespace MyfirstCSharp
{
    partial class adsadavv
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
            this.btnLoPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoPrice
            // 
            this.btnLoPrice.Location = new System.Drawing.Point(172, 301);
            this.btnLoPrice.Name = "btnLoPrice";
            this.btnLoPrice.Size = new System.Drawing.Size(308, 48);
            this.btnLoPrice.TabIndex = 0;
            this.btnLoPrice.Text = "부족 금액 계산";
            this.btnLoPrice.UseVisualStyleBackColor = true;
            this.btnLoPrice.Click += new System.EventHandler(this.btnLoPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "N 번 이용하면 원래 이용료의 N 배를 받는 놀이기구가있다고 할때";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "가진 금액, 놀이기구 반복횟수, 놀이기구 최초 가격 을 랜덤 난수로 함수에 전달하고";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(650, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "\"AA 원이 있을때 이용요금 BB 인 놀이기구를 CC 번 타면 DD 원이( 모자랍니다.또는남습니다.)\" 를 메세지로 표현하세요.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ex)10000 원이 있을때 이용요금 100 원 인 놀이기구를 4번 타면 9000 원이 남습니다.\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "*놀이기구 이용료는 최소 100 원부터 3000 원까지 랜덤하게 주어진다.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "*놀이기구 타는 횟수는 1번부터 20번까지 랜덤하게 주어진다.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "*초기 금액은 1만원 에서 50만원 까지 랜덤하게 주어진다.";
            // 
            // adsadavv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoPrice);
            this.Name = "adsadavv";
            this.Text = "adsadavv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}