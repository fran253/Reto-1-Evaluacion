namespace Models;

public abstract class Asiento {
    public int IdAsiento {get;set;}
    public int Fila {get;set;}
    public int Columna {get;set;}
    public int NumAsiento {get;set;}
    public double Estado {get;set;}




    public Asiento(int idasiento, int fila, int columna, int numasiento, double estado) {
        IdAsiento = idasiento;
        Fila = fila;
        Columna = columna;
        NumAsiento = numasiento;
        Estado = estado;
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