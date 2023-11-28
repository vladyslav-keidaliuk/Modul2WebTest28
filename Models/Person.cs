namespace Modul2WebTest28.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Cloth> Clothes { get; set; } = new();

}