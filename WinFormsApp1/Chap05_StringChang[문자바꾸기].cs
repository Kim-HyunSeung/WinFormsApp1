using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    partial class Chap05_StringChang : System.Windows.Forms.Form
    {
        string sTitle;
        public Chap05_StringChang()
        {
            //생성자
            //클래스가 제일 처음 진입할때 시작될때
            //수행해야 하는 코드
            InitializeComponent();

            sTitle = lblTitle.Text;

        }

        private void btnChang_Click(object sender, EventArgs e)
        {
            // 타이틀 문자열 임의 변경
            lblTitle.Text = "안녕하세요";
        }

        private void btnReturn_Click(object sender, EventArgs e)//타이틀문자 다시 돌려놓기
        {
            //원본 라벨 문자열 되돌리기 버튼
            lblTitle.Text = sTitle;


        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            //원본 데이터 의 모든 문자 중 대문자를 소문자로 변경
            txtLower.Text = sTitle.ToLower();

        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            //원본 데이터 의 모든 문자 중 소문자를 대문자로 변경
            txtUpper.Text = sTitle.ToUpper();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 지정한 위치에 입력한 문자를 삽입하기.
            string sString = txtstring.Text;            // 삽입할 문자열
                                                        // int iIndex = Convert.ToInt32(txtstring.Text); //문자열을 삽입할위치

            //int iIndex = int.Parse(sString);//parse사용해서 변환

            int iRe;
            int.TryParse(txtIndex.Text, out iRe);//iRe가 정수가아니고 따른값 문자나 뭐이런거면 0번째 위치를 나타낸다.

            //iRe가 정수값이라 숫자는 되는데 문자나 이상한게 드가면 오류가 떠서 무조건 0번째 위치로 텍스가 들어간다
            txtInsert.Text = sTitle.Insert(iRe, sString);//try parse사용해서 변환

            //sString를 iRe위치에 넣어서 표시

           // txtInsert.Text = sTitle.Insert(iIndex, sString); //Insert( 위치, 삽일할 대상) 필요>



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // 지정한 위치로 부터 지정한 개수의 문자를 삭제
            int iStartIndex = Convert.ToInt32(txtIndexS.Text);

            //삭제 할 문자의 개수
            int iCount = Convert.ToInt32(txtStringCount.Text);

            //삭제 후 문자열 표시
            txtRemove.Text = sTitle.Remove(iStartIndex, iCount); // 하나만 받아서 할 경우 뒤에글자 다 없앰
                                                                 //두 개를받아서 할 경우 위치와 갯수 삭제

        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 앞, 뒤 공백을 삭제
            txtTrim.Text = sTitle.Trim();
        }

        private void btnStartTrim_Click(object sender, EventArgs e)
        {
            // 문다열의 앞 공백만 지움
            txtStartTrim.Text = sTitle.TrimStart();
        }

        private void btnEndTrim_Click(object sender, EventArgs e)
        {
            //문자열의 뒷 공백만 지움
            txtEndTrim.Text = sTitle.TrimEnd();
        }
    }
} 

