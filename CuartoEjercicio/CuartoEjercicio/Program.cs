// Escribir un algoritmo que dados 2 valores de entrada imprima siempre la división del mayor entre el menor. Validar indeterminación.

//Declaramos las variables, serían 2

double num1, num2;

//Solicitamos la digitación de los 2 números

Console.Write("Ingrese el primer número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1 / num2);
}
else if (num2 > num1)
{
    Console.WriteLine(num2 / num1);
}
else
{
    Console.WriteLine("Los números son iguales");
}