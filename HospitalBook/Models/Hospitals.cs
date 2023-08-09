using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalBook.Models
{
    public class Hospitals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DoctorId { get; set; }

        //One to Many relation
        public ICollection<Doctor> Doctors { get; set; } //Collection N P

        //Many to Many Relation
        //relationship
        public List<Location_Hospital> Location_Hospital { get; set; }

       
    }
}
