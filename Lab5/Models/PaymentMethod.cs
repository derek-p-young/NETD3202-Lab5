using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class PaymentMethod
    {
        /// <summary>
        /// An automatically generated Id for each payment method, used as the primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name of the payment method.
        /// </summary>
        [Required]
        [DisplayName("Payment Method Name")]
        public string PaymentMethodName { get; set; }
    }
}
