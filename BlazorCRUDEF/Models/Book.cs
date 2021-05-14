using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEF.Models
{
    public class Book
    {
        //Elementos para la tabla

        //Id del libro
        public int BookId { get; set; }

        //Titulo o nombre del libro
        public string Title { get; set; }

        //Nombre del autor del libro
        public string Author { get; set; }
    }
}
