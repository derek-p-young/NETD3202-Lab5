using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class ExpenseCategory
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense Category Name")]
        [Required]
        public string CategoryName { get; set; }
    }
}
