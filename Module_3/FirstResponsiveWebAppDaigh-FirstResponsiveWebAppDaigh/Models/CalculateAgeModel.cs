using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppDaigh.Models
{
    public class CalculateAgeModel
    {
        const int MIN_VALUE = 1900; 
        const int MAX_VALUE = 2100;
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your birthyear")]
        [Range(MIN_VALUE, MAX_VALUE, ErrorMessage = "Please enter your 4 digit birthyear")]
        public int? BirthYear { get; set; }

        public int? AgeThisYear()
        {
            int? currentYear = DateTime.Now.Year;
            int? age = currentYear - BirthYear;
            return age;
        }
    }
}
