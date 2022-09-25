using System;
using System.Data.SqlClient;


namespace POngBaratox
{
    internal class Program
    {
        static void Menu_inicial()
        {
            Console.WriteLine("\t\t\t\t>>>>>>>> Informe a Opção desejada <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Cadastrar Animal   <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Cadastrar Adotante <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   3 - Doar animal        <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   4 - Editar cadastro    <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair               <<<<<<<<<<<<");


        }
        static void Funcionamento(int menuinicial)
        {
            Banco conn = new Banco();
            SqlCommand cmd = new SqlCommand();
            Animal animal = new Animal();
            Adotante adotante = new Adotante();
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
                    Adotante people = adotante.Coleta_Dados();
                    cmd.CommandText = "INSERT INTO Adotante(Nome, CPF, Data_Nascimento, Telefone,CEP, Rua, Cidade, Bairro, Estado, Numero_casa) VALUES (@NomeP, @CPFp, @Data_Nascimento, @Telefone, @CEPp, @Rua, @Cidade, @Bairro, @Estado, @Numero_casa);";

                    SqlParameter nomeP = new SqlParameter("@NomeP", System.Data.SqlDbType.VarChar, 30);
                    SqlParameter CPFp = new SqlParameter("@CPFp", System.Data.SqlDbType.VarChar, 11);
                    SqlParameter Data_nascimento = new SqlParameter("@Data_Nascimento", System.Data.SqlDbType.VarChar, 10);
                    SqlParameter Telefone = new SqlParameter("@Telefone", System.Data.SqlDbType.VarChar, 16);
                    SqlParameter CEPp = new SqlParameter("@CEPp", System.Data.SqlDbType.VarChar, 15);
                    SqlParameter rua = new SqlParameter("@Rua", System.Data.SqlDbType.VarChar, 30);
                    SqlParameter Cidade = new SqlParameter("@Cidade", System.Data.SqlDbType.VarChar, 40);
                    SqlParameter Bairro = new SqlParameter("@Bairro", System.Data.SqlDbType.VarChar, 40);
                    SqlParameter Estado = new SqlParameter("@Estado", System.Data.SqlDbType.VarChar, 40);
                    SqlParameter Numero_casa = new SqlParameter("@Numero_casa", System.Data.SqlDbType.VarChar, 10);

                    nomeP.Value = people.Nome;
                    CPFp.Value = people.CPF;
                    Data_nascimento.Value = people.DataNascimento.ToShortDateString();
                    Telefone.Value = people.Telefone;
                    CEPp.Value = people.Endereco.CEP;
                    rua.Value = people.Endereco.Rua;
                    Cidade.Value = people.Endereco.Cidade;
                    Bairro.Value = people.Endereco.Bairro;
                    Estado.Value = people.Endereco.Estado;
                    Numero_casa.Value = people.Endereco.Numero_casa;

                    cmd.Parameters.Add(nomeP);
                    cmd.Parameters.Add(CPFp);
                    cmd.Parameters.Add(Data_nascimento);
                    cmd.Parameters.Add(Telefone);
                    cmd.Parameters.Add(CEPp);
                    cmd.Parameters.Add(rua);
                    cmd.Parameters.Add(Cidade);
                    cmd.Parameters.Add(Bairro);
                    cmd.Parameters.Add(Estado);
                    cmd.Parameters.Add(Numero_casa);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\t\t\t\t>>>>>>>> CADASTRO REALLIZADO COM SUCESSO! <<<<<<<<<<<<");
                    Console.ReadKey();

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
            Menu_inicial();
            int opc = int.Parse(Console.ReadLine());
            do
            {
                Funcionamento(opc);

            } while (opc != 0);
        }
    }
}
