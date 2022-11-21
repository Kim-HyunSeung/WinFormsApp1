using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstCSharp
{
    public partial class Chap16_Switch_Test : Form
    {

        int all = 0;
        int a1;
        int c1;
        int s1;
        public Chap16_Switch_Test()
        {
            InitializeComponent();

            a1 = int.Parse(lblA1.Text);
            c1 = int.Parse(lblA2.Text);
            s1 = int.Parse(lblA3.Text);
        }



        private void btnApple_Click(object sender, EventArgs e)
        {

         

            lblA1.Text = a1.ToString();


            a1 = a1-1;
            if (a1 <= 0)
            {

                MessageBox.Show("사과 주문을 할수 없습니다.");

                return;
            }

  

            else
            {
                all = all + 2000;
            }

        }

        private void btnCount1_Click(object sender, EventArgs e)
        {

          
            lblA2.Text = c1.ToString();
            if (c1 == 0 || c1-- < 0)
            {
                MessageBox.Show("참외 주문을 할수 없습니다.");
                return;
            }

            else
            {
                all = all + 2500;
               
            }



        }

        private void btnCount2_Click(object sender, EventArgs e)
        {
          
            lblA3.Text = s1.ToString();
            if (s1 == 0 || s1-- <0)
            {
                MessageBox.Show("수박 주문을 할수 없습니다.");
                return;
            }

            else
            {
                all = all + 2000;
            }

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show(all.ToString());
        }
           

        
    
    
    }
}



