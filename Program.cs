using System;

namespace desafiosAritmeticosIntermediarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Moedas();
            // Triangulo();
            Bhaskara();

            static void Moedas()
            {
                double valor;
                int inteiro, auxNotas, auxMoedas;

                Console.WriteLine("Digite o valor:");
                valor = Convert.ToDouble(Console.ReadLine());

                inteiro = (int)valor;
                valor *= 100;
                auxMoedas = (int)valor;


                Console.WriteLine("NOTAS:");
                Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro / 100);
                auxNotas = (inteiro % 100);
                //complete o código
                Console.WriteLine("{0} nota(s) de R$ 50.00", auxNotas / 50);
                auxNotas = (auxNotas % 50);
                Console.WriteLine("{0} nota(s) de R$ 20.00", auxNotas / 20);
                auxNotas = (auxNotas % 20);
                Console.WriteLine("{0} nota(s) de R$ 10.00", auxNotas / 10);
                auxNotas = (auxNotas % 10);
                Console.WriteLine("{0} nota(s) de R$ 5.00", auxNotas / 5);
                auxNotas = (auxNotas % 5);
                Console.WriteLine("{0} nota(s) de R$ 2.00", auxNotas / 2);
                auxNotas = (auxNotas % 2);

                Console.WriteLine("MOEDAS:");
                Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);
                auxMoedas %= 100;
                Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas / 50);
                auxMoedas %= 50;
                Console.WriteLine("{0} moeda(s) de R$ 0.25", auxMoedas / 25);
                auxMoedas %= 25;
                Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 10);
                auxMoedas %= 10;
                Console.WriteLine("{0} moeda(s) de R$ 0.05", auxMoedas / 5);
                auxMoedas %= 5;
                Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas / 1);
                //complete o codigo
            }

            static void Triangulo()
            {
                string[] s = Console.ReadLine().Split(' ');
                Array.Sort(s);
                Array.Reverse(s);
                double a = double.Parse(s[0]);
                double b = double.Parse(s[1]);
                double c = double.Parse(s[2]);

                // var a2 = Math.Max(a, Math.Max(b, c));
                // var c2 = -Math.Max(-a, Math.Max(-b,-c));
                // var b2 = (a + b + c) - (a2 + c2);


                Console.WriteLine("{0} > {1} > {2}", a, b, c);

                //continue a solucao
                if (a >= (b + c))
                    Console.WriteLine("NAO FORMA TRIANGULO");
                else if (a * a == (b * b + c * c))
                    Console.WriteLine("TRIANGULO RETANGULO");
                else if (a * a > (b * b + c * c))
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                else if (a * a < (b * b + c * c))
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                if (a == b && b == c)
                    Console.WriteLine("TRIANGULO EQUILATERO");
                if ((a == b && b != c || b == c && c != a))
                    Console.WriteLine("TRIANGULO ISOSCELES");

                Console.ReadLine();
            }

            static void Bhaskara()
            {

                double a, b, c, delta, r1, r2;
                string[] valor = Console.ReadLine().Split();

                a = Convert.ToDouble(valor[0]);
                b = Convert.ToDouble(valor[1]);
                c = Convert.ToDouble(valor[2]);

                delta = (Math.Pow(b, 2) - (4 * a * c));
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                if (! double.IsNaN(r1))
                {
                    Console.WriteLine("R1 = {0}", r1.ToString("N5"));
                    Console.WriteLine("R2 = {0}", r2.ToString("N5"));

                }
                else
                {
                    Console.WriteLine("Impossivel calcular");
                }

            }

        }
    }
}
