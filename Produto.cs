namespace CadastroDeProdutos
{
    class Produto
    {
        // Campo privado do tipo int para armazenar o ID do produto
        private int _id;

        // Campo privado do tipo string para armazenar o nome do produto
        private string _nome;

        // Construtor público que recebe dois parâmetros do tipo int e string, respectivamente, e atribui os seus valores aos campos _id e _nome
        public Produto(int id, string nome)
        {
            _id = id;
            _nome = nome;
        }

        // Propriedade pública do tipo int que retorna o valor do campo _id
        public int Id
        {
            get { return _id; }
        }

        // Propriedade pública do tipo string que retorna o valor do campo _nome e permite alterá-lo
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}