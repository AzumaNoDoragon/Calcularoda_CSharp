using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Calcularoda_CSharp.Models
{
    public class Calculadora
    {
        public double X { get; set; }
        public double Y { get; set; }

        public int Menu()
        {
            Console.WriteLine("Escolha uma das opções");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Raiz quadrada");
            Console.WriteLine("7 - Seno");
            Console.WriteLine("8 - Cosseno");
            Console.WriteLine("9 - Tangente");
            Console.WriteLine("10 - Todas as razões trigonométricas");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Qual operação deseja fazer: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        public void LerXeY()
        {
            Console.WriteLine("Digite o 1º valor: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor: ");
            Y = Convert.ToDouble(Console.ReadLine());
        }

        public void LerX()
        {
            Console.WriteLine("Digite o valor: ");
            X = Convert.ToDouble(Console.ReadLine());
        }

        public void Somar()
        {
            LerXeY();
            Console.WriteLine($"{X} + {Y} = {X + Y}");
        }

        public void Subtrair()
        {
            LerXeY();
            Console.WriteLine($"{X} - {Y} = {X - Y}");
        }

        public void Dividir()
        {
            LerXeY();
            Console.WriteLine($"{X} / {Y} = {X / Y}");
        }

        public void Multiplicar()
        {
            LerXeY();
            Console.WriteLine($"{X} x {Y} = {X * Y}");
        }
        
        public void Potencia()
        {
            LerXeY();
            Console.WriteLine($"{X} ^ {Y} = {Math.Pow(X, Y)}");
        }

        public void Raiz()
        {
            LerX();
            double raiz = Math.Sqrt(X);
            Console.WriteLine($"Raiz quadrada de {X} = {raiz}");
        }
    }
}