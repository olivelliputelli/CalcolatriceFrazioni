

namespace ClassiUtili
{
    public class Prodotto
    {
        public string Nome { get; set; } = "";
        public DateTime DataProduzione { get; set; } = DateTime.Today;
        public Nazione Nazione { get; set; }
        public Stagione AdattoA { get; set; }
    }
}
