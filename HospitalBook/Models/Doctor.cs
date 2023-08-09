using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalBook.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Display(Name = "NameDoctor")]
        [Required(ErrorMessage = "Full Name is required")]
        public String NameDoctor { get; set; }
        [Required]
        public string DoctorUrl { get; set; }



        //One to one relation doctor to doctor
        public DoctorDetatil DoctorDetatil { get; set; } //RNP


        //One to Many relation Director to Doctor
        [ForeignKey("DirectorId")]
         public int DirectorId { get; set; } //FK
        public Director Director { get; set; } //RNP

        //One to Many relation hospital to Doctor
        [ForeignKey("HospitalId")]
        public int HospitalId { get; set; } //FK
        public Hospitals Hospitals { get; set; } //RNP

    }
}
