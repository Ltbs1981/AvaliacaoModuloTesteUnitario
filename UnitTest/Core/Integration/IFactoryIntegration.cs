using UnitTest.Feature.Produto;

namespace UnitTest.Core.Integration
{
    public interface IFactoryIntegration
    {
        public bool ExistProduct(Produto produto);
        public void ReservaProduto(Produto produto);

    }
}
