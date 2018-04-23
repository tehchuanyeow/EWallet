using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class Teacher : User
    {
        public string staffDept { get; set; }
        public int staffId { get; set; }
        public Teacher(string contactemail, string contactnumber, string fname, string lname, string userrole, string staffdept, int staffid): base(contactemail, contactnumber, fname, lname, userrole)
        {
            staffDept = staffdept;
            staffId = staffid;
        }

    }
}
