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

    // ForEach 문 : 조건의 끝을 지정해주는 반복문(for,while)과는 달리 
    // 인자로 들어오는 object 의 내부 인덱스 끝까지 알아서 순환을 해 주는 반복문.
    // 인자가 포함하는 내용의 수에 따라 반복하므로
    // 종료 조건이 따로 없어도 반드시 종료가 되는 반복문
    public partial class Chap19_Loop03_ForEach : Form
    {
        public Chap19_Loop03_ForEach()
        {
            InitializeComponent();
        }
        #region<문자열의 글자를 하나를 추출해 맞는지 확인>
        private void btnStringForEach_Click(object sender, EventArgs e)
        {

            // 라벨 에 적혀있는 문자열의 문자를 하나씩 추출한다.

            // 1. 텍스트박스에 입력한 문자가 한글자 인지 확인.

            if (txtStringForEach.Text.Length > 1)
            {
                MessageBox.Show("한글자 이상은 처리 할 수 없습니다.");
                return;
            }

            if (txtStringForEach.Text.Length < 1)
            {
                MessageBox.Show("공백을 입력하셨습니다.");
                return;
            }
            char sValue = Convert.ToChar(txtStringForEach.Text);// 입력한 문자열 받는변수


            string sTitle = label1.Text; // 라벨의 텍스트를 변수에 담기
            bool bFlag = false;
            //int a = 1;

            //문자열에서 한글자씩 추출하여 변수에 담는다.
            foreach (char chValue in sTitle)//첫번째 추출하는 단어의 공간, 두번째 끌어오는곳
            {
                if (sValue == chValue)
                {
                    MessageBox.Show($" 있다면{sValue} 문자는 포함되어 있습니다");
                    bFlag = true;
                }




            }
            if (!bFlag)
            {

                MessageBox.Show($" 없다면{sValue} 문자는 포함되어 있자않습니다");

            }
            #endregion

        }


        
        private void btnAFE_Click(object sender, EventArgs e)
        {
            //배열 의 내용을 추출 하는 방법.

            // 1. 배열을 생성.

            int[] iValues = new int[] { 11, 12, 13, 14 };

            int iCount = 0;  // int iCount = -1; 
            foreach (int Elem in iValues) 
            {
                             //++iCount;
                MessageBox.Show($"{iCount} 주소에는 값{Elem} 가 있습니다.");
                ++iCount;    
            }

        }

        private void btnOFE_Click(object sender, EventArgs e)
        {
            // 그룹박스에 포함되어있는 컨트롤을 하나씩 뽑아 로직을 구현.
            // 도구 상자에 사용되는 도구 클래스는 (control,component)라고 불린다.

            foreach (Control MyControl in grbTextBoxInit.Controls) 
            {
                // is 데이터 값의 비교(==)가 아닌 클래스 속성 의 참 거짓 여부를 판단함.
                if (MyControl is TextBox)
                {
                    MyControl.Text = "";


                }
               

            }


        }
    }
}
