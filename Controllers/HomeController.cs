using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modul2WebTest28.Models;

namespace Modul2WebTest28.Controllers
{
    public class HomeController : Controller
    {
        private IDataRepository _dbRepository;
        private EFDatabaseContext _context;

        public HomeController(IDataRepository dbRepository, EFDatabaseContext context)
        {
            _dbRepository = dbRepository;
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_dbRepository.GetPersons());
        }

        public IActionResult Flats()
        {

            return View(_dbRepository.GetFlats());
        }

        public IActionResult Create()
        {
            Random random = new Random();
            Person person1 = new Person
            {
                Name = $"New{random.Next(1000)}",
            };

            Cloth cloth1 = new Cloth { Name = $"New{random.Next(1000)}", };
            Cloth cloth2 = new Cloth { Name = $"New{random.Next(1000)}", };

            Cloth cloth3 = new Cloth { Name = $"New{random.Next(1000)}", };

            Flat flat1 = new Flat { Name = $"NewFlat{random.Next(1000)}" };
            Flat flat2 = new Flat { Name = $"NewFlat{random.Next(1000)}" };

            Person person2 = new Person { Name = $"New{random.Next(1000)}" };

           

            person1.Clothes.Add(cloth1);
            person1.Clothes.Add(cloth2);

            person2.Clothes.Add(cloth3);

            _dbRepository.AddPerson(person1);
            _dbRepository.AddPerson(person2);

            _dbRepository.AddFlat(flat1);
            _dbRepository.AddFlat(flat2);

            _dbRepository.CreatePersonFlat(person1,flat1);
            _dbRepository.CreatePersonFlat(person1,flat2);
            _dbRepository.CreatePersonFlat(person2,flat2);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update()
        {
            Person person = _dbRepository.GetPersons().Last();
            person.Name = "Igor";
            Cloth cloth = person.Clothes.First();
            cloth.Name = "NIKE";

            Flat flat = _dbRepository.GetFlats().Last();
            flat.Name = "Kadorr";

            _dbRepository.UpdatePerson(person);
            _dbRepository.UpdateFlat(flat);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete()
        {
            Person person = _dbRepository.GetPersons().Last();
            _dbRepository.DeletePerson(person.Id);

            return RedirectToAction(nameof(Index));
        }

    }
}
