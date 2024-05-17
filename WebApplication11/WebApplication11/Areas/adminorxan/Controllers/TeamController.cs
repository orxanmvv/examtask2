using Microsoft.AspNetCore.Mvc;
using WebApplication11.DAL;
using WebApplication11.Models;
using WebApplication11.ViewModels.Team;

namespace WebApplication11.Areas.adminorxan.Controllers
{
    [Area("adminorxan")]
    public class TeamController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamController(AppDbContext appDbContext,IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var teams= _appDbContext.Teams.ToList();
            return View(teams);
        }

        public IActionResult Create()
        {
            //appDbContext.Teams.Add(team);
            //appDbContext.SaveChanges();
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreateTeamVm createTeamVm)
        {

            if (!createTeamVm.ImgFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImgFile", "Duzgun format daxil edin");
                return View();
            }

           

            string path = _webHostEnvironment.WebRootPath + @"\Upload\manage\";
            string fileName = Guid.NewGuid() + createTeamVm.ImgFile.FileName;
            using(FileStream stream=new FileStream(path + fileName, FileMode.Create))
            {
                createTeamVm.ImgFile.CopyTo(stream);
            }
            Team team = new Team()
            {
                Fullname = createTeamVm.Fullname,
                Job = createTeamVm.Job,
                ImgUrl = fileName
            };



            _appDbContext.Teams.Add(team);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

