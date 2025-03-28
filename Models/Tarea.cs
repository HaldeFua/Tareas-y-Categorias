using System.Data;

namespace TareasYCategorias.Models;

public class Tarea {
    public Guid TareaId { get; set;}
    public Guid CategoriaId { get; set;}
    public string Titulo {get;set;}    
    public string Descripcion {get;set;}
    public Prioridad PrioridadTarea {get;set;}
    public DataSetDateTime FechaCreacion {get;set;}
    public virtual Categoria Categoria {get;set;}
}

public enum Prioridad 
{
    Baja,
    Media,
    Alta

}