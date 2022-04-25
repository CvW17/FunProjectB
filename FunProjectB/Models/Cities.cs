namespace FunProjectB.Models
{
    public class Cities
    {
        public int ID { get; set; }
        public string City { get; set; } = string.Empty;
        public int? ContinentsID { get; set; }
        public int? CountriesID { get; set; }

        public Continents Continents { get; set; }
        public Countries Countries { get; set; }
    }
}
