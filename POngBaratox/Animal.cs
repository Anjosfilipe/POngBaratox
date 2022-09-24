using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POngBaratox
{
    internal class Animal
    {
        public string Familia { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }

        public Animal()
        {

        }
        public Animal(string familia, string raca, string sexo, string nome)
        {
            this.Familia = familia;
            this.Raca = raca;
            this.Sexo = sexo;
            this.Nome = nome;
        }
        public Animal Coleta_Dados()
        {
            Console.Write("Infome a Familia do Animal: ");
            string f = Console.ReadLine();
            Console.Write("Informe a Raça do Animal: ");
            string ra = Console.ReadLine();
            Console.Write("Informe o Sexo do Animal: ");
            string sx = Console.ReadLine();
            Console.Write("Informe o Nome do Animal: ");
            string n = Console.ReadLine();

            return new Animal(f, ra, sx, n);
        }
    }
}
