namespace ClinicManagement.Infrastructure.Entities;

public class Visits
{
    public int Id { get; set; }
    public int patientId { get; set; }
    public int doctorId { get; set; }
    public string patientName { get; set; }
    public string doctorName { get; set; }
    public DateTime Date { get; set; }
}