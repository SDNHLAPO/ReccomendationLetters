using System;
using System.ComponentModel.DataAnnotations;



namespace ReccomendationLetters.Models
{
    public class Department
    {

        [Key]
        public int DepartId { get; set; }

        [Required(ErrorMessage = "Please enter the department name")]
        public string DepartName { get; set; }

        [Required(ErrorMessage = "Please choose the Level")]
        public int Level { get; set; }

        [Required(ErrorMessage = "Please enter the department code")]
        public string DepartCode { get; set; }



    }
}
