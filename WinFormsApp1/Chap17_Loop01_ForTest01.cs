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
    public partial class Chap17_Loop01_ForTest01 : Form
    {
        public Chap17_Loop01_ForTest01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sumi = 0;
            int Sumj = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Sumi += i;

                }
                else 
                {
                    Sumj += i;
                }
                      
            }
            MessageBox.Show($"짝수의 합은 {Sumi} 입니다 ");
            MessageBox.Show($"홀수의 합은 {Sumj} 입니다 ");
           /* for (int j =0; j <= 100; j++) 
                {
                    if (j % 2 != 0)

                    {
                        Sumj += j;                                      

                     }             

            }
            MessageBox.Show($"홀수의 합은 {Sumj} 입니다 ");*/
        }
    }
}
