using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstCSharp
{
    public partial class adsadavv : Form
    {   
        Random Ran = new Random();      
        
        public adsadavv()
        {
            InitializeComponent();
        }

        private void btnLoPrice_Click(object sender, EventArgs e)
        {       
              int CPrice = Ran.Next(10000,500000); //초기 랜덤 금액
              int iBuy   = Ran.Next(100, 3000); //놀이기구 랜덤 이용 금액                           
              int iCount = Ran.Next(0, 20);  // 놀이기구 랜덤 이용 횟수
              int Jae=0;
            for (int i= 1; i<=iCount;i++)
            {              
                if (CPrice < Jae)
                {
                    for(i = 1; i <= iCount; i++)
                    {
                        Jae += i * iBuy;
                        MessageBox.Show($"{CPrice} 원이 있을때 이용요금{iBuy} 원 인 놀이기구를{i}번 타면 {CPrice - Jae}원이 모자랍니다 ");
                    }
                }
               else if (CPrice == Jae)
                {
                    continue;
                }
               else if (CPrice > Jae)
                {
                    for(i=1;i<= iCount;i++) 
                    {
                        Jae += i * iBuy;
                    }
               }
            }
            MessageBox.Show($"{CPrice} 만원이 있을때 이용요금{iBuy} 원 인 놀이기구를{iCount}번 타면 {CPrice - Jae}원이 남습니다 ");
        }

                
           



        
    }
}
