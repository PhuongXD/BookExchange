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
            var db = new bookEntities2();
            return db.Books.ToArray();
        }

        public Book GetBook(int id)
        {
            var db = new bookEntities2();
            return db.Books.Find(id);
        }

        public void CreateStudent(string namebook, string author, string nameuser, string topic, string type, int id)
        {
            var book = new Book();
            book.NameBook = namebook;
            book.Author = author;
            book.NameUser= nameuser;
            book.Topic = topic;
            book.TypeExchange = type;
            book.id = id;

            var db = new bookEntities2();
            db.Books.Add(book);
            db.SaveChanges();
        }
        public void UpdateBook(int id, string namebook, string author, string nameuser, string 
            topic, string type)
        {
            var db = new bookEntities2();
            var book = db.Books.Find(id);

            book.NameBook = namebook;
            book.Author = author;
            book.TypeExchange = type;
            book.id = id;

            db.Entry(book).State = System.Data.EntityState.Modified; 
            db.SaveChanges();
        }
        public void DeleteBook(int id)
        {
            var db = new bookEntities2();
            var book = db.Books.Find(id);

            db.Books.Remove(book);
            db.SaveChanges();
        }

        public User[] GetClasses()
        {
            var db = new bookEntities2();
            return db.Users.ToArray();
        }

    }
}
