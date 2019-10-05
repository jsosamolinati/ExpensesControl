using Expenses.Data.Mapping.Expenses;
using Expenses.Entities.Expenses;
using Microsoft.EntityFrameworkCore;

namespace Expenses.Data
{
    public class DbContextExpenses : DbContext
    {
        public DbSet<ExpensesType> ExpensesTypes { get; set; }
        //public DbSet<Articulo> Articulos { get; set; }
        //public DbSet<Rol> Roles { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Persona> Personas { get; set; }

        public DbContextExpenses(DbContextOptions<DbContextExpenses> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ExpensesTypeMap());
            //modelBuilder.ApplyConfiguration(new ArticuloMap());
            //modelBuilder.ApplyConfiguration(new RolMap());
            //modelBuilder.ApplyConfiguration(new UsuarioMap());
            //modelBuilder.ApplyConfiguration(new PersonaMap());
        }
    }
}
