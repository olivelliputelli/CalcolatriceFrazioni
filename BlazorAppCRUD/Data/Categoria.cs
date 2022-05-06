using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class Categoria
    {
        public int CtegoriaId { get; set; }
        [Required]
        public string? Nome { get; set; }
    }
}
