using System;

namespace PracticaSemillas
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneradorLinealCongruente(5, 5, 13, 7);
        }

        public static void GeneradorLinealCongruente(int x, int a, int c,int m)
        {
            Console.WriteLine("Generando números mediante el metodo lineal congruente...");

            //creamos una variable auxiliar que nos guarda el valor inicial de x0 para despues irlo iterando
            int valorParada = x;
            int periodo = 0;
            do
            {
                //mostramos en pantalla los valores 
                Console.WriteLine("X{0} = {1}",periodo,valorParada);
                periodo++;
                //aplicamo la formula de generador lineal congruente
                valorParada = (a * valorParada + c) % m;

                // el valor de parada esta definida hasta que no se repita el valor x0 y el xn
                //cuando sean iguales quiere decir que termino el perido
            } while (x!=valorParada);
            Console.WriteLine("Perido Total {0}:",periodo);
        }

    }
}
