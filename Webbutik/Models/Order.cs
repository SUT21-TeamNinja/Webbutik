using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Webbutik.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? User { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(25)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string Address { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string City { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(5)]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "This field is required.")]


        [StringLength(15)]           
        public string Phone { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(35)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20)]
        public string Country { get; set; }

        [ValidateNever]
        public int? OrderTotal { get; set; }
        [ValidateNever]
        public DateTime OrderDate { get; set; }
        
        //navigation
        [ValidateNever]
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
