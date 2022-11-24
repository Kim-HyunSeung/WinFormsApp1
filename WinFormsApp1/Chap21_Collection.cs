using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace MyfirstCSharp
{
    public partial class Chap21_Collection : Form
    {
        public Chap21_Collection()
        {
            InitializeComponent();
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {

            //arraylist
            //데이터 형식에 상관 없이 다중 데이터를 관리 할 수 있는 데이터 타입.
            //데이터 형식에 구애없이 데이터가 누적 되므로
            //데이터를 확인 할 때에는 반드시 데이터 형변환 이 이루어져야한다. 

            //별도의 데이터 공간을 지정 하지 않아도 데이터를 등록 할 수 있다.
            ArrayList ArrList = new ArrayList();

            //기본적인 데이터 등록 방법
            for (int i = 0; i <= 10; i++) 
            {
                ArrList.Add(i); // 데이터를 등록.Add


            }
            // 2. 데이터 타입에 상관없이 데이터를 등록 할수있다.

            //배열 번지수안에 합류함
            ArrList.Add("안녕하세요.");

            // ArrList.Sort();// 리스트에 있는 내용을 정렬
            // * 데이터타입이 혼용 되어있을경우 정렬을 할 수 없다.

            ArrList.Remove(2); //2번 인덱스에 있는 데이터의 메모리 삭제 후 다시 정렬.

            ArrList.Insert(2, 40); //2번째 인덱스에 40데이터 추가

            //arrayList 에 기존의 컬렉션의 데이터를 추가하는 방법
            int[] iValues = { 1, 2, 3, 4 };
            ArrayList List2 = new ArrayList(iValues);
            ArrayList List3 = new ArrayList(new int[] { 1,2,3});



        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Queue
            // 선입 선출 방식의 자료 구조
            // 데이터나 작업을 차례대로 입력된 순서 에 따라 하나씩 처리.

            //Queue 의선언
            Queue<int> Que = new Queue<int>();

            //Queue 에 데이터 등록
            //대입하는 방식으로 등록하는것이 아닌 데이터 등록 메서드가 별도로 존재
            Que.Enqueue(10);
            Que.Enqueue(20);
            Que.Enqueue(30);
            Que.Enqueue(40);

            // Queue 에 데이터 출력 방식.
            while (Que.Count > 0) 
            {
                MessageBox.Show(Convert.ToString(Que.Dequeue()));//메세지를 나타내면서 그값의 데이터가 없어진다.
              
            }
                MessageBox.Show($"Que에 남은 데이터의 수는{Que.Count} 개 입니다.");


            //Queue
            //배열(자료형 구조)타입을 이용하여 데이터 등록
            // 1. 배열로 담기
            int[] iValues = { 1, 2, 3, 4 };
            Queue Que2 = new Queue(iValues);
            Queue Que3 = new Queue(new int[] {1,2,3,4,5 });

            // 2. ArrayList 로 담기.

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Insert(2,30);

            Queue Que4 = new Queue(list);
            MessageBox.Show(" Que의 첫번째 데이터 : " + Convert.ToString(Que4.Dequeue()));

            // 데이터를 순차적으로 담아서 처리후(선입선출)메모리에서 데이터를 삭제 하므로
            // 메모리 관리에 용이한 자료 형 구조 이나
            // 데이터가 휘발성으로 삭제 되므로 필요한 곳에 따라 잘 사용 할것.
        }   // 완전히 종료되면 안에있는 데이터(Que)값이 없어짐

        private void btnStack_Click(object sender, EventArgs e)//stack 뒤에 데이터를 먼저 보여줌
        {

            // Stack 
            // 선입 후출 : 후입 선출 방식
            // 데이터나 작업을 차례대로 입력된 순서 대로 하나씩 처리.

            //stack 과 queue는
            //데이터가 등록되고 호출시 메모리 에서 삭제되므로
            //메모리 관리에 용이한 자료형 구조.


            // Stack 의 선언.
            Stack<int> stack1 = new Stack<int>();

            // Stack 에 데이터 등록 방법.
            stack1.Push(40);
            stack1.Push(10);
            stack1.Push(20);
            stack1.Push(30);

            // Stack 데이터 추출

            while (stack1.Count > 0) 
            {
                MessageBox.Show(Convert.ToString(stack1.Pop()));
            
            }
            //그외의 데이터 등록 방법(컬렉션 자료형 구조)
            //1. 배열

            Stack stack2 = new Stack(new int[] { 1, 2 });

            ArrayList list = new ArrayList();
            list.Add(20);
            list.Add(30);
            list.Add(40);

            // 2.array list
            Stack stack3 =new Stack(list);
            MessageBox.Show(Convert.ToString(stack3.Pop())); //40<<마지막꺼 부터뜸.

        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {

            // Dictionnary
            // 데이터가 담기는 주소를 Key 로 설정 하여 데이터를 등록 하는 자료형 구조.

            // 1. Dictionary 의 생성.
            Dictionary<string,int> MyDic= new Dictionary<string,int>();

            // 2. DiC 데이터 등록
            MyDic.Add("십", 10);
            MyDic.Add("이십", 20);
            MyDic.Add("삼십", 30);
            MyDic["사십"] = 40;

            // 3. Dic 데이터 확인.
            MessageBox.Show(Convert.ToString(MyDic["사십"]));

            // 4. Dic 의 복사
            // 참조를 전달하는 방식으로 데이터를 공유
            Dictionary<string, int> MyDic2 = MyDic;
            MyDic2["십"] = 100;
            MessageBox.Show($"MyDic의 \"십\"의 데이터는 : {MyDic["십"]} 입니다."); //\"\"<<문자로 안에서쓸때 사용,mydic이 참조형
                                                                                   //데이터이기 떄문에 값이 들어가서 바뀜
                                                                                   // 값을 그대로 복사.// 100

            Dictionary<string, int> MyDic3 = new Dictionary<string, int>(MyDic); 
            MyDic3["이십"] = 200;
            MessageBox.Show($"MyDic의 \"이십\" 데이터는 : {MyDic["이십"]}입니다.");// 20

            // 5. Key의 사용여부 확인.
            if (MyDic.ContainsKey("사십")) //요긴 트루값이잇으면 들어감
            {
                MessageBox.Show("Key로 사용되고 있습니다.");
            }
            else
            {
                MessageBox.Show("Key로 사용되고 있지않습니다.");
            }

            // 6. Value 의 사용 유무 확인.
            if (MyDic.ContainsValue(100))
            {
                MessageBox.Show("값이 등록 되어있습니다.");
            }
            else
            {
                MessageBox.Show("값이 등록 되어 있지않습니다.");
            }

            // 7. Key로 데이터 삭제.
            MyDic.Remove("이십");
            if (!MyDic.ContainsKey("이십")) //느낌표가 없으면 트루값이기때문에 안나옴 그래서 느낌표를 넣어줘서 펄스값으로 만들어줌.
            {
                MessageBox.Show("이십 은 포함 되어있지 않습니다.");
            }
        
        
        }


    }
}
