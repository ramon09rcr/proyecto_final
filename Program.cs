using System;

namespace proyectofinal
{
    class Program
    {   
        static void Main(string[] args)
        {  
            Console.WriteLine("Nombre: Ramon Fernando Cuevas Ruiz");
            Console.WriteLine("Matricula: 17-EIIN-1-091");
            Console.WriteLine();

            double vi_avion_kmh = 800;
            double vi_avion = (vi_avion_kmh * 1000) / 3600; // convertir de km/h a mts/seg
            double ac_avion = 20; // mts/seg2 
            double vi_proyectil = 0.0;
            double ac_proyectil = 10.0; //mts/seg2

            Console.Write("Por favor introduzca la distancia maxima de separacion: ");
            double distancia_maxima = double.Parse(Console.ReadLine());

            if (distancia_maxima < 0) {
                Console.WriteLine("La distancia maxima debe ser mayor que cero");
                Environment.Exit(1); //salir del programa
            }

            if (distancia_maxima > 100_000) {
                Console.WriteLine("La distancia maxima debe ser menor que 100,000"); //
                Environment.Exit(1); //salir del programa
            }

            double distancia_entre_avion_y_proyectil = 0;
            int tiempo = 1; // 

            while (distancia_entre_avion_y_proyectil < distancia_maxima) {
                //calcular distancia del avion al origen
                double distancia_avion_origen = vi_avion*tiempo + 0.5*ac_avion*tiempo*tiempo; 
                double distancia_proyectil_origen = vi_proyectil*tiempo + 0.5*ac_proyectil*tiempo*tiempo;

                // usar teorema de pitagora para calcular la distancia de separacion entre el proyectil y el avion c = sqrt(a^2+b^2)
                distancia_entre_avion_y_proyectil = Math.Sqrt(Math.Pow(distancia_avion_origen,2) + Math.Pow(distancia_proyectil_origen, 2));

                Console.WriteLine("Distancia entre el avion y el proyectil en el segundo {0} es {1} mts", tiempo, distancia_entre_avion_y_proyectil);
                tiempo = tiempo + 1;
            }
        }
    }
}
