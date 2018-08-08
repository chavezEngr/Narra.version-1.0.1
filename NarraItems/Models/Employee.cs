using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NarraItems.Models.Employee
{
    [Table("tblEmployee")]
    public class Employee
    {
        private int    employeeId;
        private string firstName;
        private string lastName;
        private string gender;
        private string city;

        public int    EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string City { get => city; set => city = value; }

    }
}