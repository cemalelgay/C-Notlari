using KutuphaneOtomasyon.Entity.Model;
using KutuphaneOtomasyon.Entity.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DataAccess
{
    public class BookRepository
    {
        public static List<Entity.Model.VMBook> GetAllBooks()
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.Book.Select(b => new Entity.Model.VMBook()
                {
                    BookID = b.BookID,
                    BookName = b.BookName,
                    BookSubject = b.BookSubject,
                    PageCount = b.PageCount,
                    IsRented = b.IsRented,
                    ShelfNumber = b.ShelfNumber,
                    WriterName = b.Writer.WriterName
                }).ToList();
            }
        }

        public static void AddBook(Entity.Model.VMBook book)
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                db.Book.Add(book);
                db.SaveChanges();
            }
        }
    }
}
