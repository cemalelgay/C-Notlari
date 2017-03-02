using IMDBCemal.Entity;
using IMDBCemal.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBCemal.DataAccess
{
    class TurDepo
    {
        public static List<Tur> GetAllTurler()
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                return db.Tur.ToList();
            }
        }
        public static void TurEkle(Tur _tur)
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                db.Tur.Add(_tur);
                db.SaveChanges();
            }
        }
    }
}
