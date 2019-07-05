using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Model
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Name=NgxsisConn")
        {
            //Database.SetInitializer(new Initializer());
            Database.SetInitializer<DataContext>(null);
        }

        public virtual DbSet<x_addrbook> x_addrbook { get; set; }

        public virtual DbSet<x_address> x_address { get; set; }
        public virtual DbSet<x_biodata> x_biodata { get; set; }
        public virtual DbSet<x_biodata_attachment> x_biodata_attachment { get; set; }
        public virtual DbSet<x_catatan> x_catatan { get; set; }
        public virtual DbSet<x_company> x_company { get; set; }
        public virtual DbSet<x_educational_level> x_educational_level { get; set; }
        public virtual DbSet<x_note_type> x_note_type { get; set; }
    }
}
