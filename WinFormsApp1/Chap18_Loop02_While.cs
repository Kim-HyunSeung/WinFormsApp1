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
    public partial class Chap18_Loop02_While : Form
    {
        public Chap18_Loop02_While()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {

            // 1~100까지 합 while문 사용

            // 1. 조건 변수 생성
            int iCount = 0; // while 문이 실행되는 조건변수
            int iResult = 0; // 1부터 100까지의 합이 누적되는 변수.

            // 2. 조건으로 while 문 실행.
            
            
            while (iCount<=100) // iCount 값이 1000 이하일때까지 계속 반복해라
            {

                ++iCount;
                if(iCount >=20 && iCount <= 30)
                {
                    continue;//얘는 while이랑 for문에 영향을 준다. 외우자.
                }

                iResult += iCount;


                if (iCount > 1000)
                {
                    break;
                }

            }
            MessageBox.Show(Convert.ToString(iResult));
        
        }

        private void btnWhileRun_Click(object sender, EventArgs e)
        {

            // 무한 루프를 구현 해야 하는경우.
            // 서버의 채팅 내용을 나의 프로그램에서 지속적으로 표현해야 할때
            // 불규칙적으로 들어오는 데이터를 항상 관리 해야 하므로
            // 무한 루프를 이용하여 구현한다.

            // 무한 루프를 표현 할 때는 일반적으로 True(Bool)형태로 구현한다.

            // 1. 변수 생성
            int iCount = 0;
            int iResult = 1;
            while (true)
            {
                ++iCount;
              
                if (iCount >= 30 && iCount <= 50) 
                {
                    continue;
                }
                iResult += iCount;
                if (iResult > 1000) 
                {
                    break;
                }
            }

            MessageBox.Show(Convert.ToString(iResult));
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            // Do - while
            // 반복문을 실행을 하지만 무조건 최초 1회는 실행 될 수 있도록 해주는
            // 반복문

            int iCount = 1000;
            int iResult = 0;

            do
            {
                iResult += iCount;
                ++iCount;
            }

            while (iCount <= 100);
            MessageBox.Show(Convert.ToString(iResult));//1001
        
        }


    }
}
