using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0.01, int.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public double Amount { get; set; }

        [ForeignKey("ExpenseCategory")]
        [Required]
        [DisplayName("Expense Category")]
        public int ExpenseCategoryID { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }

        [ForeignKey("PaymentMethod")]
        [Required]
        [DisplayName("Payment Method")]
        public int PaymentMethodID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
