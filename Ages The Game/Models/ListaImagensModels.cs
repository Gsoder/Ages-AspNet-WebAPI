using System.ComponentModel.DataAnnotations;

namespace Ages_The_Game.Models
{
    public class ListaImagensModels
    {
        [Key]
        public int Id { get; set; }
        public ICollection<ImagensModels>? ImagemDoDia { get; set; }
    }
}
