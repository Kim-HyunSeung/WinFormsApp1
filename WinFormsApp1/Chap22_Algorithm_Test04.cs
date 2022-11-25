using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace MyFirstCSharp 
{
    
        public partial class Chap22_Algorithm_Test04 : Form
        {
            // 난수 생성 클래스 객체 생성 
            Random Ran = new Random();
            int iClickCount = 0; // 마우스가 클릭 된 카운트. 
            int[] iValues = new int[3]; // 난수가 들어올 배열


            public Chap22_Algorithm_Test04()
            {
                InitializeComponent();
            }

            private void btnRandom_Click(object sender, EventArgs e)
            {
                // 0 부터 100 사이의 수를 임의로 추출한다. Next
                int iValue = Ran.Next(0, 100);


                if      (iClickCount == 0) txtRan1.Text = Convert.ToString(iValue);
                else if (iClickCount == 1) txtRan2.Text = Convert.ToString(iValue);
                else if (iClickCount == 2) txtRan3.Text = Convert.ToString(iValue);

                // iClickCount 를 이용하여 배열의 주소 에 값을 대입. 
                iValues[iClickCount] = iValue;

                // iClickCount 를 1씩 증가
                ++iClickCount;

                // 3개의 텍스트박스에 모두 난수 데이터가 생성 되었을 경우 
                //  다음 난수생성 클릭 시 에는 첫번째 텍스트박스 에 난수를 넣기 위하여 
                // iClickCount = 0 으로 초기화
                if (iClickCount == 3)
                {
                    iClickCount = 0;
                }
            }

            private void btnResult_Click(object sender, EventArgs e)
            {
                // 난수 가모두 생성 되었는지 확인. 
                foreach (Control MyControl in this.Controls)
                {
                    if (MyControl is TextBox && MyControl.Text == "")
                    {
                        MessageBox.Show("난수가 모두 생성 되지 않았습니다.");
                        return;
                    }
                }

                // 3 수의 합 을 통한 로직 구현. 
                Array.Sort(iValues); // 오름차순으로 정렬 

                int iSumValue = 0; // 난수 3개를 모두 더할 변수. 

                foreach (int iValue in iValues)
                {
                    iSumValue = iSumValue + iValue;
                }

                if (iSumValue < 100)
                {
                    // 수의 합이 100 미만일 경우
                    MessageBox.Show($"세 수 중 최소 값은 {iValues[0]} 이고 최대값은 {iValues[2]} 이며 곱은 {iValues[0] * iValues[2]} 입니다.");
                }
                else if (iSumValue >= 100 && iSumValue < 200)
                {
                    // 수의 합이 100 이산 200 미만일 경우
                    MessageBox.Show($"세 수 중 최소 값은 {iValues[0]} 이고 최대값은 {iValues[2]} 이며 합은 {iValues[0] + iValues[2]} 입니다.");
                }
                else
                {
                    // 그외 (200 이상일 경우)
                    MessageBox.Show("합이 200 이상입니다.");
                }


            }
        }
    }
