using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWallet.Models
{
    public class Permissions
    {
        public Permissions(string perm)
        {
            Permission = perm;
        }
        public string Permission { get; set; }
    }
}