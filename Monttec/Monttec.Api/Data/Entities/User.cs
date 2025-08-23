using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Monttec.Api.Data.Entities;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(20)]
    public string Username { get; set; }
    [Required, MaxLength(150)]
    public string Email { get; set; }
    [MaxLength(20)]
    public string? Mobile { get; set; }
    [Required]
    public string PasswordHash { get; set; }

    public ICollection<Address> UserAddresses { get; set; }
}
