using Company.Data.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace Company.Data.Entities
{
    public class Title : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50)]public string? Name { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
