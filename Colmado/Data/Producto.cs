namespace Colmado.Data;

public class Producto
{
    public string Descripcion {get; set;}
    public float Cantidad {get; set;}
    public decimal Precio {get; set;}
    public decimal SubTotal => (decimal)Cantidad * Precio;
}