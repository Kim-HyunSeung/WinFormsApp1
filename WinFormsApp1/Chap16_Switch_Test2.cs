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
    public partial class Chap16_Switch_Test2 : Form
    {
        int iTotalPrice = 0; // 사과 참외 수박 을 주문한 총 금액이 담기는 변수.

        
        public Chap16_Switch_Test2()
        {
            InitializeComponent();
        }

        private void btnApple_Click(object sender, EventArgs e)
        {    int iAppCount = Convert.ToInt32(lblAppCount.Text);//현재 사과의 재고 수량.
           /* if (iAppCount > 0)
            {

                //사과 주문 시 재고 차감.
                --iAppCount;
                lblAppCount.Text = Convert.ToString(iAppCount);

            }
            else 
            
            {
                MessageBox.Show("사과의 재고 수량이 0입니다. 주문 할 수 없습니다.");
            
            }*/

            if (iAppCount == 0) 
            {

                MessageBox.Show("사과의 재고 수량이 0입니다.주문 할 수 없습니다.");

                return;
            }
            //재고 수량 차감
            --iAppCount;
            lblAppCount.Text = Convert.ToString(iAppCount);

            //총 구매 금액 증가
            iTotalPrice += 2000;//바로위 메시지박스 위에잇으면 차감은 계속해도 눈으로는 안보임



        }



        private void btnMellon_Click(object sender, EventArgs e)
        {
            int iMelonCount = Convert.ToInt32(lblMelonCount.Text);


            if (iMelonCount == 0)
            {

                MessageBox.Show("참외의 재고 수량이 0입니다.주문 할 수 없습니다.");
                return;
            }
         
            --iMelonCount;
            lblMelonCount.Text = Convert.ToString(iMelonCount);
            iTotalPrice += 2500;

        }

        private void btnW_M_Click(object sender, EventArgs e)
        {
            int iW_M = Convert.ToInt32(lblW_MCount.Text);

            if (iW_M == 0)
            {

                MessageBox.Show("수박의 재고 수량이 0입니다.주문 할 수 없습니다.");
                return;
            }
           
            --iW_M;
            lblW_MCount.Text = Convert.ToString(iW_M);
            iTotalPrice += 18000;
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은{iTotalPrice}입니다.");
        }



    }
}
