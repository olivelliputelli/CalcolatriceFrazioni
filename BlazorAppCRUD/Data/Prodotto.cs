using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class Prodotto
    {
        public int ProdottoId { get; set; }
        [Required(ErrorMessage = "Il nome del Prodotto è obbligatorio!")]
        public string? Nome { get; set; }
        [StringLength(150, ErrorMessage = "Descrizione troppo lunga!")]
        public string? Descrizione { get; set; } = "";
        public decimal? Prezzo { get; set; } = 0.0M;
        public decimal? Iva { get; set; } = 22.0M;
        public bool IsNuovo { get; set; } = true;
        public string? ImagePath { get; set; }
        public DateTime? DataScadenzaGaranzia { get; set; } = DateTime.Today.AddYears(2);
        public virtual Categoria? Categoria { get; set; }
        public int? CategoriaId { get; set; }
    }
}
