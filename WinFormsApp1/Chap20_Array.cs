using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstCSharp
{
    public partial class Chap20_Array : Form
    {
        public Chap20_Array()
        {
            InitializeComponent();
        }

        private void btnArrayFunction_Click(object sender, EventArgs e)
        {

            // 배열
            // 같은 데이터 타입의 다중 데이터가 하나의 배열변수 이름으로 나열된 데이터 형식

            // 1. 배열을 초기화 하는 방법
            int[] iValues1 = new int[5] { 10, 20, 30, 40, 50 }; //데이터가 등록되는 방의 갯수를 지정.
            int[] iValues2 = new int[] { 10, 20, 30 };// 데이터가 등록되는 개수 미지정
            int[] iValues3 = { 40, 10, 20, 42 };
            string[] sValues = "ABCD/EFG".Split('/');
            int[] iValues4 = new int[iValues1.Length];
            int[] iValues5 = new int[10];
            // 배열 변수를 만드는 방법은 이게다임.
            // 배열을 선언 할 때는 초기화 대입값이 주어주거나, 배열의 크기(방의개수)가 반드시 명시 되어야 한다.

            // 2. 배열에서 사용되는 주요 기능.

            // 2-1 배열을 정렬한다.

            Array.Sort(iValues3);

            // 2-2 특정 데이터의 index를 반환한다. 없을 경우 -1을 반환.

            int iResultIndex;// 배열 내에 데이터가 존재 할 경우 주소값 담는 변수
            iResultIndex = Array.IndexOf(iValues3, 20);

            // 2-3 배열의 크기를 조절하는 기능.
            Array.Resize<int>(ref iValues3, 3);
            MessageBox.Show($"배열의 개수는 : {iValues3.Length} 입니다");

            // 2-4 배열을 초기화한다.
            Array.Clear(iValues3); //배열의 방의 개수는 그대로 남아있고 각 방의 데이터만 없어진다.
        }

        private void btnArrayCopy_Click(object sender, EventArgs e)
        {

            // 배열을 복사.

            int[] iValues1 = { 10, 20, 30, 40, 50 }; //원본 배열
            int[] iValues2 = iValues1;


            //int 데이터 타입은 값 형 복사 타입
            int iValue = 10;
            int iValue2 = iValue;
            MessageBox.Show(iValue.ToString());
            iValue2 = 20;
            MessageBox.Show(iValue.ToString());

            // 참조형 복사 방식
            // 배열은 참조 형식의 데이터 타입.
            // 원본 배열이 연결되어 있는 주소 값만 공유(얕은 복사)
            // 배열을 복사
            MessageBox.Show(Convert.ToString(iValues1[0]));
            iValues2[0] = 40;
            MessageBox.Show(Convert.ToString(iValues2[0]));//밸류 1이 들어갓을때 0번째는 40이나옴.

            // 참조형 데이터 타입 값을 그대로 복사하는 방식
            //깊은 복사

            // Array.Copy(iValues1, iValues2, iValues1.Length);

            int[] iValues3 = (int[])iValues1.Clone();
            iValues1[0] = 60;

        }

        private void btnTwoD_Click(object sender, EventArgs e)
        {    // 1. 방법 배열의 생성
            // 2차원 배열의 표현 과 예제.
            int[,] iValues = new int[2, 4];//2는 행 4는 열 [행의수,열의수]
            iValues[0, 0] = 1;
            iValues[0, 1] = 2;
            iValues[0, 2] = 3;
            iValues[0, 3] = 4;
            iValues[1, 0] = 5;
            iValues[1, 1] = 6;
            iValues[1, 2] = 7;
            iValues[1, 3] = 8;

            // 2. 배열의 생성 방법
            int[,] iValues2 = new int[3, 4] { { 1, 2, 3, 4 },
                                              { 5, 6, 7, 8 },
                                           { 9, 10, 11, 12 } };



            // 2차원 배열의 행의 수 구하는 기능.
            int iArrayRowCount = iValues2.GetLength(0);// 0번째 값 3

            // 2차원 배열의 열의 수 구하는 기능.
            int iArrayCollumCount = iValues2.GetLength(1);// 1번째 값 4

            // for 문 을 이용해서 iValues2 2차원 배열의 내용을 텍스트박스에 표현.


            /* for (iArrayRowCount = 0; iArrayRowCount <= 2; iArrayRowCount++)
            {


                for (iArrayCollumCount = 0; iArrayCollumCount <= 3; iArrayCollumCount++)
                {
          

                    txt2D.Text += $"  [{iArrayRowCount},{iArrayCollumCount}] = {iValues2[iArrayRowCount, iArrayCollumCount]},";

                }
            }
            //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
              for (int iRow = 0; iRow < iArrayRowCount; iRow++) 
              {
                  for (int iCul = 0; iCul < iArrayCollumCount; iCul++) 
                  {
                      txt2D.Text += Convert.ToString(iValues2[iRow, iCul]); 
                  }
                      txt2D.Text +="\r\n";
              }



              foreach (int a in iValues2)
              {

                  txt2D.Text += $" [{iArrayRowCount}, {iArrayCollumCount}] = {a}";
              }*/

            int i = 0;
            foreach (int A in iValues2) 
            {
                txt2D.Text += Convert.ToString(A) + "" ;
                if (++i > iArrayRowCount)  //if (++i == iArrayCollumCount) 이걸로 생각햇을때가 잘이해됨
                {
                    txt2D.Text+="\r\n";
                    i = 0;
                }
            }
            




        }

    }
}
