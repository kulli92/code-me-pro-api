using CodeMe.Pro.Models;

namespace CodeMe.Pro.SeedData
{
    public static class CourierChargeSeedData
    {
        public static List<CourierCharge> GetCourierCharges()
        {
            return new List<CourierCharge>
            {
                new()
                {
                    Id = 1,
                    MinWeight = 0,
                    MaxWeight = 200,
                    Charge = 5m
                },
                new()
                {
                    Id = 2,
                    MinWeight = 201,
                    MaxWeight = 500,
                    Charge = 10m
                },
                new()
                {
                    Id = 3,
                    MinWeight = 501,
                    MaxWeight = 1000,
                    Charge = 15m
                },
                new()
                {
                    Id = 4,
                    MinWeight = 1001,
                    MaxWeight = 5000,
                    Charge = 20m
                }
            };
        }
    }
}
