using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POngBaratox
{
    internal class Adotante
    {
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Telefone { get; set; }
        public Endereco Endereco { get; set; }


        public Adotante()
        {

        }

        public Adotante(string nome, String cPF, string sexo, DateTime dataNascimento, string telefone, Endereco endereco)
        {
            Nome = nome;
            CPF = cPF;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Endereco = endereco;
        }   

        public Adotante Coleta_Dados()
        {
            Console.Write("Informe o Nome: ");
            string n = Console.ReadLine();
            Console.Write("Informe o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Informe o Sexo: ");
            string sx = Console.ReadLine();
            Console.Write("Informe a Data de Nascimento: ");
            DateTime dn =  DateTime.Parse(Console.ReadLine());
            Console.Write("Informe um Telefone: ");
            string nm = Console.ReadLine();
            Endereco Endereco = new Endereco();
            Endereco end = Endereco.coleta_dados();

            return new Adotante(n, cpf, sx, dn, nm, end);
        }

    }
}
