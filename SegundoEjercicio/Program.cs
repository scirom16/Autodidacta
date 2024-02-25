//Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas,
//el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes y el total que recibirá en el mes tomando en cuenta su sueldo base
//y comisiones.

//Definimos las variables

Double venta1, venta2, venta3;
double comision = 0.1;
double comisionv1;
double comisionv2;
double comisionv3;
double sbase = 100000;

//Ingresar las ventas

Console.WriteLine("Ingrese su primera venta: ");
venta1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su segunda venta: ");
venta2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su tercera venta: ");
venta3 = Convert.ToInt32(Console.ReadLine());

//Definimos las operaciones

comisionv1 = (venta1 *  comision);
comisionv2 = (venta2 * comision);
comisionv3 = (venta3 * comision);
Console.WriteLine("Su comisión por las ventas es: " + (comisionv1 + comisionv2 + comisionv3));
double comisiont = comisionv1 + comisionv2 + comisionv3;
Console.WriteLine();
Console.WriteLine("Su sueldo total es: " + (comisiont + sbase));