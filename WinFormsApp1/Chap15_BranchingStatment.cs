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
    public partial class Chap15_BranchingStatment : Form
    {


        // 분기문
        // 프로그램 흐름의 조건에 따라 여러갈래로 나누는 흐름제어
        // 비교 연산자 로는 ==, !=, <=, >= ,< ,> , &&(왼쪽 그리고 오른쪽), ||(왼쪽 또는 오른쪽)
        public Chap15_BranchingStatment()
        {
            InitializeComponent();
        }


      
        private void btnIf_Click(object sender, EventArgs e)
        {

            // 텍스트 박스에 입력한 값이 없을경우
            // "아무 값도 없습니다" 메시지 표현
            // 입력 값이 있을경우 해당 값을 메세지로 표현

            // 1. 텍스트 박스에 입력한 값 변수에 대입
            string sTxtValue = txtInput.Text;

            // 기본적인 분기문 원형
            if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 업습니다");
            }
            else 
            {
                MessageBox.Show(sTxtValue);
            }

        }

        private void btnInIf_Click(object sender, EventArgs e)
        {
            /* 만약에 입력한 값이 1 일때는 "분기문 1 실행" 메시지 표현
               2일때는 "분기분 2 실행" 메세지 표현
               3일때는 "분기분 3 실행" 메세지 표현
               값이 없을 경우에는 "아무값도 없습니다" 메세지 표현
               1,2,3 이 모두 아닐경우는 "적절한 분기문이 없습니다" 메시지 표현
                                                              
             */

            string sTxtValue = txtInput.Text;

            // 분기문 안에 사용되는 분기문
            if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다");

            }

            else 
            {
                if (sTxtValue == "1")
                {

                    MessageBox.Show("1 번 분기문 실행");
                }


               
                if (sTxtValue == "2")
                {

                    MessageBox.Show("2 번 분기문 실행");
                
                }

                if (sTxtValue == "3")
                {

                    MessageBox.Show("3 번 분기문 실행");
                }

                else 
                {

                    MessageBox.Show("적절한 분기문이 없습니다");

                }
                    //마지막의 else 는 3번 분기문의 예외일경우 결과로직임.
                    // 1 을 입력 했을 경우
                    // 1번 분기문 입니다 라는 메시지를 표현하는 If문 적용
                    // 3번이 아니기 때문에 Else 구문 적용
            }
       
        
        
        }

        private void btnElseIf_Click(object sender, EventArgs e)
        {
            // Else If 정의
            // if문의 다음 if문을 하나의 흐름으로 만들어준다

            string sTxtValue = txtInput.Text;

            if (sTxtValue == "") 
            {

                MessageBox.Show("아무 값도 없습니다");
            }
            else if (sTxtValue == "1")
            {

                MessageBox.Show("1번 분기문 실행");
            }

            else if (sTxtValue == "2")
            {

                MessageBox.Show("2번 분기문 실행");
            }

            else if (sTxtValue == "3")
            {

                MessageBox.Show("3번 분기문 실행");
            }

            else  
            {

                MessageBox.Show("적절한 분기문이 없습니다");
            }

        }

        private void btnAndIf_Click(object sender, EventArgs e)
        {

            //and if 문 && 표기하며 그리고 의 역할
            string sTxtValue = txtInput.Text;

            if (sTxtValue == "1" && sTxtValue == "2" && sTxtValue == "3") // 모든 경우가 다 트루일때 또는 다 펄스일때 and
            {
                MessageBox.Show($"{sTxtValue} 번 분기문실행");

            }
            else if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다");
            }
            else 
            {
                MessageBox.Show("적절한 분기문이 없습니다");
            }
            // &&연산자는 왼쪽과 오른쪽에 모두 참 일 경우에만 true로 간주한다
        
        }

        private void btnOrIf_Click(object sender, EventArgs e)
        {
            //or if 문
            string sTxtValue = txtInput.Text;

            if (sTxtValue == "1" || sTxtValue == "2" || sTxtValue == "3") //or은 +라 셋중하나만 true라면 참임
            {
                MessageBox.Show($"{sTxtValue} 번 분기문 실행");
            }

            else if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다");
            }
            else 
            {
                MessageBox.Show("적절한 분기문이 없습니다");
            }

            // || (세로줄, 버티컬바)연산자는 왼쪽과 오른쪽이 어느 하나라도 참 일경우 true

            
        }

        private void btnBoolIf_Click(object sender, EventArgs e)
        {

            // Bool 데이터 변수에 데이터가 담긴 내용으로 비교하는 로직
            string sTxtValue = txtInput.Text;
            bool bFalg = false;

            if (sTxtValue == "1" || sTxtValue == "2" || sTxtValue == "3")
            {
                bFalg = true;

            }
            else if (sTxtValue == "")
            {
                MessageBox.Show("아무값도 없습니다");
                return; // 맞는값을 반환해서 밑에 로직이 실행이 안되게끔 한다
                
            }



            // 두번째 분기 흐름

            if (bFalg)
            {
                MessageBox.Show($"{sTxtValue} 번 분기문 실행");
            }

            

            else if (sTxtValue != "")
            {

                MessageBox.Show("적절한 분기문이 없습니다");
            }
             // 마지막에 else는 없어도됨.
        }      
    }
}
