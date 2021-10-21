using System.ComponentModel.DataAnnotations;

namespace p20_blazorcrud.Data {
    public class Employee {
        [Key]
        public int Id {get; set;} 
        public string EmployeeName {get; set;}
        public string Gender {get; set;}
        public string City {get; set;}
        public string Designation {get; set;}
    }
}