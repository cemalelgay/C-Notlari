using IMDBCemal.Entity.Model;
using IMDBCemal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBCemal.DataAccess
{
    public class YonetmenDepo
    {
        public static List<Yonetmen> GetAllYonetmenler()
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                return db.Yonetmen.ToList();
            }
        }
        public static void YonetmenSil(int id)
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                db.Yonetmen.Remove(db.Yonetmen.Find(id));
                db.SaveChanges();
            }
        }
        public static Yonetmen YonetmenGetir(int id)
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                return db.Yonetmen.Find(id);
            }
        }
        public static void YonetmenEkle(Yonetmen _yonetmen)
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                db.Yonetmen.Add(_yonetmen);
                db.SaveChanges();
            }
        }
        public static void YonetmenGuncelle(Yonetmen _yonetmen)
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                var result = db.Yonetmen.Find(_yonetmen.YonetmenID);
                result.YonetmenAdi = _yonetmen.YonetmenAdi;
                db.SaveChanges();
            }
        }
    }
}