namespace Form_List
{
    partial class Form06_CustMaster
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVC = new System.Windows.Forms.TextBox();
            this.txtVN = new System.Windows.Forms.TextBox();
            this.cboC = new System.Windows.Forms.ComboBox();
            this.dgvgrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboC);
            this.groupBox1.Controls.Add(this.txtVN);
            this.groupBox1.Controls.Add(this.txtVC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvgrid);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "업체코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "업체명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "거래처구분";
            // 
            // txtVC
            // 
            this.txtVC.Location = new System.Drawing.Point(97, 41);
            this.txtVC.Name = "txtVC";
            this.txtVC.Size = new System.Drawing.Size(86, 21);
            this.txtVC.TabIndex = 3;
            // 
            // txtVN
            // 
            this.txtVN.Location = new System.Drawing.Point(284, 41);
            this.txtVN.Name = "txtVN";
            this.txtVN.Size = new System.Drawing.Size(86, 21);
            this.txtVN.TabIndex = 4;
            // 
            // cboC
            // 
            this.cboC.FormattingEnabled = true;
            this.cboC.Location = new System.Drawing.Point(500, 36);
            this.cboC.Name = "cboC";
            this.cboC.Size = new System.Drawing.Size(82, 20);
            this.cboC.TabIndex = 5;
            // 
            // dgvgrid
            // 
            this.dgvgrid.AllowUserToAddRows = false;
            this.dgvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvgrid.Location = new System.Drawing.Point(3, 17);
            this.dgvgrid.Name = "dgvgrid";
            this.dgvgrid.RowTemplate.Height = 23;
            this.dgvgrid.Size = new System.Drawing.Size(863, 377);
            this.dgvgrid.TabIndex = 0;
            // 
            // Form06_CustMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(869, 519);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form06_CustMaster";
            this.Text = "거래처 마스터";
            this.Load += new System.EventHandler(this.Form06_CustMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboC;
        private System.Windows.Forms.TextBox txtVN;
        private System.Windows.Forms.TextBox txtVC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvgrid;
    }
}
