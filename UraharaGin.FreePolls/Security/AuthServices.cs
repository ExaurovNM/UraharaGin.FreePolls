using System;
using UraharaGin.Core.DBEntities;
using UraharaGin.Core.DataAccess;

namespace UraharaGin.FreePolls.Security
{
    public class AuthServices : IAuthService
    {
        private readonly IUserRepository userRepository;

        public AuthServices(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

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