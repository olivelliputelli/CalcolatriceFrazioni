using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required(ErrorMessage ="Il nome della Categoria è obbligatorio!")]
        public string? Nome { get; set; }
        public virtual ICollection<Prodotto>? Prodotti { get; set; }
    }
}
