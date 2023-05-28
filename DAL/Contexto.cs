using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL;
public class Contexto : DbContext
{
    public DbSet<Tickets> Tickets {get;set;} = null!;
    public Contexto(DbContextOptions<Contexto> Options) : base(Options) { }
}