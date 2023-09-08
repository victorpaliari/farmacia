using Farmacia.Model;
using Farmacia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia.Controller
{
    public class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> listaProdutos = new List<Produto>();
        string? produto;
        int numero = 0;

        public void AtualizarProduto(Produto produto)
        {
            var buscaProduto = BuscarNaCollection(produto.GetNumero());

            if (buscaProduto != null)
            {
                var index = listaProdutos.IndexOf(buscaProduto);
                listaProdutos[index] = produto;
                Console.WriteLine($"O produto Nº {produto.GetNumero()} foi atualizado com sucesso.");
            }
        }

        public void ConsultarProdutoPorNumero(int numero)
        {
            var produto = BuscarNaCollection(numero);
            if (produto != null)
            {
                produto.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto numero {numero} não foi encontrado.");
                Console.ResetColor();
            }
        }
        public void ListarTodosProdutos()
        {
            foreach (var produto in listaProdutos)
            {
                produto.Visualizar();
            }
        }

        public void CriarProduto(Produto produto)
        {
            listaProdutos.Add(produto);
            Console.WriteLine($"O produto Nº {produto.GetNumero()} foi criado com sucesso.");
        }

        public void DeletarProduto(int numero)
        {
            var produto = BuscarNaCollection(numero);

            if (produto is not null)
            {
                if (listaProdutos.Remove(produto) == true)
                    Console.WriteLine($"O produto número {numero} foi apagado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto numero {numero} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void MudarBackground()
        {
            Console.WriteLine("Mudar a cor do plano de fundo");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - Amarelo");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2 - Vermelho");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3 - Verde");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4 - Azul");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("5 - Magenta");
            Console.ResetColor();

            int opcao = 0;

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

            }


        }
        //Métodos Auxiliares
        //Método para buscar o produto na Collection
        public Produto? BuscarNaCollection(int numero)
        {
            foreach (var produto in listaProdutos)
            {
                if (produto.GetNumero() == numero)
                {
                    return produto;
                }
            }
            return null;
        }

        public int GerarNumero()
        {
            return ++numero;
        }
    }
}

