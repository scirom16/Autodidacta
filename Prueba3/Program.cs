//Construir un algoritmo que pida N números por pantalla,
//cuando el usuario ingrese un número negativo,
//el programa debe finalizar y mostrar en consola la cantidad total de números positivos
//que ingresó hasta antes de ingresarse el número negativo.

//Declaramos variables
int num, num2;

//Solicitamos el número por consola
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Por favor ingrese un número positivo");
Console.ResetColor();
num = Convert.ToInt32(Console.ReadLine());
num2 = num + 1;

while (num >= 0)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Por favor ingrese un número positivo");
    Console.ResetColor();
    num = Convert.ToInt32(Console.ReadLine());
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Ingresaste un número negativo, haz salido del bucle" + num2);
Console.ResetColor();