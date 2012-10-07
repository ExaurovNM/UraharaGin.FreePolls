using System.Data.Entity;
using UraharaGin.Core.DBEntities;

namespace UraharaGin.Core.DataAccess
{
    public class DataBaseContext : DbContext
    {
        public IDbSet<Poll> Polls { get; set; }

        public IDbSet<Answer> Answers { get; set; }

        public IDbSet<AnonymousUser> Anonymous { get; set; }

        public IDbSet<RegisteredUser> RegisteredUsers { get; set; } 
    }
}
