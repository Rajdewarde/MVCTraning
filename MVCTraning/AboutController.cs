using Microsoft.AspNetCore.Mvc;
using MVCTraning.Models;

namespace MVCTraning.Controllers
{
    public class AboutController : Controller
    {
        // 1. Index Action
        public IActionResult Index()
        {
            return View();
        }

        // 2. About Action
        public IActionResult About()
        {
            return View();
        }

        // 3. History Action
        public IActionResult History()
        {
            return View();
        }

        // 4. Service Action with Data
        public IActionResult Service()
        {
            List<ServiceModel> services = new List<ServiceModel>
            {
                new ServiceModel { Id = 1, Title = "Web Development", Description = "Building responsive web applications." },
                new ServiceModel { Id = 2, Title = "Mobile App Development", Description = "Creating Android and iOS applications." },
                new ServiceModel { Id = 3, Title = "UI/UX Design", Description = "Designing user-friendly interfaces." },
                new ServiceModel { Id = 4, Title = "SEO Optimization", Description = "Improving search engine rankings." },
                new ServiceModel { Id = 5, Title = "Cloud Services", Description = "Hosting and cloud infrastructure management." }
            };

            return View(services);
        }

        // 5. Contact Action
        public IActionResult Contact()
        {
            return View();
        }
    }
}