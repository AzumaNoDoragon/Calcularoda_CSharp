using System.Reflection.Emit;
using Calcularoda_CSharp.Models;

int opc;
Calculadora calc = new Calculadora();

opc = calc.Menu();

do
{
    switch (opc)
    {
        case 1:
            calc.Somar();
            break;
        case 2:
            calc.Subtrair();
            break;
        case 3:
            calc.Multiplicar();
            break;
        case 4:
            calc.Dividir();
            break;
        case 5:
            calc.Potencia();
            break;
        case 6:
            calc.Raiz();
            break;
        case 7:
            calc.X = 0;
            calc.Seno();
            break;
        case 8:
            calc.X = 0;
            calc.Cosseno();
            break;
        case 9:
            calc.X = 0;
            calc.Tangente();
            break;
        case 10:
            calc.X = 0;
            calc.Seno();
            calc.Cosseno();
            calc.Tangente();
            break;
        default:
            if (opc != 0)
            {
                Console.WriteLine("Valor invalido.");
            }
            break;
    }
} while (opc != 0);