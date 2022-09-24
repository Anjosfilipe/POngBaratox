using System;
using System.Data.SqlClient;


namespace POngBaratox
{
    internal class Program
    {
        static int Menu_inicial()
        {
            Console.WriteLine("\t\t\t\t>>>>>>>> Informe a Opção desejada <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Cadastrar Animal   <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Cadastrar Adotante <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   3 - Doar animal        <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   4 - Editar cadastro    <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair               <<<<<<<<<<<<");
            int opc = int.Parse(Console.ReadLine());
            return opc;
        }
        static void Funcionamento(int menuinicial)
        {
            Banco conn = new Banco();
            SqlCommand cmd = new SqlCommand();
            Animal animal = new Animal();
            cmd.Connection = conn.OpenConexao();
            
            switch (menuinicial)
            {
                case 1:
                    
                   Animal pet = animal.Coleta_Dados();
                    cmd.CommandText = "INSERT INTO Animal(Familia, Raca, Sexo, Nome) VALUES (@familia, @Raca, @Sexo, @Nome);";

                    SqlParameter familia = new SqlParameter("@familia", System.Data.SqlDbType.VarChar, 40);
                    SqlParameter raca = new SqlParameter("@raca", System.Data.SqlDbType.VarChar, 40);
                    SqlParameter sx = new SqlParameter("@sexo", System.Data.SqlDbType.Char, 1);
                    SqlParameter nome = new SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 30);

                    familia.Value = pet.Familia;
                    raca.Value = pet.Raca;
                    sx.Value = pet.Sexo;
                    nome.Value = pet.Nome;

                    cmd.Parameters.Add(familia);
                    cmd.Parameters.Add(raca);
                    cmd.Parameters.Add(sx);
                    cmd.Parameters.Add(nome);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\t\t\t\t>>>>>>>> CADASTRO REALLIZADO COM SUCESSO! <<<<<<<<<<<<");
                    Console.ReadKey();

                    break;
                case 2:
                    Console.WriteLine("Bora la neh");
                    break;
                case 4:
                    Console.WriteLine("Bora la neh");
                    break;
                case 5:
                    Console.WriteLine("Bora la neh");
                    break;
                case 0:
                    Console.Write(">>>>>>>> Tecle ENTER para encerrar o programa <<<<<<<<<<<<<<");
                    Console.ReadLine();
                    cmd.Connection = conn.CloseConexao();
                    break;

            }
        }
        static void Main(string[] args)
        {
            do
            {
                Funcionamento(Menu_inicial());

            } while (Menu_inicial() != 0);
        }
    }
}
