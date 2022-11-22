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
    public partial class Chap17_Loop01_ForTest11 : Form
    {



        public Chap17_Loop01_ForTest11()
        {
            InitializeComponent();
        }

        private void btnTwoMSum_Click(object sender, EventArgs e)
        {

            // 1. 축약할꺼는 축약하자
            bool a = false;
            bool b = false;

            int A=0;
            int B=0;
            
            a = int.TryParse(txtStart.Text, out A);
            b = int.TryParse(txtStart.Text, out B);

            if (!a || !b) 
            {
                MessageBox.Show("알맞는 값이 아닙니다.");
                return;
            }

            if (A<0 || A<0) 
            {
                MessageBox.Show("양수 값이 아닙니다.");
                return;
            }



        }

        private void btnFivMSum_Click(object sender, EventArgs e)
        {

            
        }
        private void btnTenMSum_Click(object sender, EventArgs e)
        {

            
        }

   
             

    }
}
