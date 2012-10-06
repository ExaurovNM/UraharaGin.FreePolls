using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UraharaGin.FreePolls.Common;

namespace UraharaGin.FreePolls.Security
{
    public interface IHashProvider
    {
        string ComputePasswordHash(string email, string password);
    }

    class HashProvider : IHashProvider
    {
        private readonly Hasher hasher;

        public HashProvider()
        {
            this.hasher = new Hasher();
        }

        public string ComputePasswordHash(string email, string password)
        {
            string str = email + password;
            return this.hasher.ComputeHash(str);
        }
    }
}
