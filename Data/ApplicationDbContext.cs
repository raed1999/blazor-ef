using Demo.Data.Models;
using Microsoft.EntityFrameworkCore; 

public class ApplicationDbContext : DbContext
{


    /* Constructor for setting up Database Connection */
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
    { 

    }

    

    /* Generates the table schema based on the models */
    public DbSet<Customer> Customers {get; set;}
    public DbSet<Order> Orders {get; set;}


}