using System.ComponentModel.DataAnnotations;

namespace WebApplication11.ViewModels.Team
{
    public class UpdateTeamVm
    {
        public int Id { get; set; }
        [StringLength(25, ErrorMessage = "Uzlug 25 i kece bilmez")]
        public string Fullname { get; set; }
        public string Job { get; set; }
        public string? ImgUrl { get; set; }
    }
}
