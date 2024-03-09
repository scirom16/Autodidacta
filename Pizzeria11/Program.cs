//La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes.
//Los ingredientes para cada tipo de pizza aparecen a continuación.
//Ingredientes vegetarianos: Pimiento y tofu.
//Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
//Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariana o no,
//y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija.
//Solo se puede elegir un ingrediente además de la
//mozzarella y el tomate que están en todas las pizzas.
//Al final se debe mostrar por pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.

Console.WriteLine("¿Qué pizza le gustaría comprar?");
Console.WriteLine("para vegetariana digite 1, para no vegetariana digite 2");
int pizza = Convert.ToInt32(Console.ReadLine());

switch (pizza)
{
    case 1:
        Console.WriteLine("Los ingredientes de la pizza vegetariana son:");
        Console.WriteLine("Pimiento y Tofu");
    break;
    case 2:
        Console.WriteLine("Los ingredientes de la pizza no vegetariana son:");
        Console.WriteLine("Peperoni, Jamón y Salmón");
        break;

}
Console.WriteLine("¿Qué ingrediente desea añadir a su pizza?" + pizza);
