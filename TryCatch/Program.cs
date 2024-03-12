try
{
    double precio, total;
    int cantidad;

    Console.WriteLine("Cantidad: ");
    cantidad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Precio: ");
    precio = Convert.ToInt32(Console.ReadLine());

    total = cantidad * precio;

    Console.WriteLine("El total es: " + total);
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error: "+ error.Message);
}
