public class Pagamento
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string UtilizadorId { get; set; }

    [ForeignKey("UtilizadorId")]
    public Utilizador Utilizador { get; set; }

    [Required]
    public int AvencaId { get; set; }

    [ForeignKey("AvencaId")]
    public Avenca Avenca { get; set; }
    [Required]
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
}