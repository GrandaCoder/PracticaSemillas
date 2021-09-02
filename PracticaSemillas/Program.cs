using System;

namespace PracticaSemillas
{
    class Program
    {
        static void Main(string[] args)
        {
            // valores adecuados como ejemplo pequeño
            //GeneradorLinealCongruente(5, 5, 13, 7);

            // Valores inadecuados
            //GeneradorEstandarMinimo(5, 12, 5, 21);
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

        public static void GeneradorEstandarMinimo(int x, int a, int c, double m)
        {
            double valorParada = x;
            int periodo = 0;

            double q = Math.Floor(m / a);
            double r = m % a;

            Console.WriteLine("m Máximo = a*q+r "+a*q+r);

            do
            {
                Console.WriteLine("X{0} = {1}", periodo, valorParada);
                periodo++;

                double operacion = a * (valorParada % q) - r*(Math.Floor(valorParada/q));
                //Console.WriteLine(operacion);

                valorParada = operacion >= 0 ? operacion : (operacion + m);

                if(valorParada < 0) { break; };

            } while (x != valorParada);

        }

        

    }
}
