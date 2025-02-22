public class Avenca
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ParqueId { get; set; }

    [ForeignKey("ParqueId")]
    public Parque Parque { get; set; }

    [Required]
    public DateTime Validade { get; set; }

    [Required]
    public string UtilizadorId { get; set; }

    [ForeignKey("UtilizadorId")]
    public Utilizador Utilizador { get; set; }

    public decimal Preco { get; set; }
}