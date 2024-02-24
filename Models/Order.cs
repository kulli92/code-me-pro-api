using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeMe.Pro.Models
{
[Table("Orders")]
public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderId { get; set; }

    [Required]
    public DateTime OrderDate { get; set; } = DateTime.Now;

    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Package> Packages { get; set; } = new List<Package>();

    [NotMapped] // Not storing this in the database directly; calculated on the fly or handled via business logic
    public decimal TotalPrice { get; set; }

    [NotMapped] 
    public int TotalWeight { get; set; }
}

}
