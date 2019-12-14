using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class LogicLayer
    {
        public Book[] GetBooks()
        {
            var db = new bookEntitiess();
            return db.Books.ToArray();
        }

        public Book GetBook(int id)
        {
            var db = new bookEntitiess();
            return db.Books.Find(id);
        }
    }
}
