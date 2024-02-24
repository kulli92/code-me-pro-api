namespace CodeMe.Pro.Dto
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int TotalWeight { get; set; }

        public List<PackageDto> Packages { get; set; } = new List<PackageDto>();
    }

    public class PackageDto
    {
        public int PackageId { get; set; }
        public decimal TotalPrice { get; set; }
        public int TotalWeight { get; set; }
        public decimal CourierPrice { get; set; }
        public List<string> ProductNames { get; set; } = new List<string>();
    }
}
