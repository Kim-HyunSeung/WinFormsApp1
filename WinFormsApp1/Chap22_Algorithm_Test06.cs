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
    public partial class Chap22_Algorithm_Test06 : Form
    {
        public Chap22_Algorithm_Test06()
        {
            InitializeComponent();
        }

        private void btnFindAndReplace_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            int sValue = 0;
            int sCount = 0;
            string sResult = string.Empty;
            int iCount=0;
            for (int i = 0; i < sTitle.Length;i++)
            {

                
                if(i=='?') 
                {

                    if(i==1 || i==3)
                    {
                        sValue += i;

                    }
                    ++sCount;
                }
              


                if(i== sTitle.Length)
                {
                    break;

                }
                ++iCount;
            }
            sResult = sTitle.Substring(sValue,3);
            txtResult.Text = sTitle.Replace(sResult, "무궁화");
        }




        private void btnFindAndReplaceFor_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            int iFindCount = 0; //?를 찾은 횟수
            int iWordIndex = 0; //foreach가 추출한 문자의 인덱스
            int iResult = 0; //첫번째 ? 인덱스와 세번째 ? 인덱스 주소를 합칠 변수

            foreach (char cWord in sTitle)  //타이틀 문자열에서 한글자씩 추출
            {
                if (cWord == '?')
                {
                    ++iFindCount;
                    if (iFindCount == 1 || iFindCount == 3)
                        iResult += iWordIndex;
                    if (iFindCount == 1) break;
                  
                }
                ++iWordIndex;
                //다음 추출한 문자열의 인덱스 를 증가 1씩
                
           
            }
            string sValue = sTitle.Substring(iResult, 3);
            txtResult.Text = sTitle.Replace(sValue, "무궁화");
        }
    }
}
