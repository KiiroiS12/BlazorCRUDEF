using BlazorCRUDEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEF.Data
{
    public class BookService : IBookService
    {
        // Inyección del "context" por medio de inyección de dependencias 14-19
        //Linea 34 - 35 del Startup.cs
        private readonly MyBooksContext _context;

        public BookService(MyBooksContext context)
        {
            _context = context;
        }

        //IDENTITY FRAMEWORK en los Metodos

        //_context: Base de datos
        //.Books: Tabla en la base de datos
        

        //Eliminar libro
        public async Task<bool> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);

            _context.Books.Remove(book);

            return await _context.SaveChangesAsync() > 0;
        }

        //Obtener libros
        public async Task<IEnumerable<Book>> GetAllBook()
        {
            return await _context.Books.ToListAsync();
        }

        //Obtener detalles de un libro
        public async Task<Book> GetBookDetails(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        //Insertar libros
        public async Task<bool> InsertBook(Book book)
        {
            _context.Books.Add(book);

            return await _context.SaveChangesAsync() > 0;
        }

        //Guardar libros
        public async Task<bool> SaveBook(Book book)
        {
            if (book.BookId > 0)
                return await UpdateBook(book);
            else
                return await InsertBook(book);

        }

        //Actualizar libros
        public async Task<bool> UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;

        }
    }
}
