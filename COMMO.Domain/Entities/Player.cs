using System.ComponentModel.DataAnnotations;

namespace COMMO.Domain.Entities
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public int AccountId { get; set; }
        public int WorldId { get; set; }
        public string Name { get; set; }
    }
}
