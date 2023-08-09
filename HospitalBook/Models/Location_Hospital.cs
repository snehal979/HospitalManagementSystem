namespace HospitalBook.Models
{
    public class Location_Hospital
    {
        //many to many
        public int HospitalId { get;set; }
        public Hospitals Hospitals { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}