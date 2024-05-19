using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.DTO
{
    internal class EmployeeDTO
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfBirth { get; set; } = new DateTime(2003, 01, 01);
        public string Address { get; set; }
        public Byte[] Salary { get; set; } = null;
        public string Telephone { get; set; }
        public Byte[] Allowance { get; set; } = null;
        public string GenderId { get; set; }
        public string RoleId { get; set; }
        public string DepartmentId { get; set; }
        public string ManagerId { get; set; }
        public string StatusId { get; set; }
        public string Username { get; set; }
        public Byte[] Password { get; set; } = null;
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
