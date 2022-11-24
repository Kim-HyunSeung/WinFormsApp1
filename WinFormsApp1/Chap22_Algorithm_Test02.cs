using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstCSharp
{
    public partial class Chap22_Algorithm_Test02 : Form
    {
        public Chap22_Algorithm_Test02()
        {
            InitializeComponent();
        }


        private void btnDrc_Click_1(object sender, EventArgs e)
        {
            /*Dictionary<string, int> First = new Dictionary<string, int>();

            string S1 = lblS.Text;


            string S2 = lblS.Text.Split();*/
            //-------------------------------------------------------------------------------------------

            /*string a = lblS.Text;
            string FF = String.Empty;



            for (int i = 0; i < lblS.Text.Length; i++)
            {
                string b = a.Substring(i, 1); //A부터 시작


                for (int j = i + 1; j < lblS.Text.Length; j++)
                {
                    string c = a.Substring(1, j); //B부터 시작

                    if (b == c)
                    {
                        continue;

                    }
                    else
                    {

                        FF = $"{b}";
                    }

                    MessageBox.Show(b);
                    break;
                }

            }*/

             string sTitle = lblS.Text;

             Dictionary<char,int> MyDic= new Dictionary<char,int>();

             foreach (char cWord in sTitle) 
             {
                 if (MyDic.ContainsKey(cWord))
                 {
                     MyDic[cWord] += 1;
                 }
                 else
                 {
                     MyDic.Add(cWord, 1);//값은 첫번째 a가 1 두번째 돌았을때 b가 1

                 }
             }
             foreach (char cKey in MyDic.Keys) 
             {
                 if (MyDic[cKey] == 1) 

                 {
                     MessageBox.Show($"중복되지 않는 왼쪽의 첫문자는{cKey}");
                     break;
                 }
             }
        }    
            //------------------------------------------------------------------------------------------딕셔너리 이용해서 찿음
        

        private void btnLast_Click(object sender, EventArgs e)
        {
            //중복되지 않는 문자열 찿기.
            //ABCLD / EML / BZAMDC /
            string sTitle = lblS.Text;

            string sNowString = string.Empty;

            for (int i = 0; i < sTitle.Length; i++) 
            {
                sNowString = sTitle.Substring(i, 1);
                if (i == sTitle.LastIndexOf(sNowString)) 
                {
                    MessageBox.Show($"중복되지 않는 왼쪽의 첫문자는{sNowString}");
                    break;
                }
            }

        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string sTitle = lblS.Text;

            bool bFindFlag = true;
            string sBaseWord = string.Empty;
            // int i = 0 : 기준 문자의 위치 Index
            for (int i = 0; i < sTitle.Length; i++)
            {
                sBaseWord = sTitle.Substring(i, 1);

                // int j  기준 문자로 부터 비교대상 문자 의 위치
                for (int j = i + 1; j < sTitle.Length; j++)
                {
                    // 기준 문자 이후 부터 한글자씩 추출.
                    string sValueWord = sTitle.Substring(j, 1);

                    // 기준 문자와 추출한 문자 를 비교
                    if (sBaseWord == sValueWord)
                    {
                        // 중복 문자를 찾았을때 bFindFlag = false 를 대입
                        bFindFlag = false;
                        break;
                    }
                    // 중복 문자를 찾지 못했을때에는 bFindFlag = true 를 대입
                    bFindFlag = true;
                }

                //  중복 문자를 찾지 못했으므로 
                if (bFindFlag == true)
                {
                    // For 반복문 종료. 
                    break;
                }
            }
            // 기준 문자 로 잡은 sBaseWord 를 표현.
            MessageBox.Show($"중복되지 않는 첫 문자는 {sBaseWord} 입니다.");



        }
        
    }
}
