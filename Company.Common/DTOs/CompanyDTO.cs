using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record CompanyDTO
    {
        public int Id { get; set; }
        [MaxLength(25), Required] public string? Name { get; set; }
        [MaxLength(15), Required] public string? OrganisationNumber { get; set; }
    }
}
