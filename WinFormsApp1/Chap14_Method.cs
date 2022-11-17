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
    public partial class Chap14_Method : Form
    {


        // 메서드 즉 함수 와 리턴을 반환하는 결과 값 을
        // 데이터를 주는 값 : 인수,아규먼트
        // 데이터를 받는 값 : 인자,매개변수,파라미터
        // 아!수주 받자매 파
        // return : 메서드에서 처리한 어떠한 결과를 메서드를 결과를 호출한 부분으로 넘겨주는 것
        // ref, out,in : 매개변수로써 한정자
        public Chap14_Method()
        {
            
            InitializeComponent();
        }

        #region < 기본 메서드 호출>
         void btnMethodCall_Click(object sender, EventArgs e)
        {

            ShowMessage();

        }

        void ShowMessage()
        {
            MessageBox.Show("안녕하세요");
            txtTitle.Text = "안녕하세요";
            lblTitle.Text = "안녕하세요";
        }


        //버튼클릭할떄 버튼이벤트도 같이 복사될수있어서 확인하기

        #endregion
        //다 리즌을 다같이 열어보려면 ctrl + m + p 를 눌리면됨
        //반대 ctrl + m + o 눌리면됨

        #region<인수와 인자 값을 통한 함수의 호출 방법>

        private void btnArg_Par_Click(object sender, EventArgs e)
        {

            // 인수 : 값을 전달 하고 전달한 값을 인자로 처리하는 메서드 호출
            ShowMessage2("오늘도 화이팅"); // 정수값을 넣었을때 문자열이기떄문에 오류가남

            string sVaue = "반갑습니다";
            ShowMessage2(sVaue); //sMessage = sValue
        }
       
           void ShowMessage2(string sMessage) //괄호안의 내용은 스트링형식으로 받는다는말 그릇은 smessage
        {
            
            MessageBox.Show(sMessage);
            txtTitle.Text = sMessage;
            lblTitle.Text = sMessage;  

        }



        #endregion

        #region< 아무 값을 반환하지 않는 리턴 >

        private void btnVoidReturn_Click(object sender, EventArgs e)
        {

            ShowMessage3("버튼 3번째 입니다");

        } //보이드가 있을경우 리턴값은 아뭇것도 가지지않음
                                                                        

        private void ShowMessage3(string sMessage)
        {
            MessageBox.Show(sMessage);
            txtTitle.Text = sMessage;
            return;           // Return 함수(메서드)의 종료부분 처럼 보이지만 반환할 값이 없는 상태로
                              // 호출한 곳으로 결과값을 보내주는 구문
                              // 즉 아무런 결과값을 가지지 않고 호출하는곳으로 돌아가는 형식
            lblTitle.Text = sMessage;
            
        }


        #endregion


        #region <String 값을 반환하는 리턴>
       
        private void btnStringReturn_Click(object sender, EventArgs e)
        {  //   4                        1                               //로직이 실행되는 순서를 나타냄.
           string sResult = ShowMessage4("안녕하세요");
           //   5
            MessageBox.Show(sResult);      //리턴의 결과값 성공이라는 말이 요기서 뜬다.



        }
        private string ShowMessage4(string sMessage) //메서드 앞에 데이터타입이 있을경우 return 값을 데이터 타입에 맞춰서 리턴
        {
            //    2         
            MessageBox.Show(sMessage);
            //    3
            return  "성공";
            

        }
        #endregion
    
    }
}
