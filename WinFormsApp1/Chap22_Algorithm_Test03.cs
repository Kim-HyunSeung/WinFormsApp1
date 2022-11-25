using System;
using System.Collections;
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
    public partial class Chap22_Algorithm_Test03 : Form
    {
        public Chap22_Algorithm_Test03()
        {
            InitializeComponent();
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
             Dictionary<int, int> MyDic = new Dictionary<int, int>();
             int[,] iValues = {{ 1,4,5,9,10,12,16 },  //[2,7] 0.1행 , 0~6열
                             { 2,7,11,13,14,15,18} };

             string D = string.Empty;

             int A = iValues.GetLength(0);//행
             int B = iValues.GetLength(1);//열
             bool E = false;
             int F=0;

             int[,] C = new int[A, B];

              
             for (int i = 0; i < 7; i++) //행을 6번 돌림
             {
                 for(int j = 0; j < 7; j++) //열을 6번 돌림
                 {
                    ++F;
                    if (i + j == 20) //행 숫자 와 열 숫자의 합이 20
                     {

                         C[A, B] = iValues[i, j]; //iValues의 A,B값들의 합 이 20이라는 값을 C라는 새로운 변수에 행과 열의 값을 담아줌
                        D += $"{C},{iValues[i, j]}\r\n";
                    }
                     if(i+ j !=20)
                     {
                        E = true;                    
                        break;
                    
                    }
                    E = false;                 
                    break;
                }
                F = 0;

            }
            MessageBox.Show(Convert.ToString(C));
             
             
             
             //요기에서 A와 B의 합한 값 20이 있는곳이라서 공통적인 값들을 없애주고 하나의 값만 남겨놓아야댐

           
            //------------------------------------------------------------------------------------------------------------------------------------

            // 2차원 배열의 합 중 20이 되는 쌍 찾기

            // 1. 전체적인 쌍합 구하고 2. 자기자신을 없애고 3. 기준값 결과값이 먼저 나왓는데 그다음의 수가 결과값이 기준값과 같다면 나오게하지마라.

            // 2차원 배열의 합 중 20 이 되는 쌍 찾기.
            /*int[,] iValues = { { 1, 4, 5,  9,  10, 12, 16 } ,
                               { 2, 7, 11, 13, 14, 15, 18}  };

            // 찾은 값을 등록 할 문자열 변수. (쌍 의 내용을 등록)
            string sFindValue = string.Empty;
            // 배열의 행의 수 구하기 . 
            int iRowC = iValues.GetLength(0);
            // 배열의 열의 수 구하기
            int iColC = iValues.GetLength(1);
            // 찾은 값을 등록 할 변수.
            int iFindValue = 0;
            // 찾을 값을 누적시킬 리스트. 
            ArrayList list = new ArrayList();
            // Foreach 나 For 문을 종료 시킬 Break 설정 여부를 판단하는 변수. 
            bool bBreakFlag = false;
            // Foreach 가 회전한 카운트
            int iForeachC = 0;
            // 행열 For 문이 회전한 카운트 
            int iForC = 0;

            foreach (int iValue in iValues)
            {
                ++iForeachC;
                // 찾은 값이 등록 되어 있는 리스트 에서 기준값이 등록 되어 있는지 확인.
                for (int k = 0; k < list.Count; k++)
                {
                    if (iValue == Convert.ToInt32(list[k]))
                    {
                        bBreakFlag = true;
                        break;
                    }
                }
                if (bBreakFlag == true)
                {
                    bBreakFlag = false;
                    continue;
                }



                iFindValue = 20 - iValue; // 20 에서 추출한 수를 차감한 찾아야 할 수 
                for (int i = 0; i < iRowC; i++) // int i : 행의 수
                {
                    for (int j = 0; j < iColC; j++) // int j : 열의 수.
                    {
                        ++iForC;
                        if (iFindValue == iValues[i, j])
                        {
                            if (iForeachC == iForC)
                            {
                                bBreakFlag = true;
                                break;
                            }
                            list.Add(iValues[i, j]);
                            sFindValue += $"{iValue},{iValues[i, j]}\r\n";
                        }
                    }
                    if (bBreakFlag == true)
                    {
                        bBreakFlag = false;
                        break;
                    }
                }
                iForC = 0;
            }
            MessageBox.Show(sFindValue);*/


        }


    }
}
