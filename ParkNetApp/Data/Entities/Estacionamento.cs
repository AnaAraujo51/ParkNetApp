namespace ParkNetApp.Data.Entities
{
    public class Estacionamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Identificador { get; set; }

        [Required]
        public int ParqueId { get; set; }

        [ForeignKey("ParqueId")]
        public Parque Parque { get; set; }

        [Required]
        public bool IsOccupied { get; set; }
    }
}