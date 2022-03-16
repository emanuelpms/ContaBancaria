using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Validacoes
    {
        public static void ValidarOpcao()
        {

            const int _idadeAutorizada = 18;
            char resposta;
            int executar;
            bool sair = true;

            Clientes<Cliente> clientes = new Clientes<Cliente>();

            do
            {

                Console.WriteLine("Digite o que deseja fazer: " +
                                  "{0} - Cadastrar Cliente, " +
                                  "{1} - Imprimir Todos Clientes " +
                                  "{2} - Sair");
                executar = Convert.ToInt32(Console.ReadLine());

                switch (executar)
                {
                    case 0:
                        Console.WriteLine("Deseja criar uma conta? ");
                        resposta = Convert.ToChar(Console.ReadLine().ToLower());

                        if (resposta == 's')
                        {
                            Console.WriteLine("Digite seu nome: ");
                            string nome = Console.ReadLine();

                            Console.WriteLine("Digite seu cpf: ");
                            string cpf = Console.ReadLine();

                            Console.WriteLine("Digite sua data de nascimento: {digite no formato 00/00/0000} ");
                            DateTime dataNacimento = Convert.ToDateTime(Console.ReadLine());


                            if (Idade(dataNacimento) >= _idadeAutorizada)
                            {
                                Cliente cliente = new Cliente();

                                cliente.CriarCadastroCliente(nome, cpf, dataNacimento, Agencia(2254, "Nilson", 1445874));

                                clientes.Add(cliente);

                            }
                            else
                            {
                                Console.WriteLine($"Para criar uma conta, precisa ter no minimo {_idadeAutorizada} anos");

                            }

                        }
                        sair = true;
                        continue;

                    case 1:
                        Clientes(clientes);
                        sair = true;
                        continue;

                    case 2:
                        Console.WriteLine("Deseja realmente sair? ");
                        char desejaSair = Convert.ToChar(Console.ReadLine().ToLower());

                        if (desejaSair == 's')
                        {
                            sair = false;
                        }
                        else
                        {
                            sair = true;
                        }

                        break;

                    default:
                        Console.WriteLine("Opção invalida!!!!!");
                        break;
                }

            } while (sair);


        }


        static int Idade(DateTime dataNascimento)
        {
            var dataAtual = Convert.ToInt32(DateTime.Now.Year);

            var idade = dataAtual - dataNascimento.Year;

            return idade;
        }


        //Função para criar uma agencia
        static CriarAgencia Agencia(int agenc, string gerente, int telAgencia)
        {

            CriarAgencia agencia = new CriarAgencia(agenc, gerente, telAgencia);

            return agencia;
        }

        //Função para imprimir os clientes cadastrados
        static void Clientes(Clientes<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.CadastroCliente());
            }
        }

    }
}
