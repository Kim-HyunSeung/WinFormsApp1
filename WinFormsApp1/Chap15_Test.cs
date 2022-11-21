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
    public partial class Chap15_Test : Form
    {

        int BtnC = 0;
        public Chap15_Test()
        {
            InitializeComponent();

          
        
        }

        public void btnJubge_Click(object sender, EventArgs e)
        {
            //버튼을 클릭한 총 횟수
            ++BtnC;
            txtBtnClickCount.Text = BtnC.ToString();
           
            
            string sTxtValue = txtInputValue.Text;
          

           int iTxtValue = 0;
           
            bool bFalg = false;
            
            bFalg = int.TryParse(txtInputValue.Text, out iTxtValue);
          

            if (!bFalg || iTxtValue < 1 || iTxtValue > 100)
            {
                MessageBox.Show("1과 100사이 값을 넣어주세요.");
                return;
            }

            // iTxtValue >= 1 && iTxtValue <= 100 &&

            else if (iTxtValue % 2 == 0 && iTxtValue % 5 == 0)
            {

                MessageBox.Show("2,5의 공배수 입니다..");

            }

            else 
            {          
                MessageBox.Show("2,5의 공배수가 아닙니다.");           
            }


            FineC(iTxtValue);

            void FineC(int iValue) 
            {

                if (iValue % 8 == 0)
                {
                    txtMultiE.Text = Convert.ToString(iValue * 8);


                }
                else 
                {
                    txtMultiE.Text = "";
                }
            
            }

        }
    }
}
