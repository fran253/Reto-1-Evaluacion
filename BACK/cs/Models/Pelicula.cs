namespace Models;

public class Pelicula {
    public int IdPelicula {get;set;}
    public string Nombre {get;set;}
    public int Duracion {get;set;}
    public string Actores {get;set;}
    public string EdadMinima {get;set;}
    public DateTime FechaEstreno {get;set;}
    public DateTime Horario {get;set;}
    public string Descripcion {get;set;}
    public int IdEntrada {get;set;}
    public int IdSala {get;set;}



    public Pelicula(int idpelicula, string nombre, int duracion, string actores, string edadminima, DateTime fechaestreno, DateTime horario, string descripcion, int identrada, int idsala) {
        IdPelicula = idpelicula;
        Nombre = nombre;
        Duracion = duracion;
        Actores = actores;
        EdadMinima = edadminima;
        FechaEstreno = fechaestreno;
        Horario = horario;
        Descripcion = descripcion;
        IdEntrada = identrada;
        IdSala = idsala;
        // if (string.IsNullOrEmpty(nombre))
        // {
        //     throw new ArgumentException("Error: El nombre no puede estar vacío.");
        // }
        // if (precio < 0)
        // {
        //     throw new ArgumentException("Error: El precio no puede ser negativo.");
        // }
    }

    //public abstract void MostrarDetalles();

}