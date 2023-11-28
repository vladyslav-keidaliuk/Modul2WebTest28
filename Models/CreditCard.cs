namespace Modul2WebTest28.Models;

public class CreditCard
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Person Person { get; set; } // for 1 to 1
    public int PersonId { get; set; } // for 1 to 1
}