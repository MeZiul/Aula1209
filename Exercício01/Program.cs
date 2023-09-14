using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t===Conta Banco===\n\n");

            Conta Kaio = new Conta();

            Kaio.Numero = 1234;
            Kaio.Saldo  = 150000.00;
            Kaio.Limite = 50000.00;
        }
    }
}
