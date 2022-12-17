using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class ExpenseCategory
    {
        /// <summary>
        /// An automatically generated Id for each expense category, used as the primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the expense category.
        /// </summary>
        [DisplayName("Expense Category Name")]
        [Required]
        public string CategoryName { get; set; }
    }
}
