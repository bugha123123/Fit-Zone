using System.ComponentModel.DataAnnotations;

namespace Instagram_Clone.Models
{
    public class FeedBack
    {

        public  int Id { get; set; }

        [Required(ErrorMessage ="FeedBack is required")]
        [MinLength(10)]
        [MaxLength(50)]
        public string UserFeedBack { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }
    }
}
