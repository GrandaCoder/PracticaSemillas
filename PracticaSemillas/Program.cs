using System;
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
            float chiCritico = 16.92f;
            //GeneradorLinealCongruente(x, a, c, m);


            //var lista = CalcularRn(GeneradorLinealCongruente(x, a, c, m), m);

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(Math.Round(item,5));
            //}

            //Series(lista.ToArray(),n);



            //float valorChi = ChiCuadrado(lista, n);

            //ComprobarHipotesis(valorChi,chiCritico);

            //prueba kolmogorov
            //float valorCriticoK =  1.36f / (float)Math.Sqrt(n);
            //float valorKolmogorov =Kolmogorov(lista,n);
            //ComprobarHipotesis(valorKolmogorov, valorCriticoK);

            //GeneradorEstandarMinimo(5, 12, 5, 21);

            double numero = 0.55787;
            //Console.WriteLine("Posicion {0} de {1}", EncontrarPosicionNumero(numero),numero);

            EncontrarPosicionNumero(numero);

            double[] datos = new double[] { 0.41, 0.68, 0.89, 0.94, 0.74, 0.91, 0.55, 0.62, 0.36, 0.27,
                                            0.19, 0.72, 0.75, 0.08, 0.54, 0.02, 0.01, 0.36, 0.16, 0.28,
                                            0.18, 0.01, 0.95, 0.69, 0.18, 0.47, 0.23,0.32,  0.82, 0.53,
                                            0.31, 0.42, 0.73, 0.04, 0.83, 0.45, 0.13, 0.57, 0.63, 0.29};

            double[] datos2 = new double[] { 0.08, 0.09, 0.23, 0.29, 0.42, 0.55, 0.58, 0.72, 0.89, 0.91,
                                                0.11, 0.16, 0.18, 0.31, 0.41, 0.53, 0.71, 0.73, 0.74, 0.84,
                                                0.01, 0.09, 0.30, 0.32, 0.45, 0.47, 0.69, 0.74, 0.91, 0.95,
                                                0.12, 0.13, 0.29, 0.36, 0.38, 0.54, 0.68, 0.86, 0.88, 0.91};

            //VerificarCorridas(datos2);

        }

        public static void Series(float[] datos,int limite)
        {

            float[] rnLimitado = new float[limite];

            for (int j = 0; j < limite; j++)
            {
                rnLimitado[j] = datos[j];
            }

            double[,] tabla = new double[10,10];
            double[,] tablaChi2D = new double[10, 10];

            for (int i = 0; i < rnLimitado.Length; i +=2)
            {
                //Console.WriteLine("{4} valor x,y=  {0} , {1} para {2} y {3} se le agrega 1",(int)Math.Floor(rnLimitado[i] * 10), (int)Math.Floor(rnLimitado[i + 1] * 10),rnLimitado[i],rnLimitado[i+1],i);
                int x = (int)Math.Floor(rnLimitado[i] * 10);
                int y = (int)Math.Floor(rnLimitado[i+1] * 10);

                tabla[x,y] += 1; 
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
            double FE = (numeroDatos/2) / 100.0;

            Console.WriteLine("FE: {0}",FE);
            double valorChi2D = 0;
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    tablaChi[i,j] = Math.Round(((float)Math.Pow((FE - tabla2D[i, j]), 2) / FE),2);
                    valorChi2D += tablaChi[i, j];
                }
           
            }

            //grados libertad 100-1 = 99 como en la tabla no aparece 99 se hizo interpolacion compleja
            double gradosLibertad = 123.22241;

            ComprobarHipotesis((float)valorChi2D, (float)gradosLibertad,true);
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

        public static float Kolmogorov(List<float> rnCalculado, int n)
        {
            float[] rnLimitado = new float[n];
           

            for (int i = 0; i < n; i++)
            {
                rnLimitado[i] = rnCalculado[i];
            }

            int[] FO = CalcularFO(rnLimitado);
            int[] FOA = CalcularFOA(FO);
            float[] POA = CalcularPOA(FOA, n);
            float[] PEA = CalcularPEA(10);//numero de clases 10
            List<float> tablaDM = CalcularPeaPoa(PEA, POA);

            float maxValue = tablaDM.Max();

            return maxValue;
        }

        public static List<float> CalcularPeaPoa( float[] PEA, float[] POA)
        {
            List<float> valoresCalculados = new List<float>();
            for (int i = 0; i < POA.Length; i++)
            {
                valoresCalculados.Add(Math.Abs(PEA[i] - POA[i]));
                //Console.WriteLine(valoresCalculados[i]);
            }

            return valoresCalculados;
        }

        public static float[] CalcularPOA(int[] FOA,int n)
        {
            float[] POA = new float[10];

            
            for (int i = 0; i < FOA.Length; i++)
            {
                POA[i] = FOA[i] / (float)n;
               // Console.WriteLine(POA[i]);
            }
           
            return POA;
        }

        public static void PruebaPoker()
        {


        }

        public static void CincoDecimales(List<float> numerosRn, int n)
        {
            List<float> rnCortados = new List<float>();
            int[] FO = new int[5];


            for (int i = 0; i < n; i++)
            {
                rnCortados.Add(numerosRn[i]); 
            }

            for (int j = 0; j < rnCortados.Count; j++)
            {
                FO[EncontrarPosicionNumero(rnCortados[j])] += 1; 
            }

            Console.WriteLine("FO");
            foreach (var item in FO)
            {
                Console.WriteLine(item);
            }

        }

        public static int EncontrarPosicionNumero(double numero)
        {     
            List<int> numeroOrdenado = new List<int>();
            int k = 5;
            //numero = numero * 10000;

            //double[] valores = numero.ToString().Split("").Select(double.Parse).ToArray();

            for (int i = 1; i <= k; i++)
            {
                //numeroOrdenado.Add((int)valores[0]);

                numeroOrdenado.Add((int)(numero * (Math.Pow(10, i))) % 10);
                Console.WriteLine(numeroOrdenado[i - 1]);
            }

            //foreach (var item in numeroOrdenado)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();

            //numeroOrdenado.Sort();

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
            
            if(multiplicador == 4 && diferenciador.Count == 3)
            {
                return 6;
            }
            else
            {
                return multiplicador - 1;
            }

            
        }

        public static void MirarNumero(double numero)
        {
            int[] FO = new int[3];

            int a = (int)Math.Floor((numero*10)%10);
            int b = (int)Math.Floor((numero * 100) % 10);
            int c = (int)Math.Floor((numero * 1000) % 10);

            if (a == b && b == c)
            {
                FO[0] += 1;

            }else if (a == b || b == c || c == a)
            {
                FO[1] += 1;
            }
            else
            {
                FO[2] += 1;
            }

        }

        public static float[] CalcularPEA(int numeroClases)
        {
            double valorInicial = 1.0 / numeroClases;
            double acumulado = 0f;
            float[] PEA = new float[numeroClases];

            for (int i = 0; i < numeroClases; i++)
            {
                acumulado += valorInicial;
                PEA[i] = (float)Math.Round(acumulado,3);
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
                if((datos[i-1] < datos[i]))
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
                if(!(lista[j-1] == lista[j]))
                {
                    counter++;
                }
               
            }

            double mediaU = ((2 * (datos.Length)) - 1) / 3.0;
            double varianzaOCuadrado = ((16 * (datos.Length)) - 29)/ 90.0;

            double z = (counter - mediaU) / (Math.Sqrt(varianzaOCuadrado));

           
            Console.WriteLine("valor de z {0}", z);

            if(z <= puntosCriticos && z >= -puntosCriticos)
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

        public static void ComprobarHipotesis(float DMCalculado,float DMcritico,bool independecia=false)
        {
            if (DMCalculado <= DMcritico && independecia == false)
            {
                Console.WriteLine("Se acepta la hipotesis ya que {0} <= {1} \n El generador es bueno en cuanto a uniformidad.",DMCalculado,DMcritico);
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
