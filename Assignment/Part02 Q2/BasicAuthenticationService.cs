using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02_Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public BasicAuthenticationService(string? UserName , string? Password, string? Role)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }
        public bool AuthenticateUser(string? UserName,string? Password)
        {
           if(this.UserName == UserName && this.Password == Password) 
                return true;
           else 
                return false;
        }

        public bool AuthorizeUser(string? UserName , string? Role)
        {
           if(this.UserName ==  UserName && this.Role == Role)
            {
                return true;
            }
           else
                return false;
        }

       
    }
}
