using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Job { get; set; }
        public string? ImgUrl { get; set; }
        //public IFormFile ImageFile { get; set; }
      
    }
}
