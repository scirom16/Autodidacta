//Escribir un algoritmo que dados 2 valores de entrada imprima siempre la división del mayor entre el menor. Validar indeterminación

//Declaramos las variables
using System.ComponentModel.Design;

double n1, n2;
string mensaje = "La división es indeterminada";

Console.WriteLine("Digite el primer número");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite el segundo número");
n2 = Convert.ToDouble(Console.ReadLine());

if (n1 > n2)
{
    if(n2 == 0)
    {
        Console.WriteLine(mensaje);
    }
    else
    {
        Console.WriteLine(n1 / n2);
    }
}
else if (n1 < n2)
{
    if(n1 == 0)
    {
        Console.WriteLine(mensaje);
    }
    else
    {
        Console.WriteLine(n2 / n1);
    }
}
