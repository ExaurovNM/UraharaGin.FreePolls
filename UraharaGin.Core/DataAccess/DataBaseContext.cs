namespace UraharaGin.Core.DataAccess
{
    using System.Data.Entity;

    using UraharaGin.Core.DBEntities;

    public class DataBaseContext : DbContext
    {
        public IDbSet<Poll> Polls { get; set; }

        public IDbSet<Answer> Answers { get; set; }

        public IDbSet<AnonymousUser> Anonymous { get; set; }

        public IDbSet<RegisteredUser> RegisteredUsers { get; set; } 
    }
}
