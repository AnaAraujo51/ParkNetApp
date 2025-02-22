namespace ParkNetApp.Data.Entities
{
    public class Parque
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Edificio { get; set; }

        [Required]
        public int Pisos { get; set; }

        [Required]
        public int Capacidade { get; set; }

        [Required]
        public List<Estacionamento> Estacionamento { get; set; }
    }
}