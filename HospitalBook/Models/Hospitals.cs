using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalBook.Models
{
    public class Hospitals
    {
        [Key]
        public int HospitalId { get; set; }
        [Required]
        public string HospitalName { get; set; }
        [Required]
        public string HospitalUrl { get; set; }
        public string Description { get; set; }



        //One to Many relation
        [ForeignKey("DoctorId")]
        public int DoctorId { get; set; }
        public ICollection<Doctor> Doctors { get; set; } //Collection N P

        //Many to Many Relation
        //relationship
        public List<Location_Hospital> Location_Hospital { get; set; }

       
    }
}
