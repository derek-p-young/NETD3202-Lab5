using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
    }
}
