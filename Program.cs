namespace ConsoleApplication
{
    public class Program
    {
        public class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }

        static List<Produto> produtos = new List<Produto>()
        {
            new Produto() { Id = 1, Nome = "Caneta", Preco = 1.50m },
            new Produto() { Id = 2, Nome = "Caderno", Preco = 15.00m },
            new Produto() { Id = 3, Nome = "Borracha", Preco = 0.50m }
        };

        static int Menu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adicionar um produto");
            Console.WriteLine("2 - Remover um produto pelo ID");
            Console.WriteLine("3 - Editar o nome de um produto pelo ID");
            Console.WriteLine("4 - Visualizar todos os produtos");
            Console.WriteLine("0 - Sair");
            string s = Console.ReadLine();
            int opcao;
            if (int.TryParse(s, out opcao))
            {
                return opcao;
            }
            else
            {
                return -1; // Opção inválida
            }
        }

        static void Adicionar(Produto produto)
        {
            produtos.Add(produto);
        }

        static void Remover(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        static void Editar(int id, string nome)
        {
            Produto produto = produtos.Find(p => p.Id == id);
            if (produto != null)
            {
                produto.Nome = nome;
            }
        }

        static void Visualizar()
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: {produto.Preco}");
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            int opcao = Menu();
            switch (opcao)
            {
                case 1: // Adicionar um produto
                    Console.WriteLine("Digite o ID do produto:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do produto:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o preço do produto:");
                    decimal preco = decimal.Parse(Console.ReadLine());
                    Produto produto = new Produto() { Id = id, Nome = nome, Preco = preco };
                    Adicionar(produto);
                    break;
                case 2: // Remover um produto pelo ID
                    Console.WriteLine("Digite o ID do produto que deseja remover:");
                    id = int.Parse(Console.ReadLine());
                    Remover(id);
                    break;
                case 3: // Editar o nome de um produto pelo ID
                    Console.WriteLine("Digite o ID do produto que deseja editar:");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o novo nome do produto:");
                    nome = Console.ReadLine();
                    Editar(id, nome);
                    break;
                case 4: // Visualizar todos os produtos
                    Visualizar();
                    break;
                case 0: // Sair
                    Console.WriteLine("Obrigado por usar o programa!");
                    break;
                default: // Opção inválida
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
