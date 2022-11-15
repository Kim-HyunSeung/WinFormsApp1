using MyFirstCSharp;
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
     
    public partial class Chap10_Class2 : Form
    {
        // 클래스가 객체화 될때
        // 필드 맴버 -> 생성자 맴버 클래스가 객체화 된다.
        // Chap10_Class 클래스를 필드멤버로 객체화
       
        
        Chap10_Class Chap10 = new Chap10_Class();//필드 멤버
            

        public Chap10_Class2()
        {
            // 화면 디자인표현
            InitializeComponent();
            Chap10.sArm = "로봇팔";

        }

        private void btnCalssInstance_Click(object sender, EventArgs e)
        {
            //클래스의 객체화(인스턴스 화)
            //클래스 => (객체 = 인스턴스) 

           


            string sMessage = Chap10.sArm;
            MessageBox.Show(sMessage);

            
            MessageBox.Show(Chap10.sArm);

            Chap10_Class Chap10_2 = new Chap10_Class();
            MessageBox.Show(Chap10_2.sArm);

        }

        private void btnCalssinstance2_Click(object sender, EventArgs e)
        {
        
           
            MessageBox.Show(Chap10.sArm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 다른 클래스의 메서드를 호출하는 방식
            Chap10.Method1();

        }
    }
}
