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
    public partial class Chap23_Application_Test02 : Form
    {
        private int iTotalPrice = 0;
        public Chap23_Application_Test02()
        {
            InitializeComponent();
        }

        void CheckFruitM_P(string sFruitName, int iFruitCount, Label Templbl )
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
            CheckFruitM_P("사과",Convert.ToInt32(lblAppCount.Text), lblAppCount);
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("참외",Convert.ToInt32(lblMelonCount.Text),lblMelonCount);
        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("수박", Convert.ToInt32(lblW_MCount.Text),lblW_MCount);
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결재 금액은 {iTotalPrice} 입니다.");
        }

        private void btnCumiteSale_Click(object sender, EventArgs e) //결제하기 버튼 클릭.
        {
            // 주문 내역 결제하기

            // 주문 내역 있는지 확인.
            if (iTotalPrice == 0)
            {
                MessageBox.Show("결제 할 내역이 없습니다.");
            }

            // 고객 남아있는 금액이 주문 금액보다 적은지 확인.
            int iCustCash = Convert.ToInt32(lblCustCash.Text); // 고객 잔액
            int iMnaCash = Convert.ToInt32(lblManCash);        // 관리자 잔액.
            
            if(iCustCash< iTotalPrice)
            {
                MessageBox.Show("주문 금액이 잔액보다 많습니다. 결제를 할 수 없습니다.");
                return;
            }

            //결제 로직을 정상적으로 처리
            lblCustCash.Text = Convert.ToString(iCustCash - iTotalPrice); //고객 잔액 차감

            lblManCash.Text = Convert.ToString(iMnaCash + iTotalPrice);   //관리자 잔액 증가

            txtSaleList.Text += "----------------------판매내역---------------------";
          
        }
    }
}
