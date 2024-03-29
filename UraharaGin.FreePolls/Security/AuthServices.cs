using System;
using UraharaGin.Core.DBEntities;
using UraharaGin.Core.DataAccess;

namespace UraharaGin.FreePolls.Security
{
    using System.Web.Security;

    public class AuthServices : IAuthService
    {
        private readonly IUserRepository userRepository;
        private readonly IHashProvider hashProvider;

        public AuthServices(IUserRepository userRepository, IHashProvider hashProvider)
        {
            this.userRepository = userRepository;
            this.hashProvider = hashProvider;
        }

        public RegisteredUser GetAuthenticatedUser()
        {
            throw new NotImplementedException();
        }

        public RegisteredUser ValidateUser(string email, string password)
        {
            var hashedPassword = this.hashProvider.ComputePasswordHash(email, password);
            return this.userRepository.GetUserByCredentials(email, hashedPassword);
        }

        public void LogOn(string email, bool remeberMe)
        {
            FormsAuthentication.SetAuthCookie(email, remeberMe);
        }

        public void LogOff()
        {
            FormsAuthentication.SignOut();
        }
    }
}