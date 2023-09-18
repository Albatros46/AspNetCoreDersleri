namespace Basics.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ImgUrl { get; set; }
        public string? Description { get; set; }

        public string[]? Tags { get; set; }
        public bool isActive { get; set; } //aktif kurs 
        public bool isHome { get; set; } //anasayfada yer alan
    }
}
