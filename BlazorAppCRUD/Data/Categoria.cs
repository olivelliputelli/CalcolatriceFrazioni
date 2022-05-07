using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required]
        public string? Nome { get; set; }
    }
}
