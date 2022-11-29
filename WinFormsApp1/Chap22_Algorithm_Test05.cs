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

            string sTitle = lblTitle.Text;
            sTitle = sTitle.Replace("{", ""); // 라벨에 있는 문자열에서 앞코딩은 있는것 뒷코딩은 바꾸는방법.
            sTitle = sTitle.Replace("}", "");
            sTitle = sTitle.Replace(" ", "");

            // 1,2,3,4,5,10,11,12
            string[] sValues = sTitle.Split(','); //콤마를 두고 양옆문자열을 나누는 방법

            // int 배열 생성 (문자 배열의 데이터 개수 만큼 방 만들기) 
            int[] iVlaues = new int[sValues.Length];

            // 문자 배열 정수 배열로 담기.
            for (int i = 0; i < sValues.Length; i++) //라벨에있는 문자열을 총 갯수로 반복 함
            {
                iVlaues[i] = Convert.ToInt32(sValues[i]);
            }

            // 정수 배열 정렬
            Array.Sort(iVlaues); //배열에 있는 값들을 적은수부터 정렬함.

            //1
            //2
            //3
            //8
            //8
            //8
            //13
            //13
            //15
            //15
            //17
            //19   
            //23



            // 중복 값을 찾은 횟수 Count
            int iFindCount = 0; 

            // 찾은 값을 누적 시킬 변수
            string sValue = string.Empty;

            // 찾은 이전 값 을 저장 시킬 변수. 
            int iFindValue = 0;

            // int i : 배열의 데이터 주소
            for (int i = 0; i < iVlaues.Length; i++)
            {
                // 배열의 마지막 데이터 인지 확인 ( 비교할 다음 데이터 가 없음 )
                if (i + 1 == iVlaues.Length)
                {
                    break;
                }

                // 지금 데이터와 다음 데이터 가 같은지 확인. 
                if (iVlaues[i] == iVlaues[i + 1])
                {

                    // 이전에 찾은 데이터와 다음 데이터가 같다 : 중복 데이터가 2개 이상일 경우
                    if (iFindValue == iVlaues[i + 1]) continue;

                    // 중복 데이터 찾은 횟수 증가.
                    ++iFindCount;

                    // 두번째 중복 값 일 경우는 체크 하지 않음. 
                    if (iFindCount == 2) continue;

                    // 첫번째 중복 값과 세번째 중복값 을 누적
                    sValue += Convert.ToString(iVlaues[i]) + " ";

                    // 세번째 중복 값을 찾았을 경우 Break;
                    if (iFindCount == 3) break;
                }

                // 이전 데이터 를 등록. 
                iFindValue = iVlaues[i];
            }

            // 첫번째 중복값 과 세번째 중복값 표현.
            MessageBox.Show(sValue);
        }

        //1
        //2
        //3
        //8
        //8
        //8
        //13
        //13
        //15
        //15
        //17
        //19   
        //23



    }

}
