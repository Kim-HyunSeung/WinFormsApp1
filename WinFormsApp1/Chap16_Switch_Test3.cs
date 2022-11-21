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

    //메서드로 간추기리 방법.
    // .반복적으로 수행하는 로직을 매서드로 만들어 간추리기 함.
    public partial class Chap16_Switch_Test3 : Form
    {


        private int iTotalPrice = 0;
        public Chap16_Switch_Test3()
        {
            InitializeComponent();
        }
        void CheckFruitM_P(string sFruitName, int iFruitCount,Label Templbl)
        {
            //과일의 현재 
            if (iFruitCount == 0)
            {
                MessageBox.Show($"{sFruitName}의 재고 수량이 0입니다.주문 할 수 없습니다.");
                return;
            }
            
            //던져주는 과일의 재고 개수 1차감
            --iFruitCount;
            
            //인자 로 받은 라벨(사과의 재고 수량 표현라벨, 참외의 재고 수량 표현라벨,수박의 재고 수량 표현라벨)
            //에 1 차감된 수량 표현
            Templbl.Text = Convert.ToString(iFruitCount);
            
            switch (sFruitName)
            {
                case "사과":

                    lblAppCount.Text = Convert.ToString(iFruitCount);
                    iTotalPrice += 2000;
                    break;

                case "참외":
                    lblMelonCount.Text = Convert.ToString(iFruitCount);
                    iTotalPrice += 2500;
                    break;


                case "수박":
                    lblW_MCount.Text = Convert.ToString(iFruitCount);
                    iTotalPrice += 18000;
                    break;


            }

        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("사과", Convert.ToInt32(lblAppCount.Text),lblAppCount);
        }

        private void btnMellon_Click(object sender, EventArgs e)
        {
            CheckFruitM_P("참외", Convert.ToInt32(lblMelonCount.Text),lblMelonCount);
        }
      
        private void btnW_M_Click_1(object sender, EventArgs e)
        {
            CheckFruitM_P("수박", Convert.ToInt32(lblW_MCount.Text), lblW_MCount);
        }




        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결재 금액은 {iTotalPrice} 입니다.");
        }

    } 
}
