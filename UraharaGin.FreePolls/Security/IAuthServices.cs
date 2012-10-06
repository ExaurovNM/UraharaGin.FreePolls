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
}