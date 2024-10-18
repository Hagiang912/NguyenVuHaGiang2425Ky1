using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace NguyenVuHaGiang044NetMVC.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeId {get;set;}
        public string FullName {get;set;}
        public int Age {get;set;}
    }
}