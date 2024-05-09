using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Licenta.Formulare
{
    public class BookClass
    {
        
        public string NameBook { get; set; }
        public Guid ID { get; set; }
        public string AuthorBook { get; set; }

        public BookClass(string NameBook, string AuthorBook)
        {
            ID = new Guid();
            this.NameBook = NameBook;
            this.AuthorBook = AuthorBook;
            
        }


    }
}
