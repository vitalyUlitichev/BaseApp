using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataModels;

namespace DataContext
{
    public class  UserContext: DbContext
    {
        public UserContext(string connString) : base(connString)
        {}
        public DbSet<UserDataModel> Users { get; set; }
    }
}