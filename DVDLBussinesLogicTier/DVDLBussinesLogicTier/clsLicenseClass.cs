using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DVDLAccessDataTier;
namespace DVDLBussinesLogicTier
{
    public class clsLicenseClass
    {
        public enum enLicenseClassMode {AddNewLicenseClass = 1 , UpdateLicenseClass=2 }
        public enLicenseClassMode LicenseClassMode;
        public  int    LicenseClassID { get; set; }
        public  string ClassName { get; set; }
        public  string ClassDescription { get; set; }
        public  byte   MinmumAllowedAge { get; set; }
        public  byte   DefaultValidityLength { get; set; }
        public  Decimal ClassFees { get; set; }
        public clsLicenseClass() 
        {
            this.LicenseClassID = -1;
            this.ClassFees = 0;
            this.DefaultValidityLength = 0;
            this.MinmumAllowedAge = 0;
            this.ClassName = "";
            this.ClassDescription = "";
            this.LicenseClassMode = enLicenseClassMode.AddNewLicenseClass;
        }
        public clsLicenseClass(int LicenseClassID,string ClassName,string ClassDescription,byte MinumumAllowedAge,byte DefaultValidityLength,Decimal ClassFees)
        {
            this.LicenseClassID         = LicenseClassID;
            this.ClassFees              = ClassFees;
            this.DefaultValidityLength  = DefaultValidityLength;
            this.MinmumAllowedAge       = MinumumAllowedAge;
            this.ClassName              = ClassName;
            this.ClassDescription       = ClassDescription;
            this.LicenseClassMode = enLicenseClassMode.UpdateLicenseClass;
        }
        public static DataTable GetAllLicenseClasses() { return DVDLAccessDataTier.clsLicenseClassesData.GetAllLicenseClasses(); }
        public static clsLicenseClass  FindLicenseClasseByID(int LicenseClassID) 
        {
            string ClassName = "", ClassDescription = "";  
            byte MinumumAllowedAge = 0, DefaultValidityLength = 0;
            Decimal ClassFees = 0;
            if (DVDLAccessDataTier.clsLicenseClassesData.FindLicenseClassesByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinumumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinumumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else return null;
        }
        public static clsLicenseClass FindLicenseClasseByClassName(string ClassName)
        {
            int LicenseClassID = -1;  string ClassDescription = "";
            byte MinumumAllowedAge = 0, DefaultValidityLength = 0;
            Decimal ClassFees = 0;
            if (DVDLAccessDataTier.clsLicenseClassesData.FindLicenseClassesByClassName(ClassName,ref LicenseClassID, ref ClassDescription, ref MinumumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinumumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else return null;
        }
        private  bool  _AddLicenseClasse( string ClassName, string ClassDescription, byte MinumumAllowedAge, byte DefaultValidityLength, Decimal ClassFees)
        {
            int LicenseClasseID =  DVDLAccessDataTier.clsLicenseClassesData.AddLicenseClasse(ClassName,ClassDescription,MinumumAllowedAge,DefaultValidityLength,ClassFees);
            return (LicenseClasseID != -1);
        }
        private bool _UpdateLicenseClasse(int LicenseClassID, string ClassName, string ClassDescription, byte MinumumAllowedAge, byte DefaultValidityLength, Decimal ClassFees)
        {
            return  DVDLAccessDataTier.clsLicenseClassesData.UpdateLicenseClasse(LicenseClassID,ClassName, ClassDescription, MinumumAllowedAge, DefaultValidityLength, ClassFees);
        }
        public bool Save() 
        {
            switch (LicenseClassMode) 
            {
                case enLicenseClassMode.UpdateLicenseClass: 
                    {
                        return _UpdateLicenseClasse(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinmumAllowedAge, this.DefaultValidityLength, this.ClassFees);
                    }
                case enLicenseClassMode.AddNewLicenseClass: 
                    {
                        if (_AddLicenseClasse(this.ClassName, this.ClassDescription, this.MinmumAllowedAge, this.DefaultValidityLength, this.ClassFees)) { this.LicenseClassMode = enLicenseClassMode.UpdateLicenseClass; return true; }
                    }break;
            
            }

            return false;
        }

    }
}
