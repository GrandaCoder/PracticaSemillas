using System;
using System.Collections.Generic;

namespace PracticaSemillas
{
    class Program
    {
        static void Main(string[] args)
        {
            // valores adecuados como ejemplo pequeño
            //GeneradorLinealCongruente(5, 5, 13, 7);

            int m = 6075;
            int x = 5;
            int a = 106;
            int c = 1283;

            int n = 1000;
            float chiCritico = 16.92f;
            //GeneradorLinealCongruente(x, a, c, m);

            
            var lista =CalcularRn(GeneradorLinealCongruente(x, a, c, m),m);

            float valorChi = ChiCuadrado(lista,n);

            ComprobarHipotesis(valorChi,chiCritico);

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}
            // Valores inadecuados
            //GeneradorEstandarMinimo(5, 12, 5, 21);
        }

        //n es la muestra que vamos a generar
        public static float ChiCuadrado(List<float> rnCalculado, int n)
        {
            float[] rnLimitado = new float[n];
            //numero de clases 10

            for (int i = 0; i < n; i++)
            {
                rnLimitado[i] = rnCalculado[i];
            }

            int clases = 10;
            //int[] FO = new int[clases];
            int[] FO = CalcularFO(rnLimitado);
            int[] FE = new int[clases];
            float[] chiCalculado = new float[clases];

            //foreach (var xn in rnLimitado)
            //{
            //    FO[(int)(Math.Floor(xn * 10))] += 1;
            //}

            for (int i = 0; i < clases; i++)
            {
                FE[i] = n / clases;
                chiCalculado[i] = ((float)Math.Pow((FE[i] - FO[i]), 2) / FE[i]);
            }
            float chiValor= 0f;
            foreach (var item in chiCalculado)
            {
                //Console.WriteLine("rango {0}",item );
                chiValor += item;
            }

            return chiValor;
        }

        public static int[] CalcularFO(float[] rnLimitado, int clases=10)
        {
            int[] FO = new int[clases];
            foreach (var xn in rnLimitado)
            {
                FO[(int)(Math.Floor(xn * 10))] += 1;
            }

            return FO;
        }

        public static void ComprobarHipotesis(float DMCalculado,float DMcritico)
        {
            if (DMCalculado <= DMcritico)
            {
                Console.WriteLine("Se acepta la hipotesis ya que {0} <= {1} \n El generador es bueno en cuanto a uniformidad.",DMCalculado,DMcritico);
            }
            else
            {
                Console.WriteLine("No aprueba la hipotesis {0} <= {1} \n El generador NO es bueno en cuanto a uniformidad", DMCalculado, DMcritico);
            }
        }
        public static List<float> CalcularRn(List<int> numerosAleatorios, int m)
        {
            List<float> rn = new List<float>();

            //Console.WriteLine(numerosAleatorios.Count);

            foreach (var xn in numerosAleatorios)
            {
               // Console.WriteLine(xn);
                rn.Add(xn / (float)m);

            }

            return rn;
        }
        public static List<int> GeneradorLinealCongruente(int x, int a, int c,int m)
        {
            List<int> numerosAleatorios = new List<int>();
            Console.WriteLine("Generando números mediante el metodo lineal congruente...");

            //creamos una variable auxiliar que nos guarda el valor inicial de x0 para despues irlo iterando
            int valorParada = x;
            int periodo = 0;
            do
            {
                //mostramos en pantalla los valores 
              
                periodo++;
                //aplicamo la formula de generador lineal congruente
                valorParada = (a * valorParada + c) % m;

                numerosAleatorios.Add(valorParada);
                // el valor de parada esta definida hasta que no se repita el valor x0 y el xn
                //cuando sean iguales quiere decir que termino el perido

                //Console.WriteLine("X{0} = {1}", periodo, valorParada);

            } while (x!=valorParada);
            //Console.WriteLine("Perido Total {0}:", periodo);
            return numerosAleatorios;
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
