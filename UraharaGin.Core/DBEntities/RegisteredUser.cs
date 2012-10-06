using System;

namespace UraharaGin.Core.DBEntities
{
    public class RegisteredUser
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }
    }
}