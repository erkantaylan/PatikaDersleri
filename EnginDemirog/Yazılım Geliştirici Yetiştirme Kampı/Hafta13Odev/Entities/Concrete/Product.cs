using System.ComponentModel.DataAnnotations;
using Core.DataAccess.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key] public int ProductId { get; set; }

        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CarId { get; set; }
        public int BrandCategoryId { get; set; }
    }
}