using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWallet.Models
{
    public class Users
    {
        public Users(string username, string userpassword, string userpermission)
        {
            Username = username;
            UserPassword = userpassword;
            UserPermission = userpermission;
        }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string UserPermission { get; set; }
    }
}
