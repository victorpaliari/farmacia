namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|          BEM-VINDO À FARMÁCIA          |");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|        1. Criar Produto                |");
            Console.WriteLine("|        2. Listar Produtos              |");
            Console.WriteLine("|        3. Consultar Produto por ID     |");
            Console.WriteLine("|        4. Atualizar Produto            |");
            Console.WriteLine("|        5. Deletar Produto              |");
            Console.WriteLine("|        0. Sair                         |");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Escolha uma opção para começar:           ");
            Console.WriteLine("                                          ");
            Console.ResetColor();

        }
    }
}