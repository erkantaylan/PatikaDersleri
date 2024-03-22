using System.ComponentModel.DataAnnotations;
using Core.DataAccess.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        [Key] public int CustomerId { get; set; }

        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}