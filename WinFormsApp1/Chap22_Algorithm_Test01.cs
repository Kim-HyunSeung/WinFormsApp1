using System;
using System.Collections;
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
    public partial class Chap22_Algorithm_Test01 : Form
    {
        public Chap22_Algorithm_Test01()
        {
            InitializeComponent();
        }


        
        private void btnSerach_Click(object sender, EventArgs e)
        {

            /* int[] list = { 1, 4, 6, 9, 10, 12, 16 };

             for (int i = 0; i <= 6; i++)
             {
                 for (int j = 0; j <= 6; j++)
                 {
                     if (list[i] + list[j] ==16) 
                     {

                         MessageBox.Show($"{list[i]} + {list[j]}={list[i]+list[j]}");                  
                     }                       
                 }
             }*/

            //-----------------------------------------------------------------------------------------------------



            /* int[] list1 = { 1, 4, 6, 9, 10, 12, 16 };


             for (int i =0; i < list1.Length-1; i++)
             {

                 if (list[i]%2==0) 
                 {

                     MessageBox.Show($"{list1[i]}, {}");
                     continue;
                 }


             }*/


            //-----------------------------------------------------------------------------------------------------------------------


             //인트 배열에 등록
            int[] list2 = { 1, 4, 6, 9, 10, 12, 16 };

            //찾은 항을 더해서 쌍을만듬
            string sValue = string.Empty;// empty이게 문자열에 공백을 해준다는 뜻, 따른방법으로""; 이렇게 넣어줘도됨


            //찾을 값의 인덱스 변수

            int iIndex = 0;

            //int i를 배열의 주소로 사용할int변수
            for(int i =0; i<list2.Length;i++) 
            {
                //16에서 현재 배열의 값을 차감 했을때 값 찾기.
                int iFindValue = 16 - list2[i];
               
                //찾는 값이 없을때는 -1을 반환하고 찾는 값이 있을때에는 해당 값을 반환.
                iIndex = Array.IndexOf(list2, iFindValue);

                if (iIndex == -1) 
                {
                    // 찾을값이 배열에 없을경우 다음 찾을 값을 찾는 배열로 돌아감.
                    continue;
                }
                // 찾은 결과 값의 쌍을 문자열에 보여줌
                sValue += $"{list2[i]},{iFindValue}\r\n";
            }
            //결과값을 확인
            MessageBox.Show(sValue);



//---------------------------------------------------------------------------------------------------------------



          /*  int[] a = { 1, 4, 6, 9, 10, 12, 16 };
            string c = string.Empty;
            int b = 0;

            for (int i = 0; i < a.Length; i++) 
            {
                int Sum = 16 - a[i];
               
                b= Array.IndexOf(a, Sum);// 값이있다면 넘어가고 없다면 -1을 반환

                if (b == -1) 
                {
                    continue;
                
                }
                
               c += $"{a[i]},{Sum}\r\n";
            }
                 MessageBox.Show(c);*/















        }
    }
}
