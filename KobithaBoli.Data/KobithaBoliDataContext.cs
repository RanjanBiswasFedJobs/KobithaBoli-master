using KobithaBoli.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KobithaBoli.Data
{
    public class KobithaBoliDataContext : DbContext
    {

         static KobithaBoliDataContext()
        {
           // Database.SetInitializer(new CodeCamperDatabaseInitializer());
        }


         public KobithaBoliDataContext()
            : base(nameOrConnectionString: "KobithaBoli") { }


         public DbSet<Poem> Poems { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
             modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         }
    }
}
