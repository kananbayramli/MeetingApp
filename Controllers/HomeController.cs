using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // var salamlama = saat < 12 ? "Sabahiniz Xeyir" : "Her Vaxtiniz Xeyir";
            // return View(model: salamlama);


            ViewBag.Salamlama = saat < 12 ? "Sabahiniz Xeyir" : "Her Vaxtiniz Xeyir";
            //ViewBag.UserName = "Kenan";
            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Baku, Flame Tower, 10a",
                Date = new DateTime(2024, 01, 31, 21, 0, 0),
                NumberOfPeople = UserCount

            };

            return View(meetingInfo);
        }
    }
}