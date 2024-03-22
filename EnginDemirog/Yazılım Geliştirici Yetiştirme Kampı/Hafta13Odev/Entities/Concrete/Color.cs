using System.ComponentModel.DataAnnotations;
using Core.DataAccess.Entities;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        [Key] public int ColorId { get; set; }

        public string ColorName { get; set; }
    }
}