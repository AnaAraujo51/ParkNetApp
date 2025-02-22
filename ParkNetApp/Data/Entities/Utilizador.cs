public class Utilizador : IdentityUser
{
    [Required]
    public string Nome { get; set; }
    [Required]
    public int CartaDeConducao { get; set; }
    [Required]
    public int CartaDeCredito { get; set; }
    public DateTime ValidadeCrtCredito { get; set; }
    public decimal Saldo { get; set; }
    public bool IsAdmin { get; set; }

}