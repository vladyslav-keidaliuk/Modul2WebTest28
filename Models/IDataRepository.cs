namespace Modul2WebTest28.Models;

public interface IDataRepository
{
    public IEnumerable<Person> GetPersons();
    public Person GetPersonById(int id);

    public IEnumerable<Cloth> GetCloths();
    public Cloth GetClothById(int id);

    void AddPerson(Person person);
    void AddCloth(Cloth cloth);


    void UpdatePerson(Person person);
    void DeletePerson(int id);

    void UpdateCloth(Cloth cloth);
    void DeleteCloth(int id);

}