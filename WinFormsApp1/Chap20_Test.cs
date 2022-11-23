using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstCSharp
{
    public partial class Chap20_Test : Form
    {
        public Chap20_Test()
        {
            InitializeComponent();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            int[,] iValue = new int[2, 4] { { 1, 2, 3, 4 },
                                           { 5, 6, 7, 8 } };

            int a = iValue.GetLength(0);//행

            int b = iValue.GetLength(1);//열

            int[,] c = new int[a, b];
            //iValue;


            //-----[1,0][1,1][1,2][1,3]부터 나와야댐
            /* for (a=1;a>-1; a--) 
              {

                  for (b=0;b<4;b++) 
                  {
                   

                      txtC1.Text +=Convert.ToString(iValue[a, b]);
                  }

                  txtC1.Text += "\r\n";              

              }*/


            int d = 0;
            for (int i = 1; i > -1; i--)
            {

                for (int j = 0; j <4; j++)
                {

                    //txtC1.Text += Convert.ToString(c[i, j]);
                    c[d, j] = iValue[i, j];               
                    txtC1.Text += Convert.ToString(c[d, j]); 
                   
                }
                txtC1.Text += "\r\n";
                ++d;
                //ㅇㅇㅇ
            }

        

        }
    }
}
