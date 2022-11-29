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


    public enum FruitName
    {
        사과, // 0
        참외, // 1
        수박  // 2
    }



    // 메서드로 간추리기 방법. 
    //  . 반복적으로 수행하는 로직을 매서드로 만들어 간추리기 함. 
    public partial class Chap24_Application_Test_Enum : Form
    {
        private int iTotalPrice = 0;

        


        // 현재 실재고 수량 변수
        private int iAppleCnt = 10;  // 사과의 실 재고 수량
        private int iMleonCnt = 10;  // 참외의 실 재고 수량
        private int iWMCnt    = 10;  // 수박의 실 재고 수량

        // 고객이 주문을하여 변동하는 재고
        private int iL_AppCnt = 10;  // 고객이 주문을 클릭하여 남는 사과 재고
        private int iL_MelCnt = 10;  // 고객이 주문을 클릭하여 남는 참외 재고
        private int iL_WMCnt  = 10;  // 고객이 주문을 클릭하여 남는 수박 재고



        //과일 금액
        private int iApplePrice = 2000;
        private int iMelonPrice = 2500;
        private int iWMPrice    = 18000;

        private int iApple2 = 0;
        private int iMelon2 = 0;
        private int iWM2 = 0;

        //const string sApple = "사과";
        //const string sMelon = "참외";
        //const string sW_M   = "수박";

        Dictionary<FruitName, int> dMargin= new Dictionary<FruitName, int>();//이름은 문자열 인트는 마진이랑 결제금액.


        public Chap24_Application_Test_Enum()
        {
            InitializeComponent();
            dMargin.Add(FruitName.사과, 0);
            dMargin.Add(FruitName.참외, 0);
            dMargin.Add(FruitName.수박, 0);
        }

        void CheckFruitM_P(string sFruitName,ref int iFruitCount, Label Templbl )
        {
            // 과일의 현재 재고 수량이 0 일 경우 리턴. 
            if (iFruitCount == 0)
            {
                MessageBox.Show($"{sFruitName}의 재고 수량이 0 입니다. 주문을 할 수 없습니다.");
                return;
            }

            // 던져주는 과일의 재고 개수 1 차감. 
            --iFruitCount;

            // 인자 로 받은 라벨 (사과의 재고 수량 표현라벨, 참외의 재고 수량 표현라벨, 수박의 재고 수량 표현라벨)
            // 에 1 차감된 수량 표현. 
            Templbl.Text = Convert.ToString(iFruitCount);

            switch (sFruitName)
            {
                case "사과":
                    iTotalPrice += 2000;
                    break;
                case "참외":
                    iTotalPrice += 2500;
                    break;
                case "수박":
                    iTotalPrice += 18000;
                    break;
            }
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("사과",ref iL_AppCnt, lblAppCount);//iL_AppCnt에는 위에서 지정해줌 10이 그대로 남아있음.
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("참외",ref iL_MelCnt,lblMelonCount);
        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("수박", ref iL_WMCnt,lblW_MCount);
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결재 금액은 {iTotalPrice} 입니다.");
        }

        private void btnOrederCancle_Click(object sender, EventArgs e)
        {
            // 주문 취소 하기

            // 1. 취소 내역이 없을 경우 취소 내역이 없다는 메세지 보여주기.
            if (iTotalPrice == 0)
            {              
                MessageBox.Show("취소 할 주문 내역이 없습니다.");
                return;
            }

            // 2. 주문 취소 로직 시작.
            // 주문을 하기 전 수량(실 재고 수량)으로 원상복구
            iL_AppCnt = iAppleCnt; 
            iL_MelCnt = iMleonCnt;
            iL_WMCnt  = iWMCnt;

            // 원래 재고 수량(결제 하기 이전의 재고 수량) 표현하기.
            lblAppCount.Text = Convert.ToString(iAppleCnt);
            lblMelonCount.Text = Convert.ToString(iMleonCnt);
            lblW_MCount.Text = Convert.ToString(iWMCnt);

            // 총 주문 금액 0원으로 초기화
            iTotalPrice = 0;
        }

        private void btnCumiteSale_Click(object sender, EventArgs e)
        {


            // 주문 내역 결제하기

            // 주문 내역 있는지 확인.
            if (iTotalPrice == 0)
            {
                MessageBox.Show("결제 할 내역이 없습니다.");
            }

            // 고객 남아있는 금액이 주문 금액보다 적은지 확인.
            int iCustCash1 = Convert.ToInt32(lblCustCash.Text); // 고객 잔액
            int iMnaCash = Convert.ToInt32(lblManCash.Text);        // 관리자 잔액.

            if (iCustCash1 < iTotalPrice)
            {
                MessageBox.Show("주문 금액이 잔액보다 많습니다. 결제를 할 수 없습니다.");
                return;
            }

            //결제 로직을 정상적으로 처리
            lblCustCash.Text = Convert.ToString(iCustCash1 - iTotalPrice); //고객 잔액 차감

            lblManCash.Text = Convert.ToString(iMnaCash + iTotalPrice);   //관리자 잔액 증가

            int iAppleCnt1 = iAppleCnt - iL_AppCnt;//사과 주문 수량
            int iMelCnt1   = iMleonCnt - iL_MelCnt;//참외 주문 수량
            int iWMCnt1    = iWMCnt - iL_WMCnt; //수박 주문 수량

            txtSaleList.Text += "----------------------판매내역---------------------";
            if (iAppleCnt > 0)  txtSaleList.Text += $"사과 판매 개수 : {iAppleCnt1} , 판매 금액 {iAppleCnt1 * iApplePrice}";
            if (iMleonCnt > 0)  txtSaleList.Text += $"참외 판매 개수 : {iMelCnt1} , 판매 금액 {iMelCnt1 * iMelonPrice}";
            if (iWMCnt > 0)     txtSaleList.Text += $"수박 판매 개수 : {iWMCnt1} , 판매 금액 {iWMCnt1 * iWMPrice}";


            //과일의 재고 수량을 주문 수량 잔량으로 업데이트
            iAppleCnt = iL_AppCnt;
            iMleonCnt = iL_MelCnt;
            iWMCnt    = iL_WMCnt;

            MessageBox.Show($"{iTotalPrice} 원의 결제를 완료 하셨습니다.");
            iTotalPrice = 0;

            // 마진 처리하기
            dMargin[FruitName.사과] += iAppleCnt1 * iApplePrice;// 사과의 판매 내역이 마진에 등록.
            dMargin[FruitName.참외] += iMelCnt1 * iMelonPrice;  // 참외의 판매 내역이 마진에 등록
            dMargin[FruitName.수박] += iWMCnt1 * iWMPrice;     // 수박의 판매 내역이 마진에 등록
        }

        private void btnInvOrder_Click(object sender, EventArgs e)
        {

            // 관리자 과일 재고 발주 및 입고 등록.


            // 과일의 발주 개수 파악

            int iAOrdCnt; // 사과 발주 수량
            int iMOrdCnt; // 참외 발주 수량
            int iWOrdCnt; // 수박 발주 수량

            //텍스트박스에 입력 한 문자 가 숫자형식으로 바뀔수 있는 데이터 인지 확인.
            int.TryParse(txtAppleCount.Text,      out iAOrdCnt);
            int.TryParse(txtMellonCount.Text,     out iMOrdCnt);
            int.TryParse(txtWaterMelonCount.Text, out iWOrdCnt); //이름이 정확히 먼지모르면 컨트롤j


            // 발주 금액
            int iAOrPrice  = Convert.ToInt32( iAOrdCnt * iApplePrice * 0.6);
            int IWOrPrice  = Convert.ToInt32(iMOrdCnt * iMelonPrice * 0.6);
            int IWWOrPrice = Convert.ToInt32(iWOrdCnt * iWMPrice * 0.6);

            // 총 발주 금액
            int iTotalOrPrice = iAOrPrice + IWOrPrice + IWWOrPrice;

            // 관리자의 가게 잔액 보다 큰 발주 를 내었는지 확인.
            int iManCash = Convert.ToInt32(lblManCash.Text);

            if(iManCash< iTotalOrPrice)
            {
                MessageBox.Show("가게 잔액 보다 발주 금액이 많습니다.");
                return;
            }

            // 가게 잔액 차감
            lblManCash.Text = Convert.ToString(iManCash- iTotalOrPrice);

            // 발주 내역 영수증 출력(텍스트 박스 표현)
            txtSaleList.Text += "------------발주내역------------\r\n";
            if (iAOrPrice > 0)  txtSaleList.Text  += $"사과 발주 수량 : {iAOrdCnt} 개, 발주금액 : {iAOrPrice} 원";
            if (IWOrPrice > 0)  txtSaleList.Text  += $"참외 발주 수량 : {iMOrdCnt} 개, 발주금액 : {IWOrPrice} 원";
            if (IWWOrPrice > 0) txtSaleList.Text += $"수박 발주 수량 : {iWOrdCnt} 개, 발주금액 : {IWWOrPrice} 원";


            // 재고 증가.
            //사과
            iAppleCnt = iL_AppCnt += iAOrdCnt;
            lblAppCount.Text= Convert.ToString(iAppleCnt);
            //참외
            iMleonCnt = iL_MelCnt += iMOrdCnt;
            lblMelonCount.Text = Convert.ToString(iMleonCnt);
            //수박
            iWMCnt = iL_WMCnt += iWOrdCnt;
            lblAppCount.Text = Convert.ToString(iWMCnt);


            dMargin[FruitName.사과] -= iAOrPrice;      // 사과의 판매 내역이 마진에 등록.
            dMargin[FruitName.참외] -= IWOrPrice;      // 참외의 판매 내역이 마진에 등록
            dMargin[FruitName.수박] -= IWWOrPrice;     // 수박의 판매 내역이 마진에 등록
        }

        private void btnMarginUnit_Click(object sender, EventArgs e)
        {
            // 개별 마진보기

            string sFuitName = string.Empty;
            if (rdoApple.Checked == true) sFuitName = "사과";
            if (rdoMelon.Checked == true) sFuitName = "참외";
            if (rdoWM.Checked == true)    sFuitName = "수박";
            
           // MessageBox.Show($"{sFuitName} 의 마진은 {dMargin[FruitName.수박]} 입니다.");



        }

        private void btnMarginTotal_Click(object sender, EventArgs e)
        {

            // 판매 / 발주 총 마진 금액 산출 및 표현
            int iTotalMargin = 0;//총 마진 누적 변수
            foreach(int iFruitMargin in dMargin.Values)
            {
                iTotalMargin += iFruitMargin;
            }
            MessageBox.Show($"과일의 총 마진은{iTotalMargin} 입니다.");
        }

        private void btnInvClear_Click(object sender, EventArgs e)
        {
            foreach (Control MyControl in this.Controls)
            {
                if (MyControl is TextBox && MyControl.Text != "")
                {                 
                   
                }
            }

        }
    }
}
