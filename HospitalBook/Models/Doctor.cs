using System.ComponentModel.DataAnnotations;

namespace HospitalBook.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public String NameDoctor { get; set; }
        //One to one relation doctor to doctor
        public DoctorDetatil DoctorDetatil { get; set; } //RNP
         //One to Many relation Director to Doctor
         public int DirectorId { get; set; } //FK
        public Director Director { get; set; } //RNP

        //One to Many relation hospital to Doctor
        public int HospitalId { get; set; } //FK
        public Hospitals Hospitals { get; set; } //RNP

    }
}
