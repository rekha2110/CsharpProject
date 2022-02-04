using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TutorialCoreApp.Models
{
    public class Tutorial
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr  { get; set; }
        public int Published { get; set; }
    }
}
