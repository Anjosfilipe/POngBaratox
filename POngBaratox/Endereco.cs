using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POngBaratox
{
    internal class Endereco
    {
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero_casa { get; set; } 
        
        public Endereco()
        {

        }

        public Endereco(string CEP, string estado, string cidade, string bairro, string rua, string numero_casa)
        {
            this.CEP = CEP;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Rua = rua;
            this.Numero_casa = numero_casa;
        }

        public Endereco coleta_dados()
        {
            Console.Write("Informe o CEP: ");
            string c = Console.ReadLine();
            Console.Write("Informe o Estado: ");
            string e = Console.ReadLine();
            Console.Write("Informe o Cidade: ");
            string cd = Console.ReadLine();
            Console.Write("Informe o Bairro: ");
            string b = Console.ReadLine();
            Console.Write("Informe o Logradouro: ");
            string l = Console.ReadLine();
            Console.Write("Informe o Numero da residencia: ");
            string n = Console.ReadLine();

            return new Endereco(c, e, cd, b, l, n);
        }


    }
}
