using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodeMe.Pro.Models
{
    [Table("Packages")]
    public class Package
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PackageId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        public int TotalWeight { get; set; }

        [NotMapped]
        public decimal CourierPrice { get; set; } // This could be a calculated

        public List<PackageDetail> PackageDetails { get; set; } = new List<PackageDetail>();
    }
}
