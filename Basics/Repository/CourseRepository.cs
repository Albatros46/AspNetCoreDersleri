using Basics.Models;

namespace Basics.Repository
{
    public class CourseRepository
    {
        private static readonly List<Course> _courses = new();
       
        static CourseRepository()
        {
            _courses = new List<Course>()
            {
               new Course(){Id=1, Title="Java 17 SE",Description="Java 17 SE Oracle Sertificates", ImgUrl="java17Se.jpg"},
               new Course(){Id=2, Title="Asp.Net Core 7",Description="Full Stack Asp.Net 7 Core ",ImgUrl="ASP.webp"},
               new Course(){Id=3, Title="Python with Django",Description="Python with Django framework web programming",ImgUrl = "pythonDajngo.webp"},
               new Course(){Id=4, Title="JavaScript",Description="JavaScript with code",ImgUrl = "javaScript.png"},
            };
        }

        public static List<Course> Courses
        {
            get { return _courses; }
        }
        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
