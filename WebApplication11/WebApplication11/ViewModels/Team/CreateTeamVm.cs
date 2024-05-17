using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.ViewModels.Team
{
    public class CreateTeamVm
    {
        public int Id { get; set; }
        [StringLength(25, ErrorMessage = "Uzlug 25 i kece bilmez")]
        public string Fullname { get; set; }
        public string Job { get; set; }
        [NotMapped]
        public IFormFile ImgFile { get; set; }
    }
}
