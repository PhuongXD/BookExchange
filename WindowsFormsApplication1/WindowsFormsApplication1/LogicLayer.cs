using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;


namespace WindowsFormsApplication1
{
    public class LogicLayer
    {
        
        public Book[] GetBooks()
        {
            var db = new bookEntities();
            return db.Books.ToArray();
        }

        public Book GetBook(int id)
        {
            var db = new bookEntities();
            return db.Books.Find(id);
        }

        public void AddBook(string namebook, string author, string nameuser, string topic, string type)
        {
            var book = new Book();
            book.NameBook = namebook;
            book.Author = author;
            book.NameUser= nameuser;
            book.Topic = topic;
            book.TypeExchange = type;


            var db = new bookEntities();
            db.Books.Add(book);
            db.SaveChanges();
        }
        public void UpdateBook(int id, string namebook, string author, string 
            topic, string type)
        {
            var db = new bookEntities();
            var book = db.Books.Find(id);

            book.NameBook = namebook;
            book.Author = author;
            book.TypeExchange = type;

            db.Entry(book).State = EntityState.Modified; 
            db.SaveChanges();
        }
        public void DeleteBook(int id)
        {
            var db = new bookEntities();
            var book = db.Books.Find(id);

            db.Books.Remove(book);
            db.SaveChanges();
        }
    }
}
