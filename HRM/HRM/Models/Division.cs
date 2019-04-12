using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Division
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name="Division Code")]
        public String DivisionCode { get; set; }

        [Display(Name="Division Name")]
        public String Name { get; set; }

        public List<Department> Departments { get; set; }

    }
}