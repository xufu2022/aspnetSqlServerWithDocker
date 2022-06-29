using Microsoft.EntityFrameworkCore;

namespace AspNetSqlDocker.Models {
    public class FilmContext : DbContext {
        public FilmContext(DbContextOptions<FilmContext> opt_Db) : base(opt_Db) {
        }
        public DbSet<Film> Film { get; set; }
    }
}
