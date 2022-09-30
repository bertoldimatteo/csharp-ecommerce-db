// See https://aka.ms/new-console-template for more information
using csharp_ecommerce_db;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("");

using (Ecommerce db = new Ecommerce())
{
    // senza costruttore
    Product product1 = new Product { Name = "Pizza Margherita", Description = "Pizza Margherita Classica", Price = 6.50 };
    db.Add(product1);

    //con costruttore
    Employee employee1 = new Employee("Carlo", "Manager");
    db.Add(employee1);

    //con lista
    db.Add(new Customer("Francesco", "Piscino", "piscino@mail.com"));
    db.Add(new Customer("Alessandro", "Gatto", "gatto@mail.com"));
    db.Add(new Customer("Antonio", "Banderas", "antonio@mail.com"));
    db.Add(new Customer("Mulino", "Bianco", "mulino@mail.com"));
    db.Add(new Customer("Pan", "Stelle", "pan@mail.com"));

    db.SaveChanges();

    Console.WriteLine("Recupero la lista dei prodotti");
    List<Product> products = db.Products.OrderBy(p => p.Name).ToList<Product>();

    Console.WriteLine("Recupero la lista dei clienti");
    List<Customer> customers = db.Customers.OrderBy(p => p.Name).ToList<Customer>();
}
public class Ecommerce : DbContext
{
   public DbSet<Customer> Customers { get; set; }
   public DbSet<Employee> Employees { get; set; }
   public DbSet<Order> Orders { get; set; }
   public DbSet<Payment> Payments { get; set; }
   public DbSet<Product> Products { get; set; }
   
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ecommerce-db;Integrated Security=True");
    }
}

