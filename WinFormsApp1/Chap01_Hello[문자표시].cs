using System.Windows.Forms;

namespace WinFormsApp1
{
    //VisualStudio : �� ?
    //����ũ�� ����Ʈ ������ , MacOs���� �����ϸ� 
    //�پ��� ���� ���α׷��� �� �� �ִ� ���� ���� ȯ��
    // ( IDE . INtergated Development Enviroment)

    // 2. C# �̶� ?
    // �����ڰ� �����ϰ����ϴ� ������ ��ǻ�Ͱ� ���� �� �� 
    // �ֵ��� �ϱ� ���ؼ��� ��ǻ�Ͱ� �˾Ƶ����� �ִ� ���
    // �� �ؼ��ϱ� ���� ������ �ʿ�
    // ��ǻ�Ͱ� ���� �� �� �ִ� ���� ��ȯ�ؾ��ϴ� ������ 
    // �ۼ��ϴ� ��ü���� ���α׷� ����� �� ����
    // (C#, JAVA, Python, JavaScript)

    // 3. �� C# dlsrk?
    //  ��� �Ǵ� ���񿡼� �����ϴ� ���� �� �����ϱ� ����. (API : Application Programing Interface)
    //  �ý����� ��ϴ� ��� �� ����� 
    //  ��ǻ�� ȯ���� ��ټ� Windos OS�̴�.
    //  �����ڿ� ����ڰ� ���ϴ� ����� ��Ȯ�ϰ� 
    //  ������ ���� �� �� �ֵ��� �Ѵ�.

    public partial class Chap01_Hello : Form
    {
        public Chap01_Hello()
        {
            InitializeComponent(); //�޼���(�Լ�) ȣ��
            textBox1.Text = "hello"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
        private void txt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }


    }
}