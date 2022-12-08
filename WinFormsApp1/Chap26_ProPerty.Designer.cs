namespace MyfirstCSharp
{
    partial class Chap26_ProPerty
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
            this.btnBookIn = new System.Windows.Forms.Button();
            this.btnBookSale = new System.Windows.Forms.Button();
            this.txtBookCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBookStock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBookIn
            // 
            this.btnBookIn.Location = new System.Drawing.Point(26, 209);
            this.btnBookIn.Name = "btnBookIn";
            this.btnBookIn.Size = new System.Drawing.Size(234, 37);
            this.btnBookIn.TabIndex = 0;
            this.btnBookIn.Text = "서적 입고";
            this.btnBookIn.UseVisualStyleBackColor = true;
            this.btnBookIn.Click += new System.EventHandler(this.btnBookIn_Click);
            // 
            // btnBookSale
            // 
            this.btnBookSale.Location = new System.Drawing.Point(294, 209);
            this.btnBookSale.Name = "btnBookSale";
            this.btnBookSale.Size = new System.Drawing.Size(234, 37);
            this.btnBookSale.TabIndex = 1;
            this.btnBookSale.Text = "서적 판매";
            this.btnBookSale.UseVisualStyleBackColor = true;
            this.btnBookSale.Click += new System.EventHandler(this.btnBookSale_Click);
            // 
            // txtBookCount
            // 
            this.txtBookCount.Location = new System.Drawing.Point(26, 146);
            this.txtBookCount.Name = "txtBookCount";
            this.txtBookCount.Size = new System.Drawing.Size(112, 23);
            this.txtBookCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "개";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "현재 재고량";
            // 
            // lblBookStock
            // 
            this.lblBookStock.AutoSize = true;
            this.lblBookStock.Location = new System.Drawing.Point(382, 149);
            this.lblBookStock.Name = "lblBookStock";
            this.lblBookStock.Size = new System.Drawing.Size(14, 15);
            this.lblBookStock.TabIndex = 5;
            this.lblBookStock.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "개";
            // 
            // Chap26_ProPerty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBookStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookCount);
            this.Controls.Add(this.btnBookSale);
            this.Controls.Add(this.btnBookIn);
            this.Name = "Chap26_ProPerty";
            this.Text = "ProPerty 예제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBookIn;
        private Button btnBookSale;
        private TextBox txtBookCount;
        private Label label1;
        private Label label2;
        private Label lblBookStock;
        private Label label4;
    }
}