using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace Proyecto.Models;

public class TareasContext : DbContext
{
    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<Tarea> Tareas { get; set; }
    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

}