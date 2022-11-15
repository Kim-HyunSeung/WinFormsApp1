using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// namespace :클래스스 (라이브러리 : 어셈블리(ASSMBLE) : 프로젝트 : DML)
namespace MyfirstCSharp
{

    // 클래스 
    // 1. 객체지향 프로그램 언어를 이루는 가장 중요한 개념
    // 프로그램을 구현하는 설계도 역할을 한다
    // 설계도를 보고 같은 모양의 단위 부품을 필요에 의해 여러번 만들수 있듯이
    // 클래스 라는 파일을 생성해 두고 프로그램 내에서 필요에따라
    // 여러번 호출 하여 재사용 할 수 있다.
    // 객체화(인스턴스화) : 클래스(설계도) 를 바탕으로 실제로 구현 되어야 하는
    // 내용을 실행할 수 있도록 만드는 단계.

    // 클래스를 구성하는 요소(멤버)
    // 1. 필드 (멤버)
    // 2. 생성자(멤버)
    // 3. 메서드(멤버)

    internal class Chap10_Class //객체지향정리 <<이분을 말하면끝.
    {

       
        // 1. 생성자 멤버          //로직짬 가능
        public Chap10_Class()
        {
            MessageBox.Show("안녕하세요");
            //괄호안에서만 사용
            // 클래스 이름과 같은 특수 형태의 메서드입니다.
            // 클래스가 객체화 될때 실행되는 코드의 모음(묶음단위)

            //MessageBox.Show("안녕하세요.");
            //sValue = "반갑습니다.";
            //string sValue2 = "파이팅";
        }

        // 2. 필드 멤버              //로직짬 안됨
        // 클래스에서 사용되는 변수,객체 등을 기입 멤버                      //동급 개체안에서만 사용
        string sValue = "안녕하세요";
        int iValue = 10;

        public string sArm = "팔";

        // 3. 메서드(함수) 멤버    //로직짬 가능
         public void Method1()
        {
            MessageBox.Show("Class 객체의 메서드를 호출하였습니다. ");
        }

        // 필드멤버 : 클래스에서 사용되는 변수, 객체 를 관리하는 멤버
        // 메서드,생성자 멤버 : 실제로 실행되는 코딩, 로직이 구현되는곳
        // 생성자 멤버 : 클래스가 호출 될 때 자동으로 실행
        // 메서드 멤버 : 클래스를 호출 후 필요에 의해 별도로 호출하여 사용.
    }
}
