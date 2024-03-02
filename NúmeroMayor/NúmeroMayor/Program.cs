//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.

//Declaramos variables

double num1, num2, num3;

//Solicitamos el ingreso de los números

Console.Write("Por favor ingrese su primer número: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Por favor ingrese su segundo número: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Por favor ingrese su tercer número: ");
num3 = Convert.ToDouble(Console.ReadLine());

//Realizamos el condicional

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine(num1 + " es el mayor");
    }
}
else if (num2 > num1)
{
    if (num2 > num3)
    {
        Console.WriteLine(num2 + " es el mayor");
    }
    else if (num3 > num2)
    {
        Console.WriteLine(num3 + " es el mayor");
    }
}
else
{
    if(num1==num2 && num2==num3)
    {
        Console.WriteLine("Los números ingresados son iguales");
    }
}
