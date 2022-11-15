using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstCSharp
{
    partial class Chap11_AccessModfier
    {
        // 접근 제한자
        // Public      : 모든 클래스에서 접근할 수 있다.
        // prybit      : 해당 클래스 내에서만 접근할 수 있다.

        // Internal    : 동일한 네임스페이스(NameSpace)에서만 접근할수있다.
        // protected   : 파생 클래스(partial) 에서 접근이 가능.

        protected string sValue = "안녕하세요";

    }
                                                                            //위아래 두개의 클래스를 하나의 클래스로 생각할수있다. 파티셜로 나눠둿을뿐
                                                                            //결국 같은 클래스임
     partial class Chap11_AccessModfier   //코딩으로 클래스를 만듬.
                                          //따른방법으로 솔루션탐색기에서 클래스를 생성하면 솔루션탐색기 칸에서 만든 클래스를 확인 할수있다.

    {
        public Chap11_AccessModfier()

        {
            sValue = "안녕하세요";         
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
        public NewClass()

        {
            Chap11_AccessModfier Chap11 = new Chap11_AccessModfier();
               // Chap11 sValue = "파이팅";

            //protected 로 전환한 sValue는
            //Chap11_AccessModfier의 파생 클래스 에서만 접근이 가능하다
        }

        //코드 내에 클래스를 별도로 생성하는 방법
    }
}
