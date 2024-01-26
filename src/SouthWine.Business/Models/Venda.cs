namespace SouthWine.Business.Models
{
    public class Venda : Entity
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public decimal DistanciaEntrega { get; set; }
        public decimal TotalGeral {  get; set; }
        public decimal Frete { get; set; }
 
    }
}
