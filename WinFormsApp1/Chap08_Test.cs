using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Resolvers;
using Microsoft.VisualBasic;

namespace MyfirstCSharp
{
    public partial class Chap08_Test : Form
    {
        string sTitle;
        
        
        
        public Chap08_Test()
        {
            InitializeComponent();

            sTitle = lblTitle.Text;
        }

        private void btnName_Click(object sender, EventArgs e)
        {

            //이름 바꾸기
            string sTitle = lblTitle.Text;


            string sObj = "OOO";

            string sValue = "김현승";

            lblTitle.Text = sTitle.Replace(sObj,sValue);

            //변수에안담아도됨 한줄로 만들어보자
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {


            //sw 위치찾기 한줄로바꿔보자.

            string sTitle = lblTitle.Text;

            string sValue =  "S/W";

            int iIndex;
            iIndex = sTitle.IndexOf(sValue);

            MessageBox.Show(Convert.ToString(iIndex));
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {


            string sValue = "-KDT-";

            lblTitle.Text = $"{sValue}{lblTitle.Text}{sValue}";


           /* string sTitle = lblTitle.Text;

          

            lblTitle.Text = ($" -KDT {lblTitle.Text} -KDT-");*/







        }

        private void btnSmart_Click(object sender, EventArgs e)
        {

            /* string sTitle = lblTitle.Text;

              string sObj = "SMARTFACTORY";

              string sValue = "smartfactory";

              lblTitle.Text = sTitle.Replace(sObj, sValue);*/


            // 1 처리할 문자열 타이틀
            string sTitle = lblTitle.Text;

            //2 변경해야할 문자열
            string sValue = "SMARTFACTORY";

            // 3 팩토리 문구가있는 위치(주소)
            int iIndex = sTitle.IndexOf(sValue);

            // 4 라벨 타이틀에서 팩토리 문구 삭제
            string sResult = sTitle.Remove(iIndex,sValue.Length);

            // 5 대문자를 소문자로 변경
            sValue = sValue.ToLower();

            // 6 소문자 삽입 후 Text 표현

            lblTitle.Text = sResult.Insert(iIndex, sValue);



            


  

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //모든공백 없애기


            //lblTitle.Text = sTitle.Trim();

            lblTitle.Text = lblTitle.Text.Replace(" ", "");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //되돌리기
            lblTitle.Text = sTitle;

        }
    }
}
