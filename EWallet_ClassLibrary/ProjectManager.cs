﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWallet_ClassLibrary
{
     public class ProjectManager : Student
    {
        public  ProjectManager(string contactemail, string contactnumber, string fname, string lname, string userrole, double hourlyrate, int studentid) : base(contactemail, contactnumber, fname, lname, userrole, hourlyrate, studentid)
        {

        }
    }
}