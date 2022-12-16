using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public record EmployeeTitleDTO
    {
        public int TitleId { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeTitleDTO(int titleId, int employeeId)
        {
            this.TitleId = titleId;
            this.EmployeeId = employeeId;
        }
    }
}
