using Microsoft.EntityFrameworkCore;
using ConexionBd.Models;

namespace ConexionBd.Data{
    public class BaseContext :DbContext{
        //Declarar constructor
        public BaseContext(DbContextOptions<BaseContext> options) : base(options){

        }

        //Registramos nuestros modelos
      public DbSet<User> users { get; set; }

    }
}