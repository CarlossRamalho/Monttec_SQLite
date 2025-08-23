using Monttec.Shared.Constants;
using System.ComponentModel.DataAnnotations;

namespace Monttec.Api.Data.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }
    public virtual User User { get; set; }

    public decimal TotalAmount { get; set; }

    [MaxLength(200)]
    public string? Remark { get; set; }

    [Required, MaxLength(15)]
    public string Status { get; set; } = nameof(OrderStatus.Pending);

    public int UserAddressId { get; set; }
    public string Address { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = [];
}
