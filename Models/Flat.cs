namespace Modul2WebTest28.Models;

public class Flat
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Person> Persons { get; set; } = new(); // for many to many
}