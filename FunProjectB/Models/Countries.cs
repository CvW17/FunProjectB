namespace FunProjectB.Models
{
    public class Countries
    {
        public int ID { get; set; }
        public string Country { get; set; } = string.Empty;
        public int? ContinentsID { get; set; }

        public Continents continents { get; set; }
    }
}
