using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstCSharp
{

    public partial class Test01 : Form
    {
        Random Ran = new Random();
        int[] iValues = new int[20];
        int iFindValue = 0;
        public Test01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            for (int i = 0; i < iValues.Length; i++)
            {
                int iValue = Ran.Next(0, 20);
                textBox1.Text += Convert.ToString($" {iValue} ");
                iValues[i] = iValue;

                for (int j = 0; j < iValues.Length; j++)
                {
                    if (iValues[i] == j) continue;             
                    if (iValues[i] != j) iFindValue += j;
              
                }
               
            }
            MessageBox.Show($"난수중{Convert.ToString(iValues)}가 없으며 총 합은 : {iFindValue} 입니다.");
        }
    }
}
