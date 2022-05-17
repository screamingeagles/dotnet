// Install-Package EntityFramework                          -Version 6.0.0
// Install-Package Oracle.DataAccess.x86.4                  -Version 4.112.3
// Install-Package Oracle.ManagedDataAccess                 -Version 21.6.1
// Install-Package Oracle.ManagedDataAccess.EntityFramework -Version 21.5.0

namespace code_test.Models
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public class AppModel : DbContext
    {
        public AppModel() : base("name=AppModel")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.HasDefaultSchema("DBA");
        }

        public IDbSet<T_CATEGORY> CATEGORIES { get; set; }
        public IDbSet<T_DESIGNATION> DESIGNATIONS { get; set; }
    }
}
