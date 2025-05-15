using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Threading;

namespace formateo_de_datos_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colocar signo de pesos y separadores de mil: ");
            double precioVenta = 100767.89;

            // Formatear el precio de venta,la C es el formato de moneda
            Console.WriteLine($"El precio de venta es: {precioVenta:C}");
            Console.ReadKey();
            Console.WriteLine("---------------------------------------------");

            // Formatear porcentaje 
            Console.WriteLine("Formateo de porcentaje usando ToString");
            double porcentaje = 0.25;
            string porcentajeFormateado = porcentaje.ToString("P"); // P es el formato de porcentaje
            Console.WriteLine("El procentaje de 0.25 es: " + porcentajeFormateado);
            Console.ReadKey();

            Console.WriteLine("Mostrar dos decimales");
            double dosDecimales = 1234.5678;
            Console.WriteLine($"Eñ valor con dos decimales es: {dosDecimales:F2}"); // F2 es el formato de dos decimales
            Console.WriteLine("---------------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Mostrar diferentes formatos");
            int numero = 123456789;
            string numeroFormateado1 = numero.ToString("N"); // N es el formato de número
            string numeroFormateado2 = numero.ToString("N2"); // N2 es el formato de número con dos decimales
            string numeroFormateado3 = numero.ToString("D8"); // D8 es el formato de número entero con ceros a la izquierda
            string numeroFormateado4 = string.Format("{0:C}", numero); // X es el formato hexadecimal
            Console.WriteLine("Salida formato 1 " + numeroFormateado1);
            Console.WriteLine("Salida formato 2 " + numeroFormateado2);
            Console.WriteLine("Salida formato 3 " + numeroFormateado3);
            Console.WriteLine("Salida formato 4 " + numeroFormateado4);
            Console.WriteLine("---------------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Esto tardara 8 segundos en ejecutarse");
            Thread.Sleep(8000); // Pausa la ejecución durante 8 segundos
            Console.WriteLine("---------------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Formateo de cadenas");
            string nombre = "Juan";
            int edad = 30;
            string formatoCadena1 = string.Format("Mi nombre es: {0} y tengo {1} años.", nombre, edad);
            string formatoCadena2 = $"Mi nombre es {nombre} y tengo {edad} años."; 
            string formatoCadena3 = string.Format("El número es: {0,-10}", 42); 
            string formatoCadena4 = string.Format("El número es: {0,10}", 42); 
            Console.WriteLine(formatoCadena1); //
            Console.WriteLine(formatoCadena2); //
            Console.WriteLine(formatoCadena3); //
            Console.WriteLine(formatoCadena4); //
            Console.WriteLine("------------------------------------------------------ ");
            Console.WriteLine("Presiona una tecla para continuar..");
            Console.ReadKey();
            // Formateo de fecha y hora
            Console.WriteLine("Formateo de Fecha y hora:");
            DateTime fechaHoraActual = DateTime.Now;
            string formatoFecha1 = fechaHoraActual.ToString("d"); //
            string formatoFecha2 = fechaHoraActual.ToString("D"); //
            string formatoHora = fechaHoraActual.ToString("T"); //
            Console.WriteLine("Formato d fecha 1 " + formatoFecha1);
            Console.WriteLine("Formato d fecha 2 " + formatoFecha2);
            Console.WriteLine("Formato hora " + formatoHora); //
            Console.WriteLine("------------------------------------------------------ ");
            Console.WriteLine("Presiona una tecla para continuar..");
            Console.ReadKey();
            Console.WriteLine("Formateo de valores booleanos:");
            bool esVerdadero = true;
            string valorBooleano1 = esVerdadero.ToString(); //
            string valorBooleano2 = esVerdadero.ToString().ToUpper(); //
            string valorBooleano3 = esVerdadero ? "Sí" : "No"; //
            Console.WriteLine(valorBooleano1); //
            Console.WriteLine(valorBooleano2); //
            Console.WriteLine(valorBooleano3); //
            Console.WriteLine("------------------------------------------------------ ");
            Console.WriteLine("Presiona una tecla para continuar..");
            Console.ReadKey();

            //Cambiar el color del texto usando Console.ForegroundColor:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Color Azul");
            Console.ResetColor();//resetear Color
            Console.WriteLine("Texto normal");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Fondo amarillo");
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            //Limpiar la consola
            Console.WriteLine("Limpiando









        }
    }
}
