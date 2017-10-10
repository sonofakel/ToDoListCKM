using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Story { get; set; }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

    }
}
