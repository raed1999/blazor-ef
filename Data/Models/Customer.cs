using System.ComponentModel.DataAnnotations;

namespace Demo.Data.Models;

public class Customer
{
    [Key]
    public int Id { get; set; }
 
    [Required(ErrorMessage = "Name is required")]
    public String Name { get; set; } = "";


    [Required]
    public int Age { get; set; } = 0;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

   public ICollection<Order> Orders { get; set; }
    
}