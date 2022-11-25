using System; 
using System.Collections.Generic;
using System.Windows.Forms;

namespace CHAP04_MiddleExam
{
    public partial class Chap22_Algorithm_Test05 : Form
    {
        public Chap22_Algorithm_Test05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string M1;//메시지 박스에 담을 그릇
            string M2;
            int M3;
            string M4;
            string sTitle = lblTitle.Text; //라벨의 문자열변수에 넣어줌

            string[]s1 = { "{","}"," " };  //바뀔 문자
            string[]s2 = { "" ,"",""};  // 바뀐문자

           
            M1 = sTitle.Replace(s1[0], s2[0]);
            M2 = M1.Replace(s1[1], s2[1]);
            M4 = M2.Replace(s1[2], s2[2]);
            MessageBox.Show(M4);           //이렇게 할필요 없고 편리한 방법있음.

            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ요까지가 라벨 양쪽 괄호 없앤부분 이밑에부터 ㄱ

            // 1,2,3,4,5,10,11,12
            string[] sValues = sTitle.Split(',');

            // int 배열에 담기
            int[] iVlaues = new int[sValues.Length];


            for (int i = 0; i < sValues.Length; i++)
            {
                iVlaues[i] = Convert.ToInt32(sValues[i]);
            }

            // 정수 배열 정렬
            Array.Sort(iVlaues);

            for (int i = 0; i<iVlaues.Length; i++)
                {
                if()
                {


                }


            }










            // 다음 문자열에 포함된 수를 정수 배열로 만들고 중복 되는 수 중 낮은 수 의 첫번째 값과 세번째 값을 메세지 박스로 나타내세요.
            // 라벨에 입력 된  문자열을 받아 정수 배열로 만드는 로직을 작성할것
            // {1, 2 , 13, 15 , 17,  23,  8,  15, 8,  19,  3,  8,  13 }

        }
    }
}
