//Lea la longitud de 3 segmentos y muestre si se puede construir un triángulo con estos segmentos

//Declaramos las variables

double seg1, seg2, seg3;

//Solicitar los 3 segmentos al usuario

Console.Write("Ingrese la medida del primer segmento: ");
seg1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese la medida del segundo segmento: ");
seg2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese la medida del tercer segmento: ");
seg3 = Convert.ToInt32(Console.ReadLine());

if (seg1 + seg2 > seg3)
{
    Console.WriteLine("No se puede formar un triángulo con los segmentos dados");
}
else if(seg1 + seg2 < seg3)
{
    Console.WriteLine("Se puede formar el triángulo");
}