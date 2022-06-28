namespace ClinicManagement.Infrastructure.Entities;

public class Patient
{
    public int Id { get; set; }
    public int visitId { get; set; }
    public string name { get; set; }
    public int phoneNumber { get; set; }
}