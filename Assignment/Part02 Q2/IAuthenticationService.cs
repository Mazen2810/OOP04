using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02_Q2
{
    internal interface IAuthenticationService
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public bool AuthenticateUser(string? UserName, string? Password);
        public bool AuthorizeUser(string? UserName, string? Role);
    }
}
