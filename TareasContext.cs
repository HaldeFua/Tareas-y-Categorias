namespace Proyecto;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

public class TareasContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }
    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

}