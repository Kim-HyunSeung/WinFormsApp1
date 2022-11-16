using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyfirstCSharp
{
    public partial class Chap12_ClassTest_Run : Form
    {

       
        public Chap12_ClassTest_Run()
        {
            InitializeComponent();
           
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        
          
            Chap12_ClassTest_Main.sRunStopStatus = "가동중";
         


        }
    }
}
