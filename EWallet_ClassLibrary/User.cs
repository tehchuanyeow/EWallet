using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class User
    {
        public string contactEmail { get; set; }
        public string contactNumber { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string userRole { get; set; }

       

        public User(string contactemail, string contactnumber, string fname, string lname, string userrole)
        {
        contactEmail = contactemail;
        contactNumber = contactnumber;
            fName = fname;
            lName = lname;
            userRole = userrole;
        }
    }
}
