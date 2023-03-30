using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWDed.Models
{
    public class User
    {
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }
        public string DecryptedPassword { get; set; }
    }
}