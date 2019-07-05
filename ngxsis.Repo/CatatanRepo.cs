using ngxsis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Repo
{
    public class CatatanRepo
    {
        public static List<x_catatan> GetAll()
        {
            List<x_catatan> result = new List<x_catatan>();
            using (DataContext db = new DataContext())
            {
                result = db.x_catatan.ToList();
            }
            return result;
        }
    }
}
