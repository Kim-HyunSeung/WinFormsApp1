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
            string sBaseWord = string.Empty;
            bool bFindFlag = true;

            for (int i = 0; i < lblS.Text.Length; i++) //기준 문자의 위치index
            {

                sBaseWord = sTitle.Substring(i, 1);//A
                //기준 문자로부터 비교대상 문자의 위치
                for (int j = i + 1; j < sTitle.Length; j++)
                {
                    string sValueWord = sTitle.Substring(j, 1); //기준 문자 이후 부터 한글자씩 추출

                    // 기준 문자의 추출된 문자줄비교
                    if (sBaseWord == sValueWord)
                    {
                        bFindFlag = false;
                        //중복문자를 찾았을 경우 빠져나옴
                        break;

                    }
                    bFindFlag = true;

                }

                //중복된 문자를 찾지못햇을때
                if (bFindFlag)
                {
                    //중지
                    break;
                }

            }
            MessageBox.Show($"중복되지않는 첫 문자는{sBaseWord}");




        }

    }
}
