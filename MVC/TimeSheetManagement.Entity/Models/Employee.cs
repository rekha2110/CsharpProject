using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TimeSheetManagement.Entity.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpEmailID { get; set; }
        public string EmpPhone { get; set; }
        public string EmpUserName { get; set; }
        public string EmpPsw { get; set; }
        public string EmpDOJ { get; set; }
        public Manager manager { get; set; }
        [ForeignKey("manager")]
        public int MgrID { get; set; }
        public Project project { get; set; }
        [ForeignKey("project")]
        public int ProjectID { get; set; }
        
        
    }
}
