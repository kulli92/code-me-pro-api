using System.ComponentModel.DataAnnotations;

namespace CodeMe.Pro.Models
{
    public class CourierCharge
    {
        [Key]
        public int Id { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
        public decimal Charge { get; set; }
    }

}