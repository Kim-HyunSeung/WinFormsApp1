using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class chap25_Exception_TryCatch : Form
    {
        public chap25_Exception_TryCatch()
        {
            InitializeComponent();
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            // 시스템 오류 만들기
            int[] iValues = { 1, 2, };
            MessageBox.Show(Convert.ToString(iValues[3]));
        }
    }
}
