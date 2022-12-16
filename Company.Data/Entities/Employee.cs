using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Company.Data.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        [MaxLength(25), Required] public string? FirstName { get; set; }
       [MaxLength(25), Required] public string? LastName { get; set; }
       [Required] public decimal Salary { get; set; }
       [Required] public bool IsUnionMember { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
        public virtual ICollection<Title>? Titles { get; set; }
        public virtual ICollection<Department>? Departments { get; set; }
    }
}
