using IPTestFormASP.Models.Entities;
using IPTestFormASPTeacherApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace IPTestFormASPTeacherApp.Controllers
{
    public class InternetProtocolController : Controller
    {
        private IPService ipService;

        public InternetProtocolController(IPService ipService)
        {
            this.ipService = ipService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TestsList()
        {
            List<IPInfos> ipInfosList = ipService.GetAllTests();
            return View(ipInfosList);
        }

        [HttpPost]
        public IActionResult Test(int testID)
        {
            IPInfos ipInfos = ipService.GetTestByID(testID);
            return View(ipInfos);
        }
    }
}
