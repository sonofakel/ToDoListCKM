using System;
using System.ComponentModel.DataAnnotations;

namespace TravelBlog.Models
{
    public class Person
    {

        [Key]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
