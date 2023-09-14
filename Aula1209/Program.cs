using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario Kaio = new Funcionario();

            Kaio.Nome = "Kaio Marks";
            Kaio.Salario = 10000.00;

            Console.WriteLine(Kaio.Nome);
            Console.WriteLine(Kaio.Salario);
        }
    }
}
