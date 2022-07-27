using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime PatientBirthDate { get; set; }
        public string PatientPhoneNumber { get; set; }
        public string PatientEmail { get; set; }
        public virtual ICollection<Visit> PatientAppointments { get; set; }

        public override string ToString()
        {
            return $"Patient no. : {PatientId} First Name: {PatientFirstName} LastName: {PatientLastName} Birth Date: {PatientBirthDate} ";
        }
    }
}
