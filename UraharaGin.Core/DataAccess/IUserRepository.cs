using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UraharaGin.Core.DBEntities;

namespace UraharaGin.Core.DataAccess
{
    public interface IUserRepository
    {
        RegisteredUser GetUserByCredentials(string email, string hashedPassword);

        RegisteredUser GetUserByEmail(string email);
    }
}
