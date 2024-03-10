using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVDLBussinesLogicTier.clsApplicationType;

namespace DVDLBussinesLogicTier
{
    public class clsTestType
    {
        public enum enMode {AddNew=1,Update=2 }
        public enMode Mode = enMode.AddNew;
        public int     ID { get; set; }
        public string  Title { get; set; }
        public string  Description { get; set; }
        public Decimal Fees {get; set;}
       
        public clsTestType() { this.ID = -1; this.Title = ""; this.Fees = 0;  this.Description = ""; this.Mode = enMode.AddNew; }
        public clsTestType(int ID , string Title , string Description,Decimal Fees) { this.ID = ID; this.Description = Description; this.Title = Title; this.Fees = Fees; this.Mode = enMode.Update; }
        public static DataTable GetAllTestTypes() 
        {
            return DVDLAccessDataTier.clsTestTypes.GellTestTypes();
        }
        public static bool _UpdateTestTypes(int TestTypeID,string TestTypeTitle,string TestTypeDescription,Decimal Fees)
        {
            return DVDLAccessDataTier.clsTestTypes.UpdateTestType(TestTypeID, TestTypeTitle, TestTypeDescription, Fees);
        }
        public static clsTestType GetTestTypeByID(int TestTypeID) 
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            Decimal TestTypeFees = 0;
            if (DVDLAccessDataTier.clsTestTypes.FindTestTypeByID(TestTypeID,ref TestTypeTitle,ref TestTypeDescription, ref TestTypeFees)) 
            {
                return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }

            return null;
        }
        public bool Save() 
        {

            switch (Mode)
            {
                case enMode.Update:
                    return _UpdateTestTypes(this.ID, this.Title, this.Description,this.Fees);
                   

            }

            return false;
        }

    }
}
