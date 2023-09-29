using System;

namespace TienditaDeDonMariano
{
    class Program
    {
        static void Main()
        {
            int maximoPersonas, contadorActual = 0;
            int vecesLleno = 0, vecesVacio = 0;

            Console.Write("Ingrese un número máximo de personas: ");
            maximoPersonas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (true)
            {
                double porcentajeAforo = ((double)contadorActual / maximoPersonas) * 100;

                Console.WriteLine($"| Asistentes actuales | {contadorActual}\n| Aforo               | {porcentajeAforo}%\n| Máximo              | {maximoPersonas} personas\n====================================\nPresione\n[ i ] si ingresa una persona\n[ s ] si sale una persona\n[ x ] para terminar");
                char opcion = Console.ReadKey().KeyChar;

                if (opcion == 'i' && contadorActual < maximoPersonas)
                {
                    contadorActual++;
                    if (contadorActual == maximoPersonas) vecesLleno++;
                }
                else if (opcion == 's' && contadorActual > 0)
                {
                    contadorActual--;
                    if (contadorActual == 0) vecesVacio++;
                }
                else if (opcion == 'x')
                {
                    Console.Clear();
                    Console.WriteLine($"=================================\nEl programa ha terminado\n====================================\nEstadísticas:\n----------------------------------\n{vecesLleno} veces se llenó el local\nEstuvo vacío {vecesVacio} veces");
                    return;
                }

                Console.Clear();
            }
        }
    }
}
