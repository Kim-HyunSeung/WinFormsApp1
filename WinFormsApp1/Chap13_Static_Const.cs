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

    /* Static 한정자
        
    프로그램 전체에서 유기적으로 사용해야 되는 값이 발생할 경우
    객체의 생성없이 클래스내의 필드값 을 직접적으로 관리 할수 있음
    클래스의   있는 필드와 메서드 라는 의미에서 정적필드,정적 메서드
    라고도 한다

    최초 초기화(최초로 값이 대입될떄,메서드가 실행될때 또는 호출) 이후 메모리에 등록되어 프로그램이 종료 될때까지    
    메모리에 상주한다. 불필요하게 사용할 경우 메모리 효율을 컨트롤할수 있으므로 사용상 고려가 필요

     */
    public partial class Chap13_Static_Const : Form
    {

        

        public Chap13_Static_Const()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            // 단일 필드 값 호출 후 변경
            MessageBox.Show(Static_Class.sValue);
            Static_Class.sValue = "반갑습니다.";


            
        }

        private void btnNice_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Static_Class.sValue);
            Static_Class.sValue = "파이팅";

        }

        private void btnFighting_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Static_Class.sValue);
            Static_Class.sValue = "안녕하세요.";
            
        }

        
        
        private void btnStaticOrInstance_Click(object sender, EventArgs e)
        {

            //옵스필드의 Static 또는 instance 알아보기

            // 1. Static 형이 아닌 일반 필드(instance 필드)
            // 클래스를 객체화하여 호출 하되 로직 종료 시 소멸된다.


            //클래스를 객체화 하여 인스턴스 필드에 반갑습니다 값 입력
            StaticOrInstanceClass sOi_C = new StaticOrInstanceClass();
            sOi_C.sInstance_Value = "반갑습니다";

            //정적 빌드에  바로 반갑습니다 값 입력
            StaticOrInstanceClass.sStatic_Value = "반갑습니다";
        }

        private void btnStaticOrInstance_Call_Click(object sender, EventArgs e)
        {
            //StaticOrInstanceClass에있는 필드값을 표현
            StaticOrInstanceClass cOi_C = new StaticOrInstanceClass();

            //인스턴스값표현
            MessageBox.Show(cOi_C.sInstance_Value);

            //정적필드값 표현
            MessageBox.Show(StaticOrInstanceClass.sStatic_Value);

        }
    }


    class Static_Class
    {
        //단일 필드만 Static으로 한정하는 클래스    
        public static string sValue = "안녕하세요";
        

    }


    class StaticOrInstanceClass //밑에 두개 합쳐도 생성할수있다 오류가안떳으니
    {
                                               
        public string sInstance_Value = "안녕하세요"; //인스턴스 필드 //객체를 생성해야됨.
        public static string sStatic_Value = "안녕하세요"; //정적 필드 //객체를 생성 하지말아야됨.

    }
}
