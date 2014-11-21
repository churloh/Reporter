using System.Data.Entity;
using Abp.EntityFramework;
using Reporter.Users;

namespace Reporter.EntityFramework
{
    public class ReporterDbContext : AbpDbContext
    {
        public virtual IDbSet<User> Users { get; set; }

        public ReporterDbContext()
            : base("Default")
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameOrConnectionString"></param>
        /// <remarks>
        /// This constructor is used by ABP to pass connection string defined in ReporterDataModule.PreInitialize.
        /// Notice that, actually you will not directly create an instance of ReporterDbContext since ABP automatically handles it.
        /// </remarks>
        public ReporterDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO: Make additional model setup...

            //modelBuilder.Entity<Person>().ToTable("TsPeople"); //Sample
        }
    }
}
