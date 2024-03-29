// Post model
using System;
using System.ComponentModel.DataAnnotations;

namespace Instagram_Clone.Models
{
    public class Post
    {
        public int Id { get; set; }

        public DateTime CreateAt { get; set; }

        [Required(ErrorMessage = "Description required")]
        public string Description { get; set; }

        public string AddedByUserName { get; set; }

        public string MainImagePath { get; set; }
    }
}
