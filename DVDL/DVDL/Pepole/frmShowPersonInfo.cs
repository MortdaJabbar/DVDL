using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDLBussinesLogicTier;
namespace DVDL.Pepole
{
    public partial class frmShowPersonInfo : Form
    {
        private int _PersonId = -1;
        public frmShowPersonInfo(int MyPersonID)
        {

            InitializeComponent();
            _PersonId = MyPersonID;
           
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            
            ctrPersonInfo1.LoadPersonInfo(_PersonId);  

        }
    }
}
