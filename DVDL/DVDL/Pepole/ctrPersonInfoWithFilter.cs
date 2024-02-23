using DVDLBussinesLogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL.Pepole
{
    public partial class ctrPersonInfoWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void SelectedPerson(int personID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(personID);
               
            }

        }

        public event Action<int> OnPersonAdded;
        protected virtual void AddedPerson(int PersonID)
        {
            Action<int> handler = OnPersonAdded;
            if (handler != null)
            { handler(PersonID); }

        }
        public clsPerson Person = null;
        public string FilterValue { get { return txtFilter.Text; } set { txtFilter.Text = value; } }
        public bool GbFilterEnable { get { return groupBox1.Enabled; } set { groupBox1.Enabled = value; } }
        public ctrPersonInfoWithFilter()
        {
            InitializeComponent();
            cbFilter.SelectedItem ="PersonID";
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (cbFilter.SelectedItem.ToString() == "PersonID");
        }
        private void pbFind_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text.Trim() != "")
            {
                if (cbFilter.SelectedItem.ToString() == "PersonID")
                {
                    Person = clsPerson.FindPersonByID(Convert.ToInt32(txtFilter.Text));
                    if (Person != null) 
                    { 
                        ctrPersonInfo1.LoadPersonInfo(Person.PersonID);
                        
                    }
                    else
                    {
                        MessageBox.Show($"Person With PersonID : {txtFilter.Text}");
                        ctrPersonInfo1.ResetInfo();
                    }

                }
                else if (cbFilter.SelectedItem.ToString() == "NationalNo")
                {
                    Person = clsPerson.FindPersonByNationalNo(txtFilter.Text);
                    if (Person != null) { ctrPersonInfo1.LoadPersonInfo(Person.PersonID); }
                    else
                    {
                        MessageBox.Show($"Person With NationalNo : {txtFilter.Text}");
                        ctrPersonInfo1.ResetInfo();
                    }

                }

                if (OnPersonSelected != null)
                {
                    OnPersonSelected(Person.PersonID);
                    
                }


            }
        }
        private void pbAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.DataBack += FillTheNewPersonInfo;
            frm.ShowDialog();


        }
        public void FillPersonInfo(int PersonID) 
        {
            Person = clsPerson.FindPersonByID(PersonID);
            ctrPersonInfo1.LoadPersonInfo(PersonID);
           
           
        }
        public void ResetInfo() 
        {
            ctrPersonInfo1.ResetInfo();
            cbFilter.SelectedItem = "PersonID";
            EnableFilter();
        }
        private void FillTheNewPersonInfo(object sender,int PersonID)
        {
            Person = clsPerson.FindPersonByID(PersonID);
            FillPersonInfo(PersonID);

            if (OnPersonAdded != null) 
            {
                OnPersonAdded(Person.PersonID);
                
            }
        }
        public void DisableFilter() { groupBox1.Enabled = false; }
        public void EnableFilter() { groupBox1.Enabled = true; }


    }
}
