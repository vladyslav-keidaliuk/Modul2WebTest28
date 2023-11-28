﻿using System;
using Microsoft.EntityFrameworkCore;

namespace Modul2WebTest28.Models;

public class EFDatabaseRepository : IDataRepository
{
    private EFDatabaseContext _context;

    public EFDatabaseRepository(EFDatabaseContext context)
    {
        _context = context;
    }
    // public IEnumerable<Person> GetPersons()
    // {
    //     return _context.Persons;
    // }

    public IEnumerable<Person> GetPersons()
    {
        return _context.Set<Person>()
            .Include(p => p.Clothes);
    }

    public Person GetPersonById(int id)
    {
        return _context.Persons.Find(id);
    }

    public IEnumerable<Cloth> GetCloths()
    {
        return _context.Cloths;
    }

    public Cloth GetClothById(int id)
    {
        return _context.Cloths.Find(id);
    }

    public void AddPerson(Person person)
    {
        _context.Persons.Add(person);
        _context.SaveChanges();
    }

    public void AddCloth(Cloth cloth)
    {
        _context.Cloths.Add(cloth);
        _context.SaveChanges();
    }

    public void UpdatePerson(Person person)
    {
        _context.Entry(person).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void DeletePerson(int id)
    {
        _context.Persons.Remove(GetPersonById(id));
        _context.SaveChanges();
    }

    public void UpdateCloth(Cloth cloth)
    {
        _context.Cloths.Update(cloth);
        _context.SaveChanges();
    }

    public void DeleteCloth(int id)
    {
        _context.Cloths.Remove(GetClothById(id));
        _context.SaveChanges();
    }
}