using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public DateOnly DoctorBirthDate { get; set; }
        public string DoctorPhoneNumber { get; set; }
        public string DoctorEmail { get; set; }
        public DoctorSpecialization DoctorSpecialization { get; set; }
        public virtual ICollection<Visit> DoctorVisits { get; set; }
    }
}
