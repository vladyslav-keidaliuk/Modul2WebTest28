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

            return View(
                _context.Set<Person>()
                    .Include(p => p.Clothes)
                
                );
        }

        public IActionResult Create()
        {
            Random random = new Random();
            Person person = new Person
            {
                Name = $"New{random.Next(1000)}",
            };

            Cloth cloth1 = new Cloth { Name = $"New{random.Next(1000)}", };
            Cloth cloth2 = new Cloth { Name = $"New{random.Next(1000)}", };

            person.Clothes.Add(cloth1);
            person.Clothes.Add(cloth2);

            _dbRepository.AddPerson(person);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update()
        {
            Person person = _dbRepository.GetPersons().Last();
            person.Name = "Igor";
            Cloth cloth = person.Clothes.First();
            cloth.Name = "NIKE";

            _dbRepository.UpdatePerson(person);

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
