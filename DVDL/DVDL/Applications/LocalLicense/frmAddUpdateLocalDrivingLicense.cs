using DVDL.Users;
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
namespace DVDL.Applications.LocalLicense
{
    public partial class frmAddUpdateLocalDrivingLicense : Form
    {
        public  enum enFormMode{AddNewLocalDrivingLicense = 1 ,UpdateLocalDrivingLicense = 2 }
        
        public enFormMode FormMode;
        
        private int _LocalDrivingLicenseID = -1;
        
        private  static int _ApplicationTypeID = 1;
        
        private int _PersonID = -1;
        
        private int _ApplicationID = -1;
        
        private int _LicenseClassID = -1;
       
        private clsApplicationType _ApplicationType = clsApplicationType.FindApplicationTypeByID(_ApplicationTypeID);
        
        private clsLocalDrivingLicense _LocalDrivingLicense = new  clsLocalDrivingLicense();
        public frmAddUpdateLocalDrivingLicense()
        {
            InitializeComponent();
            FormMode = enFormMode.AddNewLocalDrivingLicense;
            
        }
        public frmAddUpdateLocalDrivingLicense(int LocalDrivingLicenseID)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            FormMode = enFormMode.UpdateLocalDrivingLicense;
            _LocalDrivingLicense = clsLocalDrivingLicense.FindLocalDrivingLicense(_LocalDrivingLicenseID);
            _LicenseClassID = _LocalDrivingLicense.LicenseClassID;
        }   
        private void _LoadDefaultInfo()
        {
            lbApplicationDate.Text = DateTime.Now.ToString("d");
            lbApplicationFees.Text = _ApplicationType.Fees.ToString();
            lbCreatedBy.Text = Global.CurrentUser.UserName;
        }
        private void frmAddUpdateLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            _LoadLicenseClasses();
            if (FormMode == enFormMode.AddNewLocalDrivingLicense)
            {
                (Tabs.TabPages["ApplicationInfoTab"]).Enabled = false;
                _LoadDefaultInfo();
            }
            else 
            {
            

            }

        }
        private void LoadLocalDrivingLicense() 
        {
            lbTitle.Text           = "Update Local Driving License";
            lbID.Text              = _LocalDrivingLicense.ApplicationID.ToString();
            lbCreatedBy.Text       = _LocalDrivingLicense.Application.CreatedByUserID.ToString();
            lbApplicationFees.Text = _LocalDrivingLicense.Application.PaiedFees.ToString();
            lbApplicationDate.Text = _LocalDrivingLicense.Application.ApplicationDate.ToString("d");
            cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString(_LocalDrivingLicense.LicenseCLass.ClassName);
            
        }
        private void _LoadLicenseClasses()
        {
            DataTable LicenseClasses = clsLicenseClass.GetAllLicenseClasses();

            for (int LicenseCounter = 0; LicenseCounter < LicenseClasses.Rows.Count; LicenseCounter++)
            {
                cbLicenseClasses.Items.Add(LicenseClasses.Rows[LicenseCounter]["ClassName"]);
            }
            cbLicenseClasses.SelectedIndex = 0;

        }
        private void ctrPersonInfoWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            btnNext.Enabled = true;
            btnSave.Enabled = true;
            Tabs.TabPages["ApplicationInfoTab"].Enabled = true;
      
            MessageBox.Show($" Person With ID({obj}) Has Been Selected Now , You Can Apply For Local License", "PersonSelected");
        }
        private void ctrPersonInfoWithFilter1_OnPersonAdded(int obj)
        {
            _PersonID = obj;
            btnNext.Enabled = true;
            btnSave.Enabled = true;
            Tabs.TabPages["ApplicationInfoTab"].Enabled = true;
            MessageBox.Show($" Person With ID({obj}) Has Been Added Now , You Can Apply For Local License", "PersonAdded");
        
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Tabs.SelectedTab = Tabs.TabPages["ApplicationInfoTab"];
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int AddApplicationAndGetApplicationID() 
        {
            clsApplication application = new clsApplication();
            application.ApplicationTypeID = _ApplicationType.ID;
            application.ApplicationMode = clsApplication.enApplicationMode.AddNewApplication;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationPersonID = _PersonID;
            application.ApplicationStatus = 1;
            application.CreatedByUserID = Global.CurrentUser.UserID;
            application.LastStatusDate = DateTime.Now;
            application.PaiedFees += _ApplicationType.Fees;
           if( application.Save()) return application.ApplicationID;
           return -1;

        }
        private int AddLicenseClassAndGetLicenseClassID()
        {

            clsLicenseClass licenseClass = clsLicenseClass.FindLicenseClasseByClassName(cbLicenseClasses.SelectedItem.ToString());
            _LicenseClassID = licenseClass.LicenseClassID;
            return _LicenseClassID;
        }
        private bool CanPersonApplyForLocalDrivingLicense() 
        {
            clsLocalDrivingLicense localDrivingLicense = clsLocalDrivingLicense.FindLocalDrivingLicenseByLicenseClassID(_LicenseClassID,_PersonID);
            if(localDrivingLicense == null) { return true; }
                if ( (localDrivingLicense.LicenseCLass.ClassName == cbLicenseClasses.SelectedItem.ToString() && localDrivingLicense.Application.StatusText == "Canceled" )   ) return true;
               
            _LocalDrivingLicenseID = localDrivingLicense.LocalDrivingLicenseID;
            return false;
     
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
         if(FormMode == enFormMode.AddNewLocalDrivingLicense) 
          {
                 int applicaionID =  AddApplicationAndGetApplicationID();
                 int LicenseClassID = AddLicenseClassAndGetLicenseClassID();
                _LocalDrivingLicense.LicenseClassID = LicenseClassID;
                _LocalDrivingLicense.ApplicationID = applicaionID;
          }



            if (!CanPersonApplyForLocalDrivingLicense()) 
            {
                MessageBox.Show($"This Person Can't  Have Application To this License Class ID With Local Driving Application ID {_LocalDrivingLicenseID}","Has New Application",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        

            if (_LocalDrivingLicense.Save()) 
            {
                lbTitle.Text = "Update Local Driving License ";
                lbID.Text    = _LocalDrivingLicense.LocalDrivingLicenseID.ToString();
                _LocalDrivingLicenseID  =  _LocalDrivingLicense.LocalDrivingLicenseID;
            }

        }

       


    }
}
