using Basics.Models;
using Basics.Repository;
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
               new Course(){
                   Id=1, 
                   Title="Java 17 SE",
                   Description="Java 17 SE Oracle Sertificates", 
                   ImgUrl="java17Se.jpg",
                   Tags=new string[]{ "Java","Spring Boot"},
                   isActive=false,
                   isHome=true,
               },
               new Course(){
                   Id=2, 
                   Title="Asp.Net Core 7",
                   Description="Full Stack Asp.Net 7 Core ",
                   ImgUrl="ASP.webp",
                   Tags=new string[]{"Asp .Net","asp"},
                   isActive=true,
                   isHome=true,
               },
               new Course(){
                   Id=3, 
                   Title="Python with Django",
                   Description="Python with Django framework web programming",
                   ImgUrl = "pythonDajngo.webp",
                   Tags=new string[]{"Django","flask","Python"},
                   isActive=true,
                   isHome=false,
               },
               new Course(){
                   Id=4, 
                   Title="JavaScript",
                   Description="JavaScript with code",
                   ImgUrl = "javaScript.png",
                   Tags=new string[]{"javascript","react","angular"},
                   isActive=true,
                   isHome=true,
               },
            };
            return View(kurslar);
        }
        public IActionResult List()
        {
          
            return View(CourseRepository.Courses);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index","Course");
            }
            var kurs = CourseRepository.GetById(id);
           
            return View(kurs);
        }
    }
}
