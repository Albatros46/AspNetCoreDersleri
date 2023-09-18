using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            //var kurs = new Course() { Id = 1, Title = "asp .Net Core 7", Description = "C# Asp.Net Core 7 Ileri seviye kurs." };
            //return View(kurs);
            var kurslar = new List<Course>()
            {
               new Course(){Id=1, Title="Java 17 SE",Description="Java 17 SE Oracle Sertificates", ImgUrl="java17Se.jpg"},
               new Course(){Id=2, Title="Asp.Net Core 7",Description="Full Stack Asp.Net 7 Core ",ImgUrl="ASP.webp"},
               new Course(){Id=3, Title="Python with Django",Description="Python with Django framework web programming",ImgUrl = "pythonDajngo.webp"},
            };
            return View(kurslar);
        }
        public IActionResult List()
        {
            var kurslar = new List<Course>()
            {
               new Course(){Id=1, Title="Java 17 SE",Description="Java 17 SE Oracle Sertificates", ImgUrl="java17Se.jpg"},
               new Course(){Id=2, Title="Asp.Net Core 7",Description="Full Stack Asp.Net 7 Core ",ImgUrl="ASP.webp"},
               new Course(){Id=3, Title="Python with Django",Description="Python with Django framework web programming",ImgUrl = "pythonDajngo.webp"},
            };
            return View(kurslar);
        }
    }
}
