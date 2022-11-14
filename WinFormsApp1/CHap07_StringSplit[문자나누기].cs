using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstCSharp
{
    public partial class CHap07_StringSplit : Form
    {
        public CHap07_StringSplit()
        {
            InitializeComponent();
            lblTitle.Text = "ABCDEF/GHIJKLNM/OPQRSTU";
                              // 0        1         2
        }

        private void btnInterpolation_Click(object sender, EventArgs e)
        {
            // 문자열 보간. 
            // 보간 : 비거나 누락된 부분을 채우는 기능. 
            // 문자열 "" 안에 { } 로 표현될 변수를 등록.
            // {} 안에 들어가는 모든 데이터 타입은 
            // 문자열로 형변환 (암시적)되어 표현 된다.

            string sValue; // 문자열 보간 데이터가 담길 변수

            // 문자열 데이터의 보간.

            //// 문자열의 합으로 표현
            //sValue = "라벨 의 타이틀 은" + lblTitle.Text + " 입니다. ";
            //MessageBox.Show(sValue); 

            // 문자열 보간법으로 표현
            //sValue = $"라벨의 타이틀 은 {lblTitle.Text} 입니다";


            sValue = $" 1 + 1 은 {2} 입니다 그리고 2 + 2 는 {4} 입니다. "; //중괄호 안은 작은거는 큰걸로 형변환시킴 그반대는x

            MessageBox.Show(sValue);

        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            // 문자열, 배열 등의 길이(계수) 구하기

            MessageBox.Show($" 타이틀 문자열의 계수는 {lblTitle.Text.Length} 입니다.");

            // 마지막(인덱스값) Length 는 Length -1 의 값을 가진다. ***
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            // Split 지정된 문자를 기준으로 문자열을 자르고
            // 자른 값을 반환한다.

            // 1. 문자열을 분할 할 대상 문자열을 변수에 담는다
            string sSplitValue = txtSplit.Text;  //

            // 2. 지정한 문자 를 기준으로 나눈 문자열을 Split 배열에 담는다.
            // 배열 : 같은 타입의 변수를 여러개 모아놓은 데이터 타입

            string[] Array_Split = lblTitle.Text.Split(sSplitValue);

            // 배열에 몇개의 방이 생성 되었는지 확인.
            MessageBox.Show(Array_Split.Length.ToString());

            // 배열의 첫번째 주소에 있는 문자의 갯수 확인
            MessageBox.Show(Array_Split[0].Length.ToString());

            // 배열에 담긴 문자를 표현
            MessageBox.Show(Array_Split[0]);
            MessageBox.Show(Array_Split[1]);
            MessageBox.Show(Array_Split[2]);
            MessageBox.Show(Array_Split[3]);
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            // Substring : 사용자가 지정한 위치 및 갯수만큼 문자를 잘라서 표현

            // 1. 문자열 자르기 대상
            string sTitle = lblTitle.Text;

            // 2. 문자열을 자를 위치
            int iIndex = Convert.ToInt32(txtIndex.Text);

            // 3. 문자열을 자를 계수

            int iStringCount =Convert.ToInt32(txtCount.Text);

            string sValue; // 문자열을 잘라와서 담을 변수

            sValue = sTitle.Substring(iIndex,iStringCount);

            MessageBox.Show(sValue);

        }
    }
}
