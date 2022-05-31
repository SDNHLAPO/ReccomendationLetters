using System;
using System.ComponentModel.DataAnnotations;

namespace ReccomendationLetters.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Please enter the course Code")]
        public string CourseCode { get; set; }
        [Required(ErrorMessage = "Please enter the course name")]
        public string CourseName { get; set; }


    }
}
