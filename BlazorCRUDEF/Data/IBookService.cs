using BlazorCRUDEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEF.Data
{
    public interface IBookService
    {
        //Definir los metodos asincronos usando Task

        //Metodo para obtener todos los libros
        Task<IEnumerable<Book>> GetAllBook();

        //Metodo para obtener detalles de un libro
        Task<Book> GetBookDetails(int id);

        //Metodo para insertar libros
        Task<bool> InsertBook(Book book);

        //Metodo para actualizar libros
        Task<bool> UpdateBook(Book book);

        //Metodo para borrar libros
        Task<bool> DeleteBook(int id);

        //Metodo para guardar libros
        Task<bool> SaveBook(Book book);

    }
}
