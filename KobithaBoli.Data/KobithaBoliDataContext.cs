using System;
using System.Collections.Generic;
using System.Data.Entity;
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



    }
}
