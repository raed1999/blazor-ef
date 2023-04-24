using System.ComponentModel.DataAnnotations;

namespace Demo.Data.Models;

public class Order{
    
    [Key]
    public int Id {get;set;}

    public String ItemDescription {get; set;} = "";

    public int Quantity {get; set;} = 0;

    public Customer customer; 
}