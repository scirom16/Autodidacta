//Programe un algoritmo que pida a usuario 2 números por pantalla
//y que muestre todos los números comprendidos entre ambos números incluyéndolos

//Declaramos variables
int num1, num2;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Por favor ingrese su primer número");
Console.ResetColor();
num1 = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Por favor ingrese su segundo número");
Console.ResetColor();
num2 = Convert.ToInt32(Console.ReadLine());

int i = num1++;

if (num1 < num2)
{
    while (i <= num2)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(i++ + ",");
        Console.ResetColor();
    }
}
else
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("El primer número debe ser inferior al segundo número");
    Console.ResetColor();
}

