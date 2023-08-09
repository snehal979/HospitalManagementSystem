using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HospitalBook.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
       
        public string LocationName { get; set; }
        //Many to Many Relation
        //relationship
        public List<Location_Hospital> Location_Hospital { get; set; }
    }
}
