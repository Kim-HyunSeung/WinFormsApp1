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

namespace MyFirstCSharp
{
    public partial class Chap17_Loop01_ForTest02 : Form
    {
        public Chap17_Loop01_ForTest02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1부터 100까지 수중 짝수의 총합 과 홀수 의 총 합 구하는 로직.
            int iOdd = 0; // 홀수 값을 더해서 표현 할 변수
            int iEven = 0; // 짝수 값을 더해서 표현 할 변수
            
            int iValue = 0;
            for (iValue = 0; iValue <= 100; iValue++) 
            {
                if (iValue % 2 == 0) // 만약에 i에 들어온 값을 2로 나누어 나머지가 0이라면 (짝수)
                {
                    iEven += iValue;

                }
              else
                {
                    iOdd += iValue;
                }

               
            }
            MessageBox.Show($"총 반복 횟수는 : {iValue - 1}입니다");
            MessageBox.Show($"짝수의 합은 : {iEven}입니다");
            MessageBox.Show($"홀수의 합은 : {iOdd}입니다");

        }
    }
}
