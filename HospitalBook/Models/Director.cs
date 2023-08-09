using System.ComponentModel.DataAnnotations;

namespace HospitalBook.Models
{
    public class Director
    {
        [Key]
        public int DirectorId { get; set; }
        [Required]
        public String DirectorName { get; set; }

        //One to Many relation
      public ICollection<Doctor> Doctors { get; set; } //Collection N P

    }
}
