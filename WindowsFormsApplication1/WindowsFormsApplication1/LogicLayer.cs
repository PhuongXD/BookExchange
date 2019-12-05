using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class LogicLayer
    {
        public Book[] GetBooks()
        {
            var db = new bookEntities();
            return db.Books.ToArray();
        }

        public Book[] GetBook(int id)
        {
            var db = new bookEntities();
            return db.Books.Find(id);
        }
    }
}
