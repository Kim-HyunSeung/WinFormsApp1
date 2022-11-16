using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstCSharp
{


    // 접근 제한자를 사용하는 이유
    // -객체지향 프로그램이 지켜야할 내용중 **캡슐화 를 지키는 것이 목적
    // public 상태로 로직이 구현될 경우 클래스 객체의 사용자에 따라
    // 데이터의 변형을 일으키거나 정상적인 동작을 저해할 우려가 있고,
    // 중요한 코드의 보안을 유지 할 수 없으므로
    // 내부에서 만 중요하게 처리되는 내용은 외부에 공개 하지 않도록 함.


    partial class Chap11_AccessModfier
    {
        // 접근 제한자
        // Public      : 모든 클래스에서 접근할 수 있다.
        // private      : 해당 클래스 내에서만 접근할 수 있다.

        // Internal    : 동일한 네임스페이스(NameSpace)에서만 접근할수있다.
        // protected   : 파생 클래스(partial) 에서 접근이 가능.
        //               접근 제한자 부분에 기능을 설정하지 않았을때는
        //               기본으로 private 이 설정


        protected string sValue = "안녕하세요";


        public string sPublic = "Public string";
        private string sPrivate = "Private string";

    }




    //위아래 두개의 클래스를 하나의 클래스로 생각할수있다. 파티셜로 나눠둿을뿐
    //결국 같은 클래스임

    //partial class (분할 클래스, 파생 클래스)
    // 1. 클래스는 동일한 namespace에서 같은 이름으로 작성 할 수 없다.
    // 여러명이 같은 클래스를 동시에 개발하거나
    // 단위 별로 코딩을 나누어 개발 해야 할 경우
    // 같은 기능을 수행하는 클래스 임을 표현 하는 기능(키워드).
    partial class Chap11_AccessModfier
    //코딩으로 클래스를 만듬.

    //따른방법으로 솔루션탐색기에서 클래스를 생성하면 솔루션탐색기 칸에서 만든 클래스를 확인 할수있다.

    {
        public Chap11_AccessModfier()

        {
            sValue = "안녕하세요";
            sPublic = "데이터 변형 가능";
            sPrivate = "데이터 변형 가능";
        }
    }


    //프로젝트를 생성 될 경우 프로젝트에cs파일을 추가하는 방법이있고
    //코드 내에 클래스를 생성 하는 방법이 있음
    //여러개발자가 하나의 응용프로그램을 개발할경우
    //공통적으로 관리하는 Class 는 프로젝트에 추가(cs파일을 생성)하여 보여주고 
    //코딩 화면에서 개인적으로 사용할 클래스의 경우는 
    //namespace 묶음 단위안에 별도로 생성할수있다.
   
    
    class NewClass
    {
        
       
            //코드 내에 클래스를 별도로 생성하는 방법
            Chap11_AccessModfier CHAP11 = new Chap11_AccessModfier();

            public NewClass()
            {
                CHAP11.sPublic = "외부에서 데이터 변형가능";
                
            }
            // Chap11 sValue = "파이팅";

            //protected 로 전환한 sValue는
            //Chap11_AccessModfier의 파생 클래스 에서만 접근이 가능하다
                


    }
}
