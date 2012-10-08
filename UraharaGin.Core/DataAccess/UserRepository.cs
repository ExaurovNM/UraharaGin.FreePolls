using System;
using System.Linq;
using UraharaGin.Core.DBEntities;

namespace UraharaGin.Core.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public UserRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public RegisteredUser GetUserByCredentials(string email, string hashedPassword)
        {
            return this.dataBaseContext
                .RegisteredUsers
                .FirstOrDefault(x =>
                                    x.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase) &&
                                    x.PasswordHash == hashedPassword);
        }

        public RegisteredUser GetUserByEmail(string email)
        {
            return this.dataBaseContext.RegisteredUsers.FirstOrDefault(x => x.Email == email.ToLower());
        }
    }
}