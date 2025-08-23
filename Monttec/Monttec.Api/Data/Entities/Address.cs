using System.ComponentModel.DataAnnotations;

namespace Monttec.Api.Data.Entities;

public class Address
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    [Required, MaxLength(20)]
    public string ContactName { get; set; }
    [Required, MaxLength(15)]
    public string ContactPhone { get; set; }
    [Required, MaxLength(200)]
    public string AddressLine { get; set; }
    [MaxLength(100)]
    public string? Landmark { get; set; }
    [MaxLength(50)]
    public string? City { get; set; }
    [MaxLength(50)]
    public string? State { get; set; }
    [MaxLength(10)]
    public string? ZipCode { get; set; }
    [MaxLength(50)]
    public string? Country { get; set; }
    public bool IsDefault { get; set; } = false;
}