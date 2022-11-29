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
    // 메서드로 간추리기 방법. 
    //  . 반복적으로 수행하는 로직을 매서드로 만들어 간추리기 함. 
    public partial class Chap23_Application_Test01 : Form
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

       private int BalSum = 0;

        int ASum = 0;
        int MSum = 0;
        int WMSum = 0;

        public Chap23_Application_Test01()
        {
            InitializeComponent();
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


            /*if (iTotalPrice > 100000) 
            {
                MessageBox.Show("결제를 할수 없습니다");
                return;
            }



            iAppleCnt = iL_AppCnt;
            iMleonCnt = iL_MelCnt;
            iWMCnt = iL_WMCnt;

            lblCustCash.Text = $"{iTotalPrice+ CustCash}";

            textBox1.Text = $"사과 판매 개수 : {} ";*/


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
        }

        private void btnInvOrder_Click(object sender, EventArgs e)
        {
            int iCustCash1 = Convert.ToInt32(lblCustCash.Text);
            int iMnaCash = Convert.ToInt32(lblManCash.Text);       

            int iApple1 = Convert.ToInt32(txtAppleCount.Text);
            int iMelon1 = Convert.ToInt32(txtMellonCount.Text);
            int iWM1    = Convert.ToInt32(txtWaterMelonCount.Text);

            int TotalSum = 0;

            int Asum=0;
            int MSum=0;
            int WMSum=0;

            if (iApple1==0 || iMelon1==0 || iWM1==0)
            {
                
                MessageBox.Show("발주 내역이 없습니다.");
             
                return;
            }

            if(iMnaCash< TotalSum)
            {
                MessageBox.Show("발주 금액을 초과하셨습니다.");
                return;
            }
           
            if (iApple1 > 0 && iMelon1 > 0 && iWM1 > 0)
            {
                 ASum = iApplePrice * iApple1;
                 MSum = iMelonPrice * iMelon1;
                 WMSum = iWMPrice * iWM1;
                BalSum = ASum + MSum + WMSum;
            }
            txtSaleList.Text = "------------발주 내역 ------------------\r\n";
            txtSaleList.Text += $"사과 수량 : {iApple1} 사과 발주 금액 : {ASum}\r\n참외 수량 : {iMelon1}" +
               $"참외 발주 금액 : {MSum}\r\n수박 수량 : {iWM1} 참외 발주 금액 : {WMSum}\r\n";
            lblManCash.Text = $"{iMnaCash+ BalSum}";
           
        }





    }
}
