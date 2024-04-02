using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicObjectLayer;
using BusinessLogicManagerLayer;
using DataAccessLayer;

namespace WEBSITE.Pages
{
    public class IndexModel : PageModel
    {
     
        AnimalManager animalManager = new AnimalManager(new AnimalDAL());

        public List<Animal> AllAnimals { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {
           

            this.AllAnimals = animalManager.GetAllAnimals();

        }
    }
}
