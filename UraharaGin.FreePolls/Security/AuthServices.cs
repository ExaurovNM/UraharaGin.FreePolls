using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UraharaGin.Core.DBEntities;

namespace UraharaGin.FreePolls.Security
{
    public interface  IAuthService
    {
        RegisteredUser GetAuthenticatedUser();

        bool ValidateUser(string email, string password);

        void LogOn(string email);

        void LogOff();
    }

    public class AuthServices : IAuthService
    {
        public RegisteredUser GetAuthenticatedUser()
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void LogOn(string email)
        {
            throw new NotImplementedException();
        }

        public void LogOff()
        {
            throw new NotImplementedException();
        }
    }
}