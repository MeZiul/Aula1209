using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t===Retangulo===\n\n");

            int opç = 0;
            switch(opç)
            {
                case 0: Console.WriteLine("Informe a Altura: ");
                    double altura1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Infore a Largura: ");
                    double largura1 = double.Parse(Console.ReadLine());

                    Retangulo ret1 = new Retangulo(altura1, largura1);

                    if (altura1 <= 0 || largura1 <= 0)
                    {
                        Console.WriteLine("Valores invalidos!!!");
                        goto case 0;
                    }
                    else
                    {
                        Console.WriteLine("valores informados:\nAltura = {0}\nLargura = {1}\nÁrea de {2}",altura1,largura1,ret1.Area);
                        Console.WriteLine("Deseja fazer outa operação?\n[0]Sim  [1] Não  ");
                        opç = int.Parse(Console.ReadLine());
                        if (opç == 0)
                            goto case 0;
                        else 
                            goto case 1;
                    }
                    break;
                case 1:
                    Console.WriteLine("Adeus!!!");
                    break;
            }
        }
    }
}
