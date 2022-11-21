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
    public partial class Chap16_Switch : Form
    {
        public Chap16_Switch()
        {
            InitializeComponent();
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            // "사과" 입력 후 버튼 클릭할때 메세지 : 사과의 결과값은 1 입니다.
            // "참외" 입력 후 버튼 클릭할때 메세지 : 참외의 결과값은 2 입니다. 
            // "수박" 입력 후 버튼 클릭할때 메세지 : 수박의 결과값은 3 입니다.

            // if 문의 활용
            string sValue = txtFruit.Text;
            int iResult = 0;

            if (sValue == "사과")
            {
                iResult = 1;
                stringFruit(sValue, iResult);
            }
            else if(sValue == "참외")
            {
                iResult = 2;
                stringFruit(sValue, iResult);
            }
            else if (sValue == "수박")
            {
                iResult = 3;
                stringFruit(sValue, iResult);
            }
            else
            {
                stringFruit(sValue, iResult);
            }
        }
        
        void stringFruit(string sValue, int iResult)
        {
            MessageBox.Show($"{sValue}의 결과 값은 {iResult} 입니다.");
        }


        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // if 문으로 구현한 내용을 Switch 로 구현.
            string sValue = txtFruit.Text;
            int iResult1 = 0;

            switch (sValue) 
            {
                case "사과":
                    iResult1 = 1;          
                    break;
                case "참외":
                    iResult1 = 2;                 
                    break;
                case "수박":
                    iResult1 = 3;                  
                    break;

                default:  // 셋다 아닐때 이값이 나옴
                    iResult1 = 0;
                    break;

           
            }
                    stringFruit(sValue, iResult1);
        }
    }
}
