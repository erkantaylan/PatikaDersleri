using System.ComponentModel.DataAnnotations;
using Core.DataAccess.Entities;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        [Key] public int BrandId { get; set; }

        public string BrandName { get; set; }
    }
}