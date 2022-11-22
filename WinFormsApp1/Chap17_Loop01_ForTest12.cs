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
    public partial class Chap17_Loop01_ForTest12 : Form
    {

      
        public Chap17_Loop01_ForTest12()
        {
            InitializeComponent();
        }

        private void btnTwoMSum_Click(object sender, EventArgs e) //요기서 거를거를 걸려야됨.
        {

            SumNM(2);
        }

        private void btnFivMSum_Click(object sender, EventArgs e)
        {

            SumNM(5);
        }
        private void btnTenMSum_Click(object sender, EventArgs e)
        {
            SumNM(10);


        }
        void SumNM(int iValue) 
        {
            // 입력 할 값이 숫자로 변경  할 수 있는 문자 인지 확인.
            bool bStartF = false; // 시작 값이 숫자로 바뀌었는지 확인 여부.
            bool bEndF = false;   // 마지막 값이 숫자로 바뀌었는지 확인 여부.

            int iStart = 0;
            int iEnd = 0;

            bStartF = int.TryParse(txtStart.Text, out iStart);
            bEndF = int.TryParse(txtEnd.Text, out iEnd);

            if (!bStartF || !bEndF)
            {
                MessageBox.Show("숫자로 변경 할 수 없는 값을 입력하셨습니다.");
                return;
            }
            // 2. 음수 값을 입력했는지 확인
            if (iStart < 0 || iEnd < 0)
            {
                MessageBox.Show("음수 값은 입력 할수없습니다.");
                return;
            }

            // 3. 시작 하는 값이 종료 값보다 큰지 확인.
            if (iStart > iEnd)
            {

                MessageBox.Show("시작하는 값이 종료한 값보다 큽니다.");
                return;
            }
            // 4. 검출 과정이 끝났으니 정상 적으로 처리하는 로직.
            int Sum = 0;

            for (int i = iStart; i <= iEnd; i++)
            {
                if (i % iValue == 0)
                {
                    Sum += i;

                }
            }
            MessageBox.Show($"{iValue} 의 배수 합 : {Sum} 입니다");


        }
     
   



        
    }
}
