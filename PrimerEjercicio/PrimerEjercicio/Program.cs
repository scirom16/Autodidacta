//Imprimir 4 números en pantalla que representen 2 puntos en el plano R2 y halle su distancia

//Declaramos las variables

int x1, x2, y1, y2;
double distancia;

//Imprimimos la solicitud de los números

Console.Write("Ingrese su primer número: ");
x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese su segundo número: ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese su tercer número: ");
x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese su cuarto número: ");
y2 = Convert.ToInt32(Console.ReadLine());

//Mostramos los pares ordenados

Console.WriteLine("(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ")");
Console.WriteLine();

//Definimos las operaciones

distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));

//Imprimir resultado

Console.WriteLine("La distancia entre los 2 puntos es: " + distancia);