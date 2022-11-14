using System.Windows.Forms;

namespace WinFormsApp1
{
    //VisualStudio : 란 ?
    //마이크로 소프트 윈도우 , MacOs에서 동작하며 
    //다양한 언어로 프로그래밍 할 수 있는 통합 개발 환경
    // ( IDE . INtergated Development Enviroment)

    // 2. C# 이란 ?
    // 개발자가 구현하고자하는 내용을 컴퓨터가 수행 할 수 
    // 있도록 하기 위해서는 컴퓨터가 알아들을수 있는 언어
    // 로 해석하기 위한 과정이 필요
    // 컴퓨터가 수행 할 수 있는 언어로 변환해야하는 내용을 
    // 작성하는 객체지향 프로그램 언어의 한 종류
    // (C#, JAVA, Python, JavaScript)

    // 3. 왜 C# dlsrk?
    //  장비 또는 설비에서 동작하는 기계어 에 접근하기 쉽다. (API : Application Programing Interface)
    //  시스템을 운영하는 기업 및 사용자 
    //  컴퓨터 환경이 대다수 Windos OS이다.
    //  개발자와 사용자가 원하는 결과를 정확하고 
    //  빠르게 도출 할 수 있도록 한다.

    public partial class Chap01_Hello : Form
    {
        public Chap01_Hello()
        {
            InitializeComponent(); //메서드(함수) 호출
            textBox1.Text = "hello"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
        private void txt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }


    }
}