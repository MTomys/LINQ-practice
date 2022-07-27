// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var patients = MockData.GetPatients();
var doctors = MockData.GetDoctors();
var visits = MockData.GetVisits();


Console.WriteLine("Doctors ===");
doctors.ForEach(doctor => Console.WriteLine(doctor));

Console.WriteLine("Patients ===");
patients.ForEach(patient => Console.WriteLine(patient));
