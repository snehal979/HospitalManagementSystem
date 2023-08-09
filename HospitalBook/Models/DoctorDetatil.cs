namespace HospitalBook.Models
{
    public class DoctorDetatil
    {
        
        public int Id { get; set; }
        public String Bio { get; set; }
        public string DoctorDegree { get; set; }
        public string DoctorPhone { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorType { get; set;}
        //One to one relation
        public int DoctorId { get;set; } //Fk
        public Doctor Doctor { get; set; } //RNP

    }
    
}
