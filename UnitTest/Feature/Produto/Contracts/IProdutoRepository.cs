using UnitTest.Core;

namespace UnitTest.Feature.Produto.Contracts
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Produto BuscaProdutoPorSKU(string sku);
        void RegistraPedidoProduto(Produto produto);
    }
}
