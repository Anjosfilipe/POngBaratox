using System;
using System.Data.SqlClient;


namespace POngBaratox
{
    internal class Program
    {
        static void Menu_inicial()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>>>>>>>> Informe a Opção desejada <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Cadastrar Animal   <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Cadastrar Adotante <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   3 - Doar animal        <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   4 - Editar cadastro    <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair               <<<<<<<<<<<<");


        }
        static void Menu_editar()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>>>>>>>>   Informe a Opção desejada         <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Editar cadastro de Animal    <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Editar cadastro de Adotante  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair                         <<<<<<<<<<<<");

        }
        static void EditarAnimal()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>>>>>>>>   Informe a Opção desejada         <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Editar Familia               <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Editar Raça                  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   3 - Editar Sexo                  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   4 - Editar Nome                  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair                         <<<<<<<<<<<<");
        }
        static void EditarAdotante()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>>>>>>>>   Informe a Opção desejada         <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Editar Nome                  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Editar Data de Nascimeto     <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   3 - Editar Telefone              <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   4 - Editar CEP                   <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   5 - Editar Rua                   <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   6 - Editar Cidade                <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   7 - Editar Bairro                <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   8 - Editar Estado                <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   9 - Editar Numero da casa        <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair                         <<<<<<<<<<<<");
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
                    cmd.CommandText = "INSERT INTO Adotante( Nome, CPF, Data_Nascimento, Telefone,CEP, Rua, Cidade, Bairro, Estado, Numero_casa) VALUES (@NomeP, @CPFp, @Data_Nascimento, @Telefone, @CEPp, @Rua, @Cidade, @Bairro, @Estado, @Numero_casa);";

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
                case 3:

                    Console.Write("Informe o ID do Animal a ser doado: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Informe o CPF do Adotante: ");
                    string cpf = Console.ReadLine();

                    cmd.CommandText = "UPDATE Animal SET CPF = @CPFa WHERE ID_Chip = @ID_chip;";


                    SqlParameter ID_chip = new SqlParameter("@ID_chip", System.Data.SqlDbType.Int);
                    SqlParameter CPFa = new SqlParameter("@CPFa", System.Data.SqlDbType.VarChar, 11);

                    ID_chip.Value = id;
                    CPFa.Value = cpf;

                    cmd.Parameters.Add(CPFa);
                    cmd.Parameters.Add(ID_chip);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\t\t\t\t>>>>>>>> DOAÇÃO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                    Console.ReadKey();

                    break;
                case 4:

                    Menu_editar();
                    int opc = int.Parse((Console.ReadLine()));

                    switch (opc)
                    {
                        case 1:
                            EditarAnimal();
                            int opcA = int.Parse((Console.ReadLine()));

                            switch (opcA)
                            {
                                case 1:

                                    Console.Write("Informe o ID do Animal a ser doado: ");
                                    id = int.Parse(Console.ReadLine());
                                    Console.Write("Informe a Familia desejada: ");
                                    string ff = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Animal SET Familia = @familia WHERE ID_Chip = @ID_chip;";

                                    SqlParameter ID_chip1 = new SqlParameter("@ID_chip", System.Data.SqlDbType.Int);
                                    SqlParameter familiaa = new SqlParameter("@familia", System.Data.SqlDbType.VarChar, 40);

                                    ID_chip1.Value = id;
                                    familiaa.Value = ff;

                                    cmd.Parameters.Add(ff);
                                    cmd.Parameters.Add(ID_chip1);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 2:

                                    Console.Write("Informe o ID do Animal a ser doado: ");
                                    id = int.Parse(Console.ReadLine());
                                    Console.Write("Informe a Raça desejada: ");
                                    string rc = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Animal SET Raca = @raca WHERE ID_Chip = @ID_chip;";

                                    SqlParameter ID_chip2 = new SqlParameter("@ID_chip", System.Data.SqlDbType.Int);
                                    SqlParameter rc1 = new SqlParameter("@raca", System.Data.SqlDbType.VarChar, 40);

                                    ID_chip2.Value = id;
                                    rc1.Value = rc;

                                    cmd.Parameters.Add(rc);
                                    cmd.Parameters.Add(ID_chip2);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 3:

                                    Console.Write("Informe o ID do Animal a ser doado: ");
                                    id = int.Parse(Console.ReadLine());
                                    Console.Write("Informe o Sexo desejado: ");
                                    char sex = char.Parse(Console.ReadLine());

                                    cmd.CommandText = "UPDATE Animal SET Sexo = @sexo WHERE ID_Chip = @ID_chip;";

                                    SqlParameter ID_chip3 = new SqlParameter("@ID_chip", System.Data.SqlDbType.Int);
                                    SqlParameter sex1 = new SqlParameter("@sexo", System.Data.SqlDbType.Char, 1);

                                    ID_chip3.Value = id;
                                    sex1.Value = sex;

                                    cmd.Parameters.Add(sex1);
                                    cmd.Parameters.Add(ID_chip3);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 4:

                                    Console.Write("Informe o ID do Animal a ser doado: ");
                                    id = int.Parse(Console.ReadLine());
                                    Console.Write("Informe a Nome desejado: ");
                                    string name = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Animal SET Nome = @nome WHERE ID_Chip = @ID_chip;";

                                    SqlParameter ID_chip4 = new SqlParameter("@ID_chip", System.Data.SqlDbType.Int);
                                    SqlParameter name1 = new SqlParameter("@sexo", System.Data.SqlDbType.VarChar, 30);

                                    ID_chip4.Value = id;
                                    name1.Value = name;

                                    cmd.Parameters.Add(name1);
                                    cmd.Parameters.Add(ID_chip4);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;

                                case 0:
                                    Console.Write(">>>>>>>> Tecle ENTER para voltar ao programa <<<<<<<<<<<<<<");
                                    Console.ReadLine();
                                    break;

                            }
                            break;
                        case 2:
                            EditarAdotante();
                            int opcAD = int.Parse((Console.ReadLine()));

                            switch (opcAD)
                            {
                                case 1:
                                    Console.Write("Informe o CPF: ");
                                    string cpf1 = Console.ReadLine();
                                    Console.Write("Informe a Nome desejado: ");
                                    string name = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET Nome = @nome WHERE CPF = @cpf;";

                                    SqlParameter nome1 = new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 30);
                                    SqlParameter CPF1 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);

                                    CPF1.Value = cpf1;
                                    nome1.Value = name;

                                    cmd.Parameters.Add(nome1);
                                    cmd.Parameters.Add(CPF1);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();

                                    break;
                                case 2:
                                    Console.Write("Informe o CPF: ");
                                    string cpf2 = Console.ReadLine();
                                    Console.Write("Informe a Data de Nascimento desejada: ");
                                    string data = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET Data_Nascimento = @date WHERE CPF = @cpf;";

                                    SqlParameter CPF2 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);
                                    SqlParameter data1 = new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 10);

                                    CPF2.Value = cpf2;
                                    data1.Value = data;

                                    cmd.Parameters.Add(data1);
                                    cmd.Parameters.Add(CPF2);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Write("Informe o CPF: ");
                                    string cpf3 = Console.ReadLine();
                                    Console.Write("Informe o Numero desejado: ");
                                    string num1 = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET Telefone = @telefone WHERE CPF = @cpf;";

                                    SqlParameter CPF3 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);
                                    SqlParameter num = new SqlParameter("@telefone", System.Data.SqlDbType.VarChar, 10);

                                    CPF3.Value = cpf3;
                                    num.Value = num1;

                                    cmd.Parameters.Add(num);
                                    cmd.Parameters.Add(CPF3);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.Write("Informe o CPF: ");
                                    string cpf4 = Console.ReadLine();
                                    Console.Write("Informe o CEP desejado: ");
                                    string cep1 = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET CEP = @cep WHERE CPF = @cpf;";

                                    SqlParameter CPF4 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);
                                    SqlParameter CEP1 = new SqlParameter("@cep", System.Data.SqlDbType.VarChar, 15);

                                    CPF4.Value = cpf4;
                                    CEP1.Value = cep1;

                                    cmd.Parameters.Add(CEP1);
                                    cmd.Parameters.Add(CPF4);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.Write("Informe o CPF: ");
                                    string cpf5 = Console.ReadLine();
                                    Console.Write("Informe a Rua desejado: ");
                                    string rua1 = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET RUA = @rua WHERE CPF = @cpf;";

                                    SqlParameter CPF5 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);
                                    SqlParameter Rua1 = new SqlParameter("@rua", System.Data.SqlDbType.VarChar, 30);

                                    CPF5.Value = cpf5;
                                    Rua1.Value = rua1;

                                    cmd.Parameters.Add(Rua1);
                                    cmd.Parameters.Add(CPF5);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.Write("Informe o CPF: ");
                                    string cpf6 = Console.ReadLine();
                                    Console.Write("Informe a Cidade desejada: ");
                                    string cidade1 = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET Cidade = @cidade WHERE CPF = @cpf;";

                                    SqlParameter CPF6 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);
                                    SqlParameter Cidade1 = new SqlParameter("@cidade", System.Data.SqlDbType.VarChar, 40);

                                    CPF6.Value = cpf6;
                                    Cidade1.Value = cidade1;

                                    cmd.Parameters.Add(Cidade1);
                                    cmd.Parameters.Add(CPF6);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 7:
                                    Console.Write("Informe o CPF: ");
                                    string cpf7 = Console.ReadLine();
                                    Console.Write("Informe o Bairro desejada: ");
                                    string bairro1 = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET Bairro = @bairro WHERE CPF = @cpf;";

                                    SqlParameter CPF7 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);
                                    SqlParameter Bairro1 = new SqlParameter("@bairo", System.Data.SqlDbType.VarChar, 40);

                                    CPF7.Value = cpf7;
                                    Bairro1.Value = bairro1;

                                    cmd.Parameters.Add(Bairro1);
                                    cmd.Parameters.Add(CPF7);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 8:
                                    Console.Write("Informe o CPF: ");
                                    string cpf8 = Console.ReadLine();
                                    Console.Write("Informe o Estado desejado: ");
                                    string estado1 = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET Estado = @estado WHERE CPF = @cpf;";

                                    SqlParameter CPF8 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);
                                    SqlParameter Estado1 = new SqlParameter("@estado", System.Data.SqlDbType.VarChar, 30);

                                    CPF8.Value = cpf8;
                                    Estado1.Value = estado1;

                                    cmd.Parameters.Add(Estado1);
                                    cmd.Parameters.Add(CPF8);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 9:
                                    Console.Write("Informe o CPF: ");
                                    string cpf9 = Console.ReadLine();
                                    Console.Write("Informe o Numero da casa desejada: ");
                                    string casa1 = Console.ReadLine();

                                    cmd.CommandText = "UPDATE Adotante SET Numero_Casa = @casa WHERE CPF = @cpf;";

                                    SqlParameter CPF9 = new SqlParameter("@cpf", System.Data.SqlDbType.VarChar, 11);
                                    SqlParameter Casa1 = new SqlParameter("@casa", System.Data.SqlDbType.VarChar, 10);

                                    CPF9.Value = cpf9;
                                    Casa1.Value = casa1;

                                    cmd.Parameters.Add(Casa1);
                                    cmd.Parameters.Add(CPF9);


                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("\t\t\t\t>>>>>>>> ALTERAÇÂO REALIZADA COM SUCESSO! <<<<<<<<<<<<");
                                    Console.ReadKey();
                                    break;
                                case 0:
                                    Console.Write(">>>>>>>> Tecle ENTER para voltar ao programa <<<<<<<<<<<<<<");
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        case 0:
                            break;
                    }


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
            int opc;
            do
            {
                Menu_inicial();
                opc = int.Parse(Console.ReadLine());
                Funcionamento(opc);

            } while (opc != 0);
        }
    }
}
