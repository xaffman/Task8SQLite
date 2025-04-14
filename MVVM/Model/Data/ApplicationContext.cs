using Microsoft.EntityFrameworkCore;




class ApplicationContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Department> Departments { get; set; }

    public ApplicationContext() 
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
    {
        dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Task8DB;Trusted_Connection=True");
    }

}