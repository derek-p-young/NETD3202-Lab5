using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public class Expense
    {

        /// <summary>
        /// An automatically generated Id for each expense, used as the primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The date of the expense.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }


        /// <summary>
        /// The expense description.
        /// </summary>
        [Required]
        public string Description { get; set; }


        /// <summary>
        /// The dollar amount of the expense.
        /// </summary>
        [Required]
        [Range(0.01, int.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public double Amount { get; set; }


        /// <summary>
        ///  The Id of the selected expense category.
        /// </summary>
        [ForeignKey("ExpenseCategory")]
        [Required]
        [DisplayName("Expense Category")]
        public int ExpenseCategoryID { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }


        /// <summary>
        /// The Id of the selected payment method.
        /// </summary>
        [ForeignKey("PaymentMethod")]
        [Required]
        [DisplayName("Payment Method")]
        public int PaymentMethodID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
