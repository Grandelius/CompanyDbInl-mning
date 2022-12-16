using Company.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class Department : IEntity
    {
        public int Id { get; set; }
       [MaxLength(50), Required] public string? Name { get; set; }
        public int CompanyId { get; set; }
        public virtual _Company? Company { get; set; }

    }
}
