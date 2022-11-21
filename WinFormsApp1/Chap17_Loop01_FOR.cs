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
    }
}
