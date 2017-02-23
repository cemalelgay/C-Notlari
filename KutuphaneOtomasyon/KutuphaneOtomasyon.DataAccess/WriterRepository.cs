using KutuphaneOtomasyon.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DataAccess
{
    public class WriterRepository
    {
        public static List<Writer> GetAllWriter()
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.Writer.ToList();
            }
        }
    }
}
