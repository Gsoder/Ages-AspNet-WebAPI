using System.ComponentModel.DataAnnotations;

namespace Ages_The_Game.Models
{
    public class ImagensModels
    {
        [Key]
        public int Id { get; set; }
        public string? Base64Imagem { get; set; }
        public int? Ano { get; set; }
        public string? Continente { get; set; }
        public string? Pais { get; set; }
        public int IDDaLista { get; set; }
        public string? Dica1 { get; set; }
        public string? Dica2 { get; set; }
        public string? Dica3 { get; set; }
    }
}
