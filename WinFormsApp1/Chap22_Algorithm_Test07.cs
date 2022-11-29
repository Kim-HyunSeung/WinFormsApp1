using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap22_Algorithm_Test07 : Form
    {
        public Chap22_Algorithm_Test07()
        {
            InitializeComponent(); 
        }
 
        private void btnDesc_Click(object sender, EventArgs e)
        {

            string sTitle = lblTitle.Text;// 라벨을 문자열로만듬
            sTitle = sTitle.Replace(" ", ""); //라벨에 공백을 없애줌

            string[] sValues = sTitle.Split(','); // 라벨을 콤마를 두고 양옆으로 나눔

            int[] iValue = new int[sValues.Length]; //깡통 배열변수임
            int iValue2 = 0; //값이 임의로 저장할 외부변수가 필요.
            
       


            foreach(string cWord in sValues)
            {
                iValue[iValue2] = Convert.ToInt32(cWord);
                iValue2++;

            } //{ 1, 11, 6, 20, 11, 8, 12, 6, 16, 13, 22} 이렇게 담김

            int iValue3 = 0;
            for (int i =0; i< iValue.Length; i++) // i를 길이만큼돌림
            {
                for(int j= i + 1; j< iValue.Length; j++) //j는 i값 바로뒷값임 
                {
                    if(iValue[i] < iValue[j])//i 와j를 비교해서 i값이 더작으면 j 값이 앞으로 들어가야댐
                    {
                        iValue3 = iValue[i];
                        iValue[i] = iValue[j];
                        iValue[j] = iValue3;
                                                                 
                    }             
                 
                }           
            }
            foreach (int AAA in iValue)
            {
                txtDesc.Text += Convert.ToString(AAA) +",";

            }          
        }
    } 

}
