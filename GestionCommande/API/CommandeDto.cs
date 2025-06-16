namespace API
{
    public class CommandeDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int NCommande { get; set; }
        public Decimal Montant { get; set; }
        public string? Client { get; set; }
        public bool EstLivree { get; set; }

    }
}
