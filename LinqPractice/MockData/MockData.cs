using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LinqPractice.MockData
{
    public class MockData
    {
        
        public static List<Patient> GetPatients()
        {
            var patients = GenericDataProvider<Patient>.GetGenericData("patient_data.json");
            return patients;
        }
        public static List<Doctor> GetDoctors()
        {
            var doctors = GenericDataProvider<Doctor>.GetGenericData("doctor_data.json");
            return doctors;
        }

        public static List<Visit> GetVisits()
        {
            var visits = GenericDataProvider<Visit>.GetGenericData("visit_data.json");
            return visits;
        }
    }
}
