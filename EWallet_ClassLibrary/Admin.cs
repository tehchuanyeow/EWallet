using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class Admin : User
    {
        public int adminID { get; set; }

        public Admin(string contactemail,string contactnumber,string fname,string lname,string userrole, int adminid ) : base(contactemail, contactnumber, fname, lname, userrole)
        {
            adminID = adminid;
        }
    }
}
