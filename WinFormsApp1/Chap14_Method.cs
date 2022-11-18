using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        // 리턴값을 호출한곳으로 되돌려보내는것 종료하는건 아님
        
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

       public void ShowMessage()
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
            MessageBox.Show(sMessage);  //Show 는 static형식으로 초반에 지정되어잇음 메세지박스는 클래스형식임.
            //    3
            return  "성공";
            

        }
        #endregion


        #region<Int 값을 반환하는 리턴>
        private void btnIntReturn_Click(object sender, EventArgs e)
        {
            int iValue1 = 10;
            int iValue2 = 20;

           
            //IntSum(iValue2, iValue1); //벨류이름이 같아도 순서가 위아래 틀려도 순서 그대로 2->1 1->2 이렇게받음.
            
            
            int a = IntSum(iValue2, iValue1);

            MessageBox.Show(Convert.ToString(a)); //메세지 박스에 표현해줘야하기때문에 정수를 형변환시켜서 표현.

        }
        #endregion


      
        int IntSum(int iValue1,int iValue2)
        {
            
            return iValue1 + iValue2;
            // iValue1 = 25;
            // *************************************
            // 인수와 인자 의 변수 이름이 같다고 하더라도
            // 주고 받는 위치에 따라 값이 대입 된다.

            //MessageBox.Show(Convert.ToString(iValue1+iValue2));
          

        }
        #region<인자가 기본값을 가지는 함수의 결과를 반환하는 리턴 메서드>(선택적 인수)
        private void btnDefaultToReturn_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show(Convert.ToString(IntSum2(10,20,50))); // 괄호안(a,b) //반복연습 해보자
        }                                         //요기에 세개의 값이 들어가있을경우 밑에 정수값을 대입하려고해도 위에먼저 되기
                                                  //때문에 80이 출력됨.

        #endregion
        private int IntSum2(int iValue1 , int iValue2 ,int iValue3 = 20) //3개의 변수가있을때 가운데 숫자를넣으면 위쪽에서 인식불가
        {

            // 인자 int ivalue2 에 20을 기본값으로 대입한 메서드 인경우
            // IntSum2 을 호출 하는 부분에는 ivalue2 이 들어갈 인수값을 등록하지 않아도 된다

            return iValue1 + iValue2 + iValue3;

            //인자값에 기본값을 설정할 경우 중간에 있는 인자에만
            //기본값을 설정 할 수없다.
            //마지막 인자는 반드시 기본값을 설정하는 인자여야만 한다.
        }

        #region< 클래스를 인수로 전달 하는 경우, 간단한 게임>
        private void btnCatch1_Click(object sender, EventArgs e)
        {
            CatchGameMedhod(btnCatch1,btnCatch2);

        }

        private void btnCatch2_Click(object sender, EventArgs e)
        {

            CatchGameMedhod(btnCatch2, btnCatch1);


        }
        private void CatchGameMedhod(Button btn_Catch1, Button btn_Catch2)
        {
            btn_Catch1.Text = "";
            btn_Catch2.Text = "나잡아봐라";
            //messagebox.show()

        }
        #endregion


        #region< 인수를 배열로 전달하는 경우 >
        private void btnArrayArg_Click(object sender, EventArgs e)
        {

            string[] ArrString = { "안녕하세요", "반갑습니다", "시작프로그래밍" };
            ShowMessage6(ArrString);
        }

        private void ShowMessage6(string[] sArrayString)
        {

            MessageBox.Show(sArrayString[0]);
            txtTitle.Text = sArrayString[1];
            lblTitle.Text = sArrayString[2];

        }


        #endregion


        #region< 배열을 리턴 하는 경우 >
        private void btnArrayReturn_Click(object sender, EventArgs e)
        {
            // 1. 배열 인자 생성.
            int[] iArray = { 10, 20 };

            // 2. 메소드 호출
            iArray = IntSum3(iArray);

            MessageBox.Show($"[0] : {iArray[0]} , [1] : {iArray[1]}");

        }

        private int[] IntSum3(int[] iArray)
        {
            // 배열 인수를 일정한 값과 합하는 메서드,
            int[] isumInt = { 5, 10 };
            isumInt[0] = isumInt[0] + iArray[0];
            isumInt[1] += iArray[1];

            return isumInt;


        }
        #endregion


        #region< 다른 클래스의 함수 호출 >
        private void btnClassMCall_Click(object sender, EventArgs e)
        {

            //new클래스를 객체화 또는 인스턴스
            New_Class new_Class = new New_Class();       
            MessageBox.Show(new_Class.IntSum(40).ToString());

            //New_Class IntSum(10,20);
        }
        #endregion

        #region< ref인자 반환(값 참조) ,read >
        private void btnRef_Click(object sender, EventArgs e) //**중요하다 이해하기

        {
            // ref
            // ref 인수값을 참조형식으로 변형시켜 ref인자와 같은 데이터 주소(값) 을 바라볼수있도록
            // 만들어놓은 키워드

            // ref 키워드의 인수를 사용하기 위해서는 반드시 값이 할당되어있는 상태여야 한다

            //int iA_ValueRef - ref로 사용되어야할 인수는 반드시 초기화가 되어있어야한다.
            int iA_Value = 13;
            int iA_ValueRef = 20; //값이 대입되어 있지않을경우 ref를 사용할수없다.


            MessageBox.Show($"인수 iA_Value 값은 : {iA_Value}");      //1    13이나옴
            MessageBox.Show($"ref 인수 iA_ValueRef 의 값은 : {iA_ValueRef} ");//2    20이나옴
           
            RefMethod(iA_Value,ref iA_ValueRef);

            MessageBox.Show($" iA_Value 값은 : {iA_Value}"); //5  13 이나옴
            MessageBox.Show($" iA_ValueRef 의 값은 : {iA_ValueRef} ");//6  13  가나옴
        }

        private void RefMethod(int iP_Value, ref  int iP_ValueRef)
        {
            MessageBox.Show($"ref인자 ip_iP_Value 값을 넣어라 : {iP_ValueRef}");//3   20
            iP_ValueRef = iP_Value; 
            iP_Value = 10; 
            MessageBox.Show($"ref인자 ip_iP_Value 값을 넣어라 : {iP_ValueRef}");//4   13
        }
        #endregion


        #region<ref 인자 반환, 값을 할당하지 않는out 인자.write>
        private void btnout_Click(object sender, EventArgs e) //이해하자.
        {
            // Out 키워드를 인수값을 초기화 할 필요가 없다
            // 인자변수는 메서드 내에서 반드시 초기화(데이터값이 초기화 되어야한다)

            int iA_Value = 1;
            int iA_ValueOut = 10; //out는 대입 값이없어도 실행된다 //ex)변수;

            OutMethod(iA_Value, out iA_ValueOut);

            MessageBox.Show($"iA_Value 값은 : {iA_Value}"); //1
            MessageBox.Show($"iA_iA_ValueOut 값은 : {iA_ValueOut}"); //1

        }
        private void OutMethod(int iP_Value, out int iP_ValueOut) 
        {
            // 메서드 내에서 인자 iP_ValueOut에 값을 할당 하지 않으면 오류가 발생
            iP_ValueOut = iP_Value;
            iP_Value = 30;
          
            MessageBox.Show($"Out 인자 iP_ValueOut 의 값은 : {iP_ValueOut}"); //1


        }
        #endregion


        #region< In 형식의 인자 설정, ReadOnly >
        private void btnIn_Click(object sender, EventArgs e)
        {
            // In 인자 타입
            // 읽기전용 속성으로 변경. 수정을 할수 없다.
            int iValue = 10;
            InMethod("문자인수", in iValue);

        }

        private void InMethod(string sValue, in int iValue)
        {

            MessageBox.Show(Convert.ToString(iValue));
           
            // iValue 는 In 타입 이므로 수정 또는 변경을 할 수 없다.
            // iValue = 10;

        }

        #endregion


        #region< 메서드 OverLoding >
        private void btnOverLoding_Click(object sender, EventArgs e)
        {
            // Over Loding
            // 예를 들어 인자를 메세지 박스로 표현하는
            // 일을 해야하는 메서드가 있다고 할때
            // 같은 메소드 이름으로 인자 데이터 변수
            // 및 개수를 다르게 하여 여러 상황에 
            // 맞게 사용 할 수 있게 만드는 기능.

            ShowMessageOL1("안녕하세요", "반갑습니다");

            // 정수형으로 인수 인자 값을 처리하는 메서드를 만들기 위해서는
            // 메서드 이름이 다른 기능을 따로 구현해야한다.
            // 즉, 반환하는 결과는 같지만 상황에(인수,인자값의 변화) 따라서
            // 여러가지 이름의 메서드를 만들어야 한다.
            ShowMessageInt(10, 20);

            ShowMessageOL1(10, 20);
        }

        private void ShowMessageOL1(string sValue1, string sValue2) 
        {
            MessageBox.Show(sValue1 + sValue2 );
        }

        private void ShowMessageInt(int iValue, int iValue2)
        {
            MessageBox.Show(Convert.ToString(iValue) + Convert.ToString(iValue2));
        }

        private void ShowMessageOL1(int iValue, int iValue2) 
        {
            MessageBox.Show($"{iValue}{iValue2}");
        }
        #endregion


        #region< Out 참조전달 방식을 이용한 TryParse 메소드 만들어보기 >
        private void btnTryParse_Click(object sender, EventArgs e)
        {
           
             string sValue = "445"; // 숫자로 변경 될 문자
             int iResult; // 변경된 숫자가 담기는 정수 변수.
             bool bFlag; // TryParse 의 결과 가 담기는 변수*/

            //TryParse의 기능 복기
            bFlag = int.TryParse(sValue, out iResult);

            

            //TryParse 기능 구현 실습

            bFlag = Int_.TryParse(sValue, out iResult);
            MessageBox.Show($"결과는 {bFlag} 이고, 값은 {iResult} 입니다");
        }


        #endregion


        #region< 일반화 메소드 Generic Method >
        private void btnGenericMethod_Click(object sender, EventArgs e)
        {
            // 같은 기능을 하는 메서드가 인자의 데이터 타입만 바뀌는 경우
            // 인자의 데이터 타입이 같은 메서드를 데이터 타입에 따라
            // 오버로딩 할 경우에는 
            // 메서드 일반화 를 통하여 여러 데이터 타입의 인자를 처리하는
            // 메서드를 하나만 만들어서 관리 할 수 있다.

            // StringSum("안녕하세요", "반갑습니다");  //안녕하세요_반갑습니다

            G_StringSum<string>("안녕하세요", "반갑습니다");
            G_StringSum<int>(100, 200);
            G_StringSum<Double>(100.1, 200.2);
            G_StringSum<char>('마', '늘');
        }

        void StringSum(string sValue, string sValue2) // 사용하고있다
        {
            MessageBox.Show($"{sValue}_{sValue2}");


        }
        void StringSum(int iValue, int iValue2) // 사용하지않고있다
        {
         
            MessageBox.Show($"{iValue}_{iValue2}");
        }

        // 인수 인자 개수도 같은데 데이터 타입만 바뀔경우는
        // 메서드를 하나만 만들어서 구현 할 수 있다.
        //Generic Method

        void  G_StringSum<T>(T gValue, T gValue2) 
        {
         
            MessageBox.Show($"{gValue}_{gValue2}");
        }
        
        #endregion

    }


    class New_Class    
    {
        //수를 더하는 new 클래스 메서드
       public  int IntSum(int iValue1, int iValue2 = 20)
        {
           
            return iValue1 + iValue2;

        }


        // 모든 클래스에서 사용할수 있는 메모리의 상주
        //또는 정적으로 머물러 있는 정수 결과 반환 타입의
        //엔트 투 썸 메서드를 만들며
        //인자 값으로는 인트형 데이터 타입을 두개 받는 메서스
        public static int IntSum2(int iValue1, int iValue2)
        {

            return iValue1 + iValue2;
        }
    
    }

    class Int_
    {
      public static bool TryParse(string sValue, out int iResult) 
        {
            try
            {
                iResult = int.Parse(sValue);
                return true;
            }

            catch 
            {
                iResult = 0;
                return false;
            
            }

            
       
        }
    
    }




}


