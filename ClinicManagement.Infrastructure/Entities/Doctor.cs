namespace ClinicManagement.Infrastructure.Entities;

public class Doctor : BaseEntity
{
    public string name { get; set; }
    public int Id { get; set; }
    public int visits  { get; set; }
}