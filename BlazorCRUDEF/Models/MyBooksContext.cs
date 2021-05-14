using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEF.Models
{
    //La clase hereda de "DbContext" que hace parte de Entity Framework
    public class MyBooksContext : DbContext
    {   
        //Representacion del modelo de tabla 
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Acceso a SQL Server para construir el servidor
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TPMDQ76;Initial Catalog=BlazorCRUDEF2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
