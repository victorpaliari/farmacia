using Farmacia.Model;
using System;
using System.ComponentModel;
using Farmacia.Controller;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia
{
    public class Program
    {
        public static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
                int opcao = 0;
                string nome, fragrancia, generico;
                int tipo, numero;
                decimal preco;

            ProdutoController produto = new();
            Medicamento teste = new Medicamento(produto.GerarNumero(), "omeprazol", 1, 40.0M, "Genérico");
            produto.CriarProduto(teste);

            //A classe Medicamento possui Método Construtor com parâmetros e isso obriga a declara-los
            //para instanciar objetos do tipo Classe Medicamento
            //Medicamento med1 = new Medicamento();
            //Não pode instanciar uma classe abstrata, no caso Produto é uma classe abstrata
            // Produto produto1 = new Produto (22, "fulano", 1, 2.0M);

            while (true)
            {
                /*
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                */
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("|          BEM-VINDO À FARMÁCIA          |");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("|        1. Criar Produto                |");
                Console.WriteLine("|        2. Listar Produtos              |");
                Console.WriteLine("|        3. Consultar Produto por Nº     |");
                Console.WriteLine("|        4. Atualizar Produto            |");
                Console.WriteLine("|        5. Deletar Produto              |");
                Console.WriteLine("|        6. Mudar cor de fundo           |");
                Console.WriteLine("|        0. Sair                         |");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Escolha uma opção para começar:           ");
                Console.WriteLine("                                          ");


                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Sobre();
                        System.Environment.Exit(0);
                        break;
                    case 1:

                        Console.WriteLine("Digite o nome do Produto: ");
                        nome = Console.ReadLine();
                        
                        nome ??= string.Empty;

                        do
                        {
                            Console.WriteLine("Digite o tipo do Produto: ");
                            Console.WriteLine("1 - Medicamento");
                            Console.WriteLine("2 - Cosmético");
                            tipo = Convert.ToInt32(Console.ReadLine());

                        } while (tipo != 1 && tipo != 2);

                            Console.WriteLine("Digite o preço do Produto: ");
                            preco = Convert.ToInt32(Console.ReadLine());

                        switch (tipo)
                          
                        {
                            case 1:
                                Console.WriteLine("Digite o genérico do produto: ");
                                generico = Console.ReadLine();
                                produto.CriarProduto(new Medicamento(produto.GerarNumero(), nome, tipo, preco, generico));
                                
                                break;
                            case 2:
                                Console.WriteLine("Digite o fragrância do produto: ");
                                fragrancia = Console.ReadLine();
                                produto.CriarProduto(new Cosmetico(produto.GerarNumero(), nome, tipo, preco, fragrancia));
                                break;
                        }
                                KeyPress();
                                break;
                            case 2:
                                produto.ListarTodosProdutos();
                                KeyPress();
                                break;
                            case 3:
                                Console.WriteLine("Digite o número: ");
                                numero = Convert.ToInt32(Console.ReadLine());
                                produto.ConsultarProdutoPorNumero(numero);
                                KeyPress();
                                break;
                            case 4:
                        Console.WriteLine("Digite o número: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        var produtos = produto.BuscarNaCollection(numero);

                        if (produtos is not null)
                        {
                            Console.WriteLine("Digite o nome do produto: ");

                            nome = Console.ReadLine();

                            nome ??= string.Empty;

                            do
                            {
                                Console.WriteLine("Digite o tipo do Produto: ");
                                Console.WriteLine("1 - Medicamento");
                                Console.WriteLine("2 - Cosmético");
                                tipo = Convert.ToInt32(Console.ReadLine());

                            } while (tipo != 1 && tipo != 2);

                            Console.WriteLine("Digite o preço do Produto: ");
                            preco = Convert.ToInt32(Console.ReadLine());

                            tipo = produtos.GetTipo();

                            switch (tipo)

                            {
                                case 1:
                                    Console.WriteLine("Digite o genérico do produto: ");
                                    generico = Console.ReadLine();
                                    produto.AtualizarProduto(new Medicamento(numero, nome, tipo, preco, generico));
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o fragrância do produto: ");
                                    fragrancia = Console.ReadLine();
                                    produto.AtualizarProduto(new Cosmetico(numero, nome, tipo, preco, fragrancia));
                                    break;
                            }
                        }

                        KeyPress();
                                break;
                            case 5:
                        Console.WriteLine("Digite o número do produto: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        produto.DeletarProduto(numero);
                        KeyPress();
                                break;
                            case 6:
                                
                                produto.MudarBackground();
                                
                                KeyPress();
                                break;
                        }
                }
            }
            static void Sobre()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n*********************************************************");
                Console.WriteLine("\tProjeto Desenvolvido por Victor Paliari");
                Console.WriteLine("\n\t\tvictorrpaliari@gmail.com");
                Console.WriteLine("\n\t\tgithub.com/victorpaliari");
                Console.WriteLine("*********************************************************");
                Console.ResetColor();

            }

            static void KeyPress()
            {
                do
                {
                    Console.Write("\nPressione Enter para Continuar...");
                    consoleKeyInfo = Console.ReadKey();
                } while (consoleKeyInfo.Key != ConsoleKey.Enter);
            }
        }
    }

