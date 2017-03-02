using IMDBCemal.Entity;
using IMDBCemal.Entity.Model;
using IMDBCemal.Entity.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBCemal.DataAccess
{
    class FilmDepo
    {
        public static List<VMFilm> GetAllFilimler()
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                return db.Film.OrderByDescending(f => f.FilmPuani).Select(f => new VMFilm()
                {
                    YonetmenAdi = f.Yonetmen.YonetmenAdi,
                    FilmID = f.FilmID,
                    FilmAdi = f.FilmAdı,
                    Puan = f.FilmPuani,
                    TurAdi = f.Tur.TurAdi
                }).ToList();
            }
        }
        public static void OyVer(int id, double puan)
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                var result = db.Film.Find(id);
                result.FilmSayisi += 1;
                result.FilmPuani = ((result.FilmPuani * (result.FilmPuani - 1)) + puan) / (result.FilmPuani);
                db.SaveChanges();
            }
        }
        public static void FilmSil(int id)
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                db.Film.Remove(db.Film.Find(id));
                db.SaveChanges();
            }
        }
        public static Film FilmGetir(int id)
        {
            using (ImdbDBContext db = new ImdbDBContext())
            {
                return db.Film.Find(id);
            }
        }
    }
}
