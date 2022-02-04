using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TimeSheetManagement.Entity.Models
{
     public class Manager
    {
        [Key]
        public int MgrID { get; set; }
        public string MgrName { get; set; }
        public string MgrEmaiID { get; set; }
        public string MgrPhone { get; set; }
        public string MgrUserName { get; set; }
        public string MgrPsw { get; set; }
        public string MgrDOJ { get; set; }
    }
}
