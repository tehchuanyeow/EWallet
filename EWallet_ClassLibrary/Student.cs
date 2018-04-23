using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
    public class Student : User
    {
        public double hourlyRate { get; set; }
        public int studentID { get; set; }

        public Student(string contactemail, string contactnumber, string fname, string lname, string userrole, double hourlyrate, int studentid) :base(contactemail, contactnumber, fname, lname, userrole){
            hourlyRate = hourlyrate;
            studentID = studentid;
        }
    }
}
