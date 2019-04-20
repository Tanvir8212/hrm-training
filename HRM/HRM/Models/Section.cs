using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Section
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Section Code")]
        [StringLength(10)]
        public String SectionCode { get; set; }

        [StringLength(150)]
        [Display(Name = "Section Name")]
        public String SectionName { get; set; }

        public int DeptId { get; set; }
        [ForeignKey("DeptId")]
        public virtual Department Department { get; set; }
    }
}