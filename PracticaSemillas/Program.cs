﻿using System;
using System.Collections.Generic;
using System.Linq;

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

            int n = 1200;
            double chiCritico = 16.92;
            //GeneradorLinealCongruente(x, a, c, m);


            //var lista = CalcularRn(GeneradorLinealCongruente(x, a, c, m), m);

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            //Series(lista.ToArray(),n);

            var listaNumerosSistema = CalcularRn(numerosRandom(6075), 6075);

            PruebaPoker(listaNumerosSistema, listaNumerosSistema.Count);
            //double valorChi = ChiCuadrado(listaNumerosSistema, n);

            //double valorChi = ChiCuadrado(lista, n);

            //ComprobarHipotesis(valorChi, chiCritico);

            //prueba kolmogorov
            //double valorCriticoK = 1.36f / (double)Math.Sqrt(n);
            //double valorKolmogorov = Kolmogorov(lista, n);
            //ComprobarHipotesis(valorKolmogorov, valorCriticoK);

            // GeneradorEstandarMinimo(123456789, (int)Math.Pow(7,5), 0, Math.Pow(2,31)-1);
            //GeneradorEstandarMinimo(5, 12, 5, 21);

            //double numero = 0.55787;
            //Console.WriteLine("Posicion {0} de {1}", EncontrarPosicionNumero(numero),numero);

            //PruebaPoker(lista, lista.Count);
            //EncontrarPosicionNumero(numero);

            double[] datos = new double[] { 0.41, 0.68, 0.89, 0.94, 0.74, 0.91, 0.55, 0.62, 0.36, 0.27,
                                            0.19, 0.72, 0.75, 0.08, 0.54, 0.02, 0.01, 0.36, 0.16, 0.28,
                                            0.18, 0.01, 0.95, 0.69, 0.18, 0.47, 0.23,0.32,  0.82, 0.53,
                                            0.31, 0.42, 0.73, 0.04, 0.83, 0.45, 0.13, 0.57, 0.63, 0.29};

            double[] datos2 = new double[] { 0.08, 0.09, 0.23, 0.29, 0.42, 0.55, 0.58, 0.72, 0.89, 0.91,
                                                0.11, 0.16, 0.18, 0.31, 0.41, 0.53, 0.71, 0.73, 0.74, 0.84,
                                                0.01, 0.09, 0.30, 0.32, 0.45, 0.47, 0.69, 0.74, 0.91, 0.95,
                                                0.12, 0.13, 0.29, 0.36, 0.38, 0.54, 0.68, 0.86, 0.88, 0.91};



            double[] pruebita = new double[] {0.06141, 0.14411, 0.87648, 0.81792,
0.48999, 0.72484,
0.94107, 0.56766,
0.18590, 0.06060,
0.11223, 0.64794,
0.52953, 0.50502,
0.30444, 0.70688,
0.25357, 0.31555,
0.04127, 0.67347,
0.28103, 0.99367,
0.44598, 0.73997,
0.27813, 0.62182,
0.82578, 0.85923,
0.51483, 0.09099 };


            double[] pruebita2 = new double[] { 0.85881, 0.99700, 0.75289, 0.82813, 0.02818, 0.36065, 0.45649, 0.06451, 0.07582, 0.73994, 0.52480, 0.03333, 0.50410, 0.76568, 0.11767, 0.37587, 0.55763, 0.33089, 0.53339, 0.41700, 0.24577, 0.74797, 0.92023, 0.93143, 0.05520, 0.94996, 0.35838, 0.85376, 0.41727, 0.0896 };

            double[] pruebita3 = new double[] { 0.66667 , 0.59489 , 0.9282 , 0.07266 , 0.97918 ,
0.54217 , 0.61723 , 0.27948 , 0.30443 , 0.17038 ,
0.38956 , 0.95088 , 0.42866 , 0.26805 , 0.26174 ,
0.78313 , 0.68031 ,0.36981 , 0.21009 , 0.98637 ,
0.13655 , 0.18903 , 0.95187 , 0.96697 , 0.56389 ,
0.70007 , 0.87999 , 0.87197 , 0.80151 , 0.60354 ,
0.02252 , 0.92777 , 0.37024 , 0.70198 , 0.29505 ,
0.57736 , 0.19596, 0.03450 , 0.39305 , 0.44865 ,
0.21755 , 0.22514 , 0.90194 , 0.46074 , 0.24702 ,
0.41436 , 0.88515 , 0.18487 , 0.59160 , 0.13075  };

            double[] pruebita4 = new double[] { 0.06141, 0.72484, 0.94107, 0.56766, 0.14411, 0.87648,
0.81792, 0.48999, 0.18590 ,0.06060, 0.11223 ,0.64794,
0.52953, 0.50502, 0.30444, 0.70688, 0.25357, 0.31555,
0.04127, 0.67347, 0.28103, 0.99367, 0.44598, 0.73997,
0.27813, 0.62182 ,0.82578 ,0.85623, 0.51483, 0.09099 };
            //var lista = CalcularRn(pruebita.ToList(), 7);

            //PruebaPoker(pruebita2.ToList(), pruebita2.Length);
            //PruebaPoker(lista, 6000);
            //VerificarCorridas(datos2);
            double[] tresDecimales = new double[] { 0.959, 0.713, 0.178, 0.427, 0.299, 0.153, 0.087, 0.615, 0.188, 0.972, 0.239, 0.425, 0.372, 0.015, 0.316, 0.532, 0.216, 0.466, 0.808, 0.444, 0.084, 0.577, 0.166, 0.182, 0.904, 0.296, 0.854, 0.317, 0.051, 0.229, 0.299, 0.199, 0.185, 0.222, 0.954, 0.582, 0.283, 0.324, 0.913, 0.158 };

            TresDecimales(tresDecimales);


            
        }

        public static List<int> numerosRandom(int n)
        {
            List<int> misNumero = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                misNumero.Add(rnd.Next(0, 6075));
            }

            return misNumero;
        }

        public static void Series(double[] datos, int limite)
        {

            double[] rnLimitado = new double[limite];

            for (int j = 0; j < limite; j++)
            {
                rnLimitado[j] = datos[j];
            }

            double[,] tabla = new double[10, 10];
            double[,] tablaChi2D = new double[10, 10];

            for (int i = 0; i < rnLimitado.Length; i += 2)
            {
                //Console.WriteLine("{4} valor x,y=  {0} , {1} para {2} y {3} se le agrega 1",(int)Math.Floor(rnLimitado[i] * 10), (int)Math.Floor(rnLimitado[i + 1] * 10),rnLimitado[i],rnLimitado[i+1],i);
                int x = (int)Math.Floor(rnLimitado[i] * 10);
                int y = (int)Math.Floor(rnLimitado[i + 1] * 10);

                tabla[x, y] += 1;
            }


            Console.WriteLine();

            Imprimir(tabla);

            Console.WriteLine("tabla chi calculada");

            Imprimir(CalcularTabla2Dchi(tabla, limite));
        }
        public static double[,] CalcularTabla2Dchi(double[,] tabla2D, int numeroDatos)
        {
            int rowLength = tabla2D.GetLength(0);
            int colLength = tabla2D.GetLength(1);

            double[,] tablaChi = new double[10, 10];

            //FE numero parejas / cantidad de celdas
            double FE = (numeroDatos / 2) / 100.0;

            Console.WriteLine("FE: {0}", FE);
            double valorChi2D = 0;
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    tablaChi[i, j] = Math.Round(((double)Math.Pow((FE - tabla2D[i, j]), 2) / FE), 2);
                    valorChi2D += tablaChi[i, j];
                }

            }

            //grados libertad 100-1 = 99 como en la tabla no aparece 99 se hizo interpolacion compleja
            double gradosLibertad = 123.22241;

            ComprobarHipotesis(valorChi2D, gradosLibertad, true);
            return tablaChi;
        }
        public static void Imprimir(double[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("\t{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

        }

        public static double Kolmogorov(List<double> rnCalculado, int n)
        {
            double[] rnLimitado = new double[n];


            for (int i = 0; i < n; i++)
            {
                rnLimitado[i] = rnCalculado[i];
            }

            int[] FO = CalcularFO(rnLimitado);
            int[] FOA = CalcularFOA(FO);
            double[] POA = CalcularPOA(FOA, n);
            double[] PEA = CalcularPEA(10);//numero de clases 10
            List<double> tablaDM = CalcularPeaPoa(PEA, POA);

            double maxValue = tablaDM.Max();

            return maxValue;
        }

        public static List<double> CalcularPeaPoa(double[] PEA, double[] POA)
        {
            List<double> valoresCalculados = new List<double>();
            for (int i = 0; i < POA.Length; i++)
            {
                valoresCalculados.Add(Math.Abs(PEA[i] - POA[i]));
                //Console.WriteLine(valoresCalculados[i]);
            }

            return valoresCalculados;
        }

        public static double[] CalcularPOA(int[] FOA, int n)
        {
            double[] POA = new double[10];


            for (int i = 0; i < FOA.Length; i++)
            {
                POA[i] = FOA[i] / (double)n;
                // Console.WriteLine(POA[i]);
            }

            return POA;
        }

        public static void PruebaPoker(List<double> numerosRn, int n)
        {
            CincoDecimales(numerosRn, n);

        }

        public static void CincoDecimales(List<double> numerosRn, int n)
        {
            List<double> rnCortados = new List<double>();

            //7 combinaciones para 5 digitos
            int[] FO = new int[7];
            double[] datos = new double[] { 0.3024, 0.504, 0.072, 0.0045, 0.0001, 0.009, 0.1080 };
            double[] FE = new double[7];

            for (int k = 0; k < datos.Length; k++)
            {
                FE[k] = datos[k] * n;
            }


            for (int i = 0; i < n; i++)
            {
                rnCortados.Add(numerosRn[i]);


            }

            for (int j = 0; j < rnCortados.Count; j++)
            {
                //Console.WriteLine(rnCortados[j]);

                FO[EncontrarPosicionNumero(rnCortados[j])] += 1;
            }

            Console.WriteLine("FO");

            CalcularFEFO(FO, FE);


            Console.WriteLine("nTodos diferentes:{0} \nun par {1} \nTercia: {2} \nPoker: {3} \nQuintilla: {4} \nFull: {5} \nDos pares: {6}", FO[0], FO[1], FO[2], FO[3], FO[4], FO[5], FO[6]);

        }
        public static void CalcularFEFO(int[] FO, double[] FE)
        {
            double valorCritico = 12.5916;
            double[] resultado = new double[7];

            for (int i = 0; i < FO.Length; i++)
            {
                //(Math.Pow((FE[i]-FO[i]),2)) / (FE[i]);
                resultado[i] = (Math.Pow((FE[i] - FO[i]), 2)) / (FE[i]);
            }

            double xCalculado = 0;

            foreach (var item in resultado)
            {
                //Console.WriteLine("------"+item);
                xCalculado += item;
            }
            if (xCalculado <= valorCritico)
            {
                Console.WriteLine("Se acepta que los datos son estadisticamente independientes entre sí");
            }
            else
            {
                Console.WriteLine("NO se acepta que los datos son estadisticamente independientes entre sí");
            }

            Console.WriteLine("Xcalculado {0}", xCalculado);
        }

        public static int EncontrarPosicionNumero(double numero)
        {
            List<int> numeroOrdenado = new List<int>();
            int k = 5;

            // numero = numero * 100000;

            string numS = Convert.ToString(Math.Round(numero, 5));

            while (numS.Length < 7)
            {
                numS += "0";
            }
            try
            {
                numS = numS.Remove(0, 2);
            }
            catch (Exception)
            {

                throw;
            }
            //foreach (var item in numS)
            //{
            //    Console.WriteLine("-----"+item);
            //}

            string s = String.Concat(numS.OrderBy(c => c));

            /* s= s.Remove(0, 2)*/
            ;

            //for (int i = 1; i <= k; i++)
            //{ 
            //    numeroOrdenado.Add((int)(numero * (Math.Pow(10, i))) % 10);
            //   // Console.WriteLine(numeroOrdenado[i - 1]);
            //}

            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();


            //numeroOrdenado = Int32.Parse(s);
            foreach (var item in s)
            {
                numeroOrdenado.Add(Int32.Parse(item.ToString()));
            }
            //foreach (var item in numeroOrdenado)
            //{
            //    Console.WriteLine("-"+item);
            //}

            List<int> diferenciador = new List<int>();



            var q = numeroOrdenado.GroupBy(x => x)
             .Select(g => new { Value = g.Key, Count = g.Count() })
             .OrderByDescending(x => x.Count);



            int multiplicador = 1;
            foreach (var item in q)
            {
                diferenciador.Add(item.Count);
                multiplicador *= item.Count;
            }

            if (multiplicador == 4 && diferenciador.Count == 3)
            {
                //Console.WriteLine("Posicion 6 de {1}", numero);
                return 6;
            }
            else
            {
                //Console.WriteLine("Posicion {0} de {1}", (multiplicador - 1), numero);
                return multiplicador - 1;
            }


        }

        public static void TresDecimales(double[] numero)
        {

            int[] FO = new int[3];
            for (int i = 0; i < numero.Length; i++)
            {
                int a = (int)Math.Floor((numero[i] * 10) % 10);
                int b = (int)Math.Floor((numero[i] * 100) % 10);
                int c = (int)Math.Floor((numero[i] * 1000) % 10);

                if (a == b && b == c)
                {
                    FO[0] += 1;

                }
                else if (a == b || b == c || c == a)
                {
                    FO[1] += 1;
                }
                else
                {
                    FO[2] += 1;
                }
            }
            Console.WriteLine("Iguales {0}, \n2 iguales una diferente {1} \ndiferentes {2}", FO[0], FO[1], FO[2]);


        }

        public static double[] CalcularPEA(int numeroClases)
        {
            double valorInicial = 1.0 / numeroClases;
            double acumulado = 0f;
            double[] PEA = new double[numeroClases];

            for (int i = 0; i < numeroClases; i++)
            {
                acumulado += valorInicial;
                PEA[i] = Math.Round(acumulado, 3);
                //Console.WriteLine(PEA[i]);
            }
            return PEA;
        }
        public static int[] CalcularFOA(int[] FO)
        {
            int[] FOA = new int[10];
            int acumulado = 0;

            for (int i = 0; i < FO.Length; i++)
            {
                acumulado += FO[i];
                FOA[i] = acumulado;
            }

            return FOA;
        }

        public static double VerificarCorridas(double[] datos)
        {
            double puntosCriticos = 1.96;
            int counter = 0;
            //Console.WriteLine(datos.Length);
            List<char> lista = new List<char>();
            Console.Write("*");
            lista.Add('*');


            for (int i = 1; i < datos.Length; i++)
            {
                if ((datos[i - 1] < datos[i]))
                {
                    Console.Write("+");
                    lista.Add('+');
                    //counter++;
                }
                else //if((datos[i - 1] > datos[i]))
                {
                    lista.Add('-');
                    Console.Write("-");
                    // counter++;                   
                }

            }
            for (int j = 1; j < lista.Count; j++)
            {
                if (!(lista[j - 1] == lista[j]))
                {
                    counter++;
                }

            }

            double mediaU = ((2 * (datos.Length)) - 1) / 3.0;
            double varianzaOCuadrado = ((16 * (datos.Length)) - 29) / 90.0;

            double z = (counter - mediaU) / (Math.Sqrt(varianzaOCuadrado));


            Console.WriteLine("valor de z {0}", z);

            if (z <= puntosCriticos && z >= -puntosCriticos)
            {
                Console.WriteLine("Se acepta la hipotesis y los datos son independientes");
            }
            else
            {
                Console.WriteLine("NO se acepta la hipotesis y los datos NO son independientes");
            }

            return z;
        }

        //n es la muestra que vamos a generar
        public static double ChiCuadrado(List<double> rnCalculado, int n)
        {
            double[] rnLimitado = new double[n];
            //numero de clases 10

            for (int i = 0; i < n; i++)
            {
                rnLimitado[i] = rnCalculado[i];
            }

            int clases = 10;
            //int[] FO = new int[clases];
            int[] FO = CalcularFO(rnLimitado);
            int[] FE = new int[clases];
            double[] chiCalculado = new double[clases];

            //foreach (var xn in rnLimitado)
            //{
            //    FO[(int)(Math.Floor(xn * 10))] += 1;
            //}

            for (int i = 0; i < clases; i++)
            {
                FE[i] = n / clases;
                chiCalculado[i] = ((double)Math.Pow((FE[i] - FO[i]), 2) / FE[i]);
            }
            double chiValor = 0f;
            foreach (var item in chiCalculado)
            {
                //Console.WriteLine("rango {0}",item );
                chiValor += item;
            }

            return chiValor;
        }

        public static int[] CalcularFO(double[] rnLimitado, int clases = 10)
        {
            int[] FO = new int[clases];
            foreach (var xn in rnLimitado)
            {
                FO[(int)(Math.Floor(xn * 10))] += 1;
            }

            return FO;
        }

        public static void ComprobarHipotesis(double DMCalculado, double DMcritico, bool independecia = false)
        {
            if (DMCalculado <= DMcritico && independecia == false)
            {
                Console.WriteLine("Se acepta la hipotesis ya que {0} <= {1} \n El generador es bueno en cuanto a uniformidad.", DMCalculado, DMcritico);
            }
            else if (DMCalculado <= DMcritico && independecia == true)
            {
                Console.WriteLine("Se acepta la hipotesis ya que {0} <= {1} \n El generador es bueno en cuanto a Independecia.", DMCalculado, DMcritico);
            }
            else
            {
                Console.WriteLine("No aprueba la hipotesis {0} <= {1} \n", DMCalculado, DMcritico);
            }
        }
        public static List<double> CalcularRn(List<int> numerosAleatorios, int m)
        {
            List<double> rn = new List<double>();

            //Console.WriteLine(numerosAleatorios.Count);

            foreach (var xn in numerosAleatorios)
            {
                // Console.WriteLine(xn);
                rn.Add(Math.Round(xn / (double)m, 5));

            }

            return rn;
        }
        public static List<int> GeneradorLinealCongruente(int x, int a, int c, int m)
        {
            List<int> numerosAleatorios = new List<int>();
            // Console.WriteLine("Generando números mediante el metodo lineal congruente...");

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

            } while (x != valorParada);
            //Console.WriteLine("Perido Total {0}:", periodo);
            return numerosAleatorios;
        }

        public static void GeneradorEstandarMinimo(int x, int a, int c, double m)
        {
            double valorParada = x;
            int periodo = 0;

            double q = Math.Floor(m / a);
            double r = m % a;
            double multi = (a * q) + r;
            Console.WriteLine("multi{0}", multi);

            Console.WriteLine("m Máximo = a*q+r " + multi);

            do
            {
                Console.WriteLine("X{0} = {1}", periodo, valorParada);
                periodo++;

                double operacion = a * (valorParada % q) - r * (Math.Floor(valorParada / q));
                //Console.WriteLine(operacion);

                valorParada = operacion >= 0 ? operacion : (operacion + m);

                if (valorParada < 0) { break; };

            } while (x != valorParada);

        }



    }
}
