using Microsoft.EntityFrameworkCore;
using Monttec.Api.Data.Entities;

namespace Monttec.Api.Data;

public class DataContex: DbContext
{
    public DataContex(DbContextOptions<DataContex> options) : base(options)
    {
    }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<User> User { get; set; }


    }
