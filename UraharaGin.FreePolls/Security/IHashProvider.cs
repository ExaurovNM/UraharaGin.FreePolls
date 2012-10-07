using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UraharaGin.FreePolls.Security
{
    public interface IHashProvider
    {
        string ComputePasswordHash(string email, string password);
    }
}
