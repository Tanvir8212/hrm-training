using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Employee Code")]
        public String EmployeeCode { get; set; }

        [Display(Name = "Full Name")]
        public String FullName { get; set; }

        [Display(Name = "Father Name")]
        public String FatherName { get; set; }

        [Display(Name = "Mother Name")]
        public String MotherName { get; set; }

        [Display(Name = "Nick Name")]
        public String NickName { get; set; }

        public int DesignationId { get; set; }

        [ForeignKey("DesignationId")]
        public virtual Designation Designations { get; set; }
    }
}