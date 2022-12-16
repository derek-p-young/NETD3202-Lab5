using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class PaymentMethod
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Payment Method Name")]
        public string PaymentMethodName { get; set; }
    }
}
