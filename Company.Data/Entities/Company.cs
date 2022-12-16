using Company.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Company.Data.Entities
{
    public class _Company : IEntity
    {
        public int Id { get; set; }
       [MaxLength(25), Required] public string? Name { get; set; }
       [MaxLength(15), Required] public string? OrganisationNumber { get; set; }
    }
}
