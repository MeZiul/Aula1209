using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1209
{
    public class Funcionario
    {
        private string nome;
        private double salario;

        // Control + .
        //  public string Nome { get => nome; set => nome = value; }


        // "prop" + tab + tab
        public string Nome { get; set; }

        public double Salario { get; set; }


        //forma expandida
        /*
        public string Nome 
        { 
            get 
            {
                return nome; 
            }
            set
            {
                nome = value;
            }
        
        }
        */

        public string lerNome() //get
        {
            return nome;
        }
        public void gravarNome(string valor)
        {
            nome = valor;
        }

    }
}
