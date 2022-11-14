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
    public partial class Chap03_DataTypeChang : Form
    {
        public Chap03_DataTypeChang()
        {
            InitializeComponent();
            
        }

        private void btnChangeStoI_Click(object sender, EventArgs e)
        {
            // 숫자를 문자로 형변환 하는 로직 실습.
            // btnChangeStoI.Text = "문자 형변환 실행.";

            // 변환 될 대상 숫자 형식 변수 생성.
            // 대입하는 값 = 리터럴.
            int iValue1 = 10;
            int iValue2 = 20;
            double dValue1 = 10.1;
            double dValue2 = 20.1;

            // 변경되는 문자가 담기는 변수 생성
            string sValue1;
            string sValue2;

            // 1. .ToString() 메서드를 호출하여 변환.
            sValue1 = iValue1.ToString();
           

            #region [ 변수를 사용하여 변환 로직을 한번만 실행]
            // sValue2 에 dValue2 를 형변환하여 대입해 보세요.
            sValue2 = dValue2.ToString();

            // 메세지 박스로 변경된 데이터 확인.
            MessageBox.Show(sValue2);
            #endregion

            // 메세지 박스를 호출 하되 dValue2(실수) 를 곧바로 표현하는
            // 로직을 한줄로 구현해 보세요.
            MessageBox.Show(dValue2.ToString());

            #region [변환 로직을 두번 실행하여 결과값 표현 리소스 낭비의 예제]
            sValue1 = "0";
            // 메세지박스를 호출하되 dValue2(실수)를 곧바로 표현하는
            // 로직을 한줄로 구현해 보세요.
             MessageBox.Show(dValue2.ToString());
             sValue1 = dValue2.ToString();

             MessageBox.Show(sValue1);

           /* string sValue5 = dValue1.ToString();
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);
            MessageBox.Show(sValue5);*/

            #endregion

            //2. Convert. ToString() 으로 변환
            sValue1 = Convert.ToString(iValue1);
            MessageBox.Show(sValue1);

            // 예제) 문자열의 합.
            MessageBox.Show(sValue2 + dValue1.ToString());
        }

        private void btnChangeStoL_Click(object sender, EventArgs e)
        {
            // 문자를 숫자로 변경한다.

            // 숫자로 바꿀 문자열 변수 생성.
            string sValue1 = "안녕하세요";
            string sValue2 = "10";
            string sValue3 = "10.1";

            // 1. .Parse() 기능으로 변환.
            
            
            //int iValue1 = int.Parse(sValue1);// 오류 발생
            int ivalue2 = int.Parse(sValue2); // 오류 발생 x
            //int ivalue3 = int.Parse(sValue3); // Double 형식을 int 형 변환 오류
            //int ivalue4 = double.Parse(sValue3); //Double 형변환 성공하였으나 int 에 담지 못함 오류
            double dValue1 = double.Parse(sValue3);
            MessageBox.Show(dValue1.ToString());


            // 2. Convert. To ***()로 qusrud
            int iValue5 = Convert.ToInt32(sValue2);
            MessageBox.Show(iValue5.ToString());
           
            MessageBox.Show(Convert.ToString(iValue5 + iValue5));
           
            double dValue2 = Convert.ToDouble(sValue3);
            MessageBox.Show(Convert.ToString(dValue2 +dValue2));


            string svalue6= Convert.ToString(sValue1);
            MessageBox.Show(svalue6);
            

            //int iValue6 = Convert.Toint32(sValue3); 소수라서 안됨



            // parse()와 Convert. To***()를 사용하여
            // 문자를 숫자로 변환할때
            // 문법상으로는 오류가 없으나.
            // 프로그램 실행 시 시스템 오류가 발생하므로
            // 숫자로 변환 할 수있는 문자인지 체크(검증)하는
            // 로직이 필요.

            // 3. 정수/소수 로 변환할 수 있는 문자열인지 
            // 검증하는 기능 . TryParse();


            //"안녕하세요" 문자열을 int 형으로 변환시 
            // 변환할수 없는 문자 이므로 iResult에 0값을 반환
            // 시스템 오류를 발생하지 않는다.

            int iResult; // 문자가 변환된 정수 값을 받을 변수 
            bool bTorF;

            bTorF = int.TryParse(sValue1,out iResult);
            MessageBox.Show(Convert.ToString(iResult));

            sValue1 = "0";
            bTorF = int.TryParse(sValue1, out iResult);//중요하다
            MessageBox.Show(Convert.ToString(iResult));

            // TryParse() 는 변환의 결과값(int) 과
            // 성공 또는 실패의 값(Bool)
            // 을 동시에 변환하여
            // 반환 값이 0이라도 성공/실패 에 의한
            // 결과 인지 검증할수 있다.

            // "10"이라는 문자를 정수에 담아서 표현하므로
            // 정상적인값 10을 확인 할 수 있다.
            int iResult2; 
            int.TryParse(sValue2,out iResult2);
            MessageBox.Show(Convert.ToString(iResult2));

            //"10.1" 이라는 문자 를 소수형 데이터 타입
            //에 검증후 대입.
            double dResult3;
            double.TryParse(sValue3, out dResult3);
            MessageBox.Show(Convert.ToString(dResult3));

            // 정수를 + 연산자로 처리할 경우
            int iValue6 = 10;
            int iValue7 = 20;
            MessageBox.Show(Convert.ToString(iValue6 + iValue7));

            string sa1 = Convert.ToString(iValue6);
            string sa2 = Convert.ToString(iValue7); 
            
            MessageBox.Show(sa1+sa2);   


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 여러 줄 주석 처리. /*      */
            /*
             - Covert.Tostring() 구문은 변수의 값이 null
                일 경우 빈값으로 반환하는 예외 로직이 
                포함 되어 있다.
             - .ToSrting()보다는 Convert.ToString()
                으로 형변환 하는것을 권장.

             - NULL
               데이터의 용량(메모리) 자체가 주어지지 않은
               이름만 가지고 있는 변수가 생성
               ""는 빈 공백의 데이터가 있는 상태를 말한다.
               * 숫자형 데이터 는 NULL 값을 가질수 없다.
               경우에 따라서는 데이터 타입에 ? 키워드를 추가하여 
               NULL 로 처리 할수 있다. */

            int? ivalue = null;
            string sValue = null;// 이거 안됨 대신에 string 뒤에 ? 있으면 가능

            MessageBox.Show(Convert.ToString(sValue));
            //MessageBox.Show(sValue.ToString());
        }
    }
}
