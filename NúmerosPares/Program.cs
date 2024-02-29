//Construir un programa que pida un número y luego diga si este número es par o no.

//Declaramos las variables

using System.ComponentModel.Design;

int num;
double residuo;
string mensaje;

//Realizamos la solicitud del número en la consola

Console.Write("Por favor digite un número mayor a 0: ");
num = Convert.ToInt32(Console.ReadLine());

//Definimos la operación

residuo = num % 2;

//Agregamos el condicional

if (residuo == 0)
{
    mensaje = "El número ingresado es par";
}
else
{
    mensaje = "El número ingresado es Impar";
}

//Imprimimos al valor resultante de la variable mensaje

Console.Write(mensaje);