namespace Modul2WebTest28.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Cloth> Clothes { get; set; } = new(); // for 1 to many

    public List<Flat> Flats { get; set; } = new(); // for many to many

}