// Declare a classe Produto como pública para poder usá-la em membros públicos da sua classe
public class Produto
{
    // Aqui você pode definir as propriedades e métodos da classe Produto
    // Por exemplo:
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

public class SuaClasse
{
    // Declare a lista _produtos como privada para manter a encapsulação
    private static List<Produto> _produtos = new List<Produto>();

    // Declaração da propriedade pública do tipo List<Produto>
    public static List<Produto> Produtos
    {
        get { return _produtos; }
    }

    // Declaração do método público para adicionar um produto
    public static void AdicionarProduto(Produto p)
    {
        _produtos.Add(p);
    }

    // Declaração do método público para remover um produto por ID
    public static void RemoverProdutoPorId(int id)
    {
        _produtos.RemoveAll(p => p.Id == id);
    }

    // Declaração do método público para editar o nome de um produto por ID
    public static void EditarNomeDoProdutoPorId(int id, string novoNome)
    {
        Produto produto = _produtos.Find(p => p.Id == id);
        if (produto != null)
        {
            produto.Nome = novoNome;
        }
    }

    // Declaração do método público para remover um produto
    public static void RemoverProduto(Produto produto)
    {
        _produtos.Remove(produto);
    }
}
