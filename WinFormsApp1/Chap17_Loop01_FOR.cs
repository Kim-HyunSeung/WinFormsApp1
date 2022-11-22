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
    public partial class Chap17_Loop01_FOR : Form
    {

        // 반복문
        // 특정한 조건을 만족 할 때 까지 반복하여 동일한 로직을 실행하는 문법.
        public Chap17_Loop01_FOR()
        {
            InitializeComponent();
        }

        private void btnFOR_01_Click(object sender, EventArgs e)
        {
            //1부터100까지 합하는 로직.

            // 1. 누적 값이 저장될 변수 생성
            int iSumValue = 0;

            // 2. 1부터100까지 더하는 반복문(FOR)
            //int i = 0;

            //for (int i = 0; i <= 100; i++) 첫번째는 초기값 두번째는 조건 세번째는 후위증감연산자
          
            for (int i = 0; i <= 100; i++) 
            {
                // 20부터 30까지의 수는 더하지 말자.
                if (i >= 20 && i <=30)
                {
                    continue;
                }
                
                
                iSumValue += i;

               /* if (iSumValue > 1000) 
                {
                    break;
                }*/                        //이 로직은 1000이상이됫을때 그만둠 하지만 결과값은 1000이넘어갈수있다.
                
            }


           // for (int i = 100; i > 0; i--) 
           // {
           //    iSumValue += i;
           // }
            MessageBox.Show(Convert.ToString(iSumValue));
      

        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            // 배열의 데이터수 만큼 for 문 반복 후 값 더하기.

            // 1. 임의의 배열 값 등록.
            int[] iValues = new int[] {10,20,30,50 };

            // 2. for 문을 통하여 iValues 배열에 있는 모든 값을 더하기.
            int iSumValue = 0; // 더한 값이 누적되어 등록될 변수.

            for (int i = 0; i < iValues.Length; i++) 
            {
                iSumValue += iValues[i];
            }
            MessageBox.Show(Convert.ToString(iSumValue));
        
        }

        private void btnGuGuDan_Click(object sender, EventArgs e)
        {
                   
            int i;
            int j;

            for ( i = 2; i <= 9; i++)
            {
                
                for ( j = 1; j <= 9; j++) 
                {
                 
                    //구구단 텍스틑 박스에 이전 값과 새로운 값을 합하여 표현
                    //\r\n: 줄바뀜
                    // \ : 문자열 안에서 로직을 실행할 수 있게 만들어주는기능
                    txtGuGuDan.Text +=   $"{i}*{j} ={i*j}\r\n";
                   
                }
               
            }
            
  
        
        }

        private void btnImmutable_Click(object sender, EventArgs e)
        {
            // ImmutableType(string) 과 MutableType(int)
            // string 데이터 타입은 Immutable 타입
            // int : 데이터 타입은 MutableType 
            // ImmutableType 은 저장되는 번지수만 늘어나서 데이터가 증가하는 형식(사라지지 않는 데이터)

            string sValue = string.Empty;

            for (int i = 0; i <= 100; i++) 
            {
                sValue += i.ToString();

            }
            MessageBox.Show(sValue);

            // string (ImmutableType)
            // 컴퓨터의 누적될때 컴퓨터의 성능이 좋아져서,  효율이 많이 떨어지지는 않지만,
            // 불필요한 메모리 공간이 많아지므로 StringBuilder 라는 기능을 사용할 것을 권장

            StringBuilder sBvalue = new StringBuilder();
            for(int i = 0; i<=100; i++)
            {
                sBvalue.Append(i.ToString()); // Append 새로운 문자열을 추가

            }
            MessageBox.Show(Convert.ToString(sBvalue));
            sBvalue.Clear(); //Clear는 기존 내용을 삭제.
        }
    }
}
