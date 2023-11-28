namespace Modul2WebTest28.Models
{
    public class Cloth
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
