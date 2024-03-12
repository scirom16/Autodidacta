//Declaramos variables
int num1, num2, num3;

Console.WriteLine("Por favor ingrese su primer número: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Por favor ingrese su segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Por favor ingrese su tercer número: ");
num3 = Convert.ToInt32(Console.ReadLine());
int mayor = num1;

if (num2 > mayor)
{
    mayor = num2;
    if (num3 > mayor)
    {
        mayor = num3;
    }
}
Console.WriteLine("El número mayor es: " + mayor);