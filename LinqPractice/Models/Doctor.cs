namespace LinqPractice.Models
{
    public class Doctor
    {

        public int DoctorId { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public DateTime DoctorBirthDate { get; set; }
        public string DoctorPhoneNumber { get; set; }
        public string DoctorEmail { get; set; }
        public DoctorSpecialization DoctorSpecialization { get; set; }
        public virtual ICollection<Visit> DoctorVisits { get; set; }

        public override string ToString()
        {
            return $"Doctor no. : {DoctorId} First Name: {DoctorFirstName} LastName: {DoctorLastName} Birth Date: {DoctorBirthDate} ";
        }

    }

}
