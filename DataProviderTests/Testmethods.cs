using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataProviderTests
{
    public class Testmethods
    {
       ClinicalDbEntities db=new ClinicalDbEntities();
        public bool Admin_Check()
        {
            bool result = false;
            var found=db.Users.ToList();
            if (found[0].Email == "lohith@yahoo.com" && found[0].Password=="lohith@987")
            {
                result = true;
            }
            return result;
        }
        public bool Doctor_Check()
        {
            bool result = false;
            var found=db.Users.ToList();
            if (found[0].Email =="gaythri@gmail.com" && found[0].Password == "gaythri@123")
            {
                result = true;
            }
            return result;
        }
        public bool Frontofficier_Check()
        {
            bool result = false;
            var found = db.Users.ToList();
            if (found[0].Email == "ram@yahoo.com" && found[0].Password == "Ram@1234")
            {
                result = true;
            }
            return result;
        }
        public bool Pharmacist_Check()
        {
            bool result = false;
            var found = db.Users.ToList();
            if (found[0].Email == "riya@email.com" && found[0].Password == "123456")
            {
                result = true;
            }
            return result;
        }
        public bool Patient_Check()
        {
            bool result = false;
            var found = db.Users.ToList();
            if (found[0].Email == "sam@gmail.com" && found[0].Password == "sam789")
            {
                result = true;
            }
            return result;
        }
    }
}
