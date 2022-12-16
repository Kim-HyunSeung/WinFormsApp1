using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assamble
{
    public partial class BaseChildForm : Form, iChildCommds
    {
        public BaseChildForm()
        {
            InitializeComponent();
        }
   
        public virtual void DoInqurie() { }
        public virtual void DoNew() { }
        public virtual void DoDelete() { }
        public virtual void DoSave() { }
    
    
    
    
    
    
    
    }

}
