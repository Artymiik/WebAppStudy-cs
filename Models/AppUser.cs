namespace WebAppStudy.Models
{
    public class AppUser
    {
        public string Id { get; set; }
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public Adress? Adress { get; set; }
        public ICollection<Club> Clubs { get; set; }
    }
}
