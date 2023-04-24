using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

public class CustomerService
{


    private IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    /* Constructor */
    public CustomerService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }


      /* Method for getting specific Customer */
    public Customer GetCustomer (int Id){
        using (var context = _dbContextFactory.CreateDbContext()){
           
            return context.Customers.Find(Id) /* ?? throw new NullReferenceException("No data found") */;
    
        }
    }

     /* Method for getting all Customer */
    public List<Customer> AllCustomers (){
        using (var context = _dbContextFactory.CreateDbContext()){

            return context.Customers.ToList();

        }
    }

     /* Method for Adding a Customer */
    public void AddCustomer(Customer customer){
        using (var context = _dbContextFactory.CreateDbContext()){

            /* This only adds data into the memory */
            context.Customers.Add(customer);

            /* Commits data into the datatabase */
            context.SaveChanges();
            
        }
    }

      /* Method for Updating a Customer */
    public void EditCustomer(Customer customer){
        using (var context = _dbContextFactory.CreateDbContext()){

            /* This only adds data into the memory */
            context.Customers.Update(customer);

            /* Commits data into the datatabase */
            context.SaveChanges();
        }
    }

}