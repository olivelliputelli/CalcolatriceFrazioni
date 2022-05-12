using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class Prodotto
    {
        public int ProdottoId { get; set; }
        [Required(ErrorMessage = "Il nome del Prodotto è obbligatorio!")]
        public string? Nome { get; set; }
        public decimal? Prezzo { get; set; } = 0.0M;
        public DateTime? DataScadenzaGaranzia { get; set; } = DateTime.Today.AddYears(2);
        public virtual Categoria? Categoria { get; set; }
    }
}
