namespace Modul2WebTest28.Models;

public interface IDataRepository
{
    public IEnumerable<Person> GetPersons();
    public Person GetPersonById(int id);

    public IEnumerable<Cloth> GetCloths();
    public Cloth GetClothById(int id);

    IEnumerable<Flat> GetFlats();


    void AddPerson(Person person);
    void AddCloth(Cloth cloth);
    void AddFlat(Flat flat);


    void UpdatePerson(Person person);
    void DeletePerson(int id);

    void UpdateCloth(Cloth cloth);
    void DeleteCloth(int id);

    void UpdateFlat(Flat flat);

    void CreatePersonFlat(Person person, Flat flat);

}



// Generic interface example

// public interface IDataRepository<T>
// {
//     void Add(T data);
// }
