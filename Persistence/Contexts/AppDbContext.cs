using Microsoft.EntityFrameworkCore;

namespace Supermercado.API.Persistence.Contexts {
  public class AppDbContext: DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

    }
  }
}