using System.ComponentModel.DataAnnotations;
using Core.DataAccess.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        [Key] public int CarId { get; set; }

        public string CarName { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}