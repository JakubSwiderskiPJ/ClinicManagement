using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Infrastructure.Entities;

public class BaseEntity
{
    [Key]
    [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
    private int Id { get; set; }
    private DateTime DateOfCreation { get; set; }
    private DateTime DateOfUpdate { get; set; }
}