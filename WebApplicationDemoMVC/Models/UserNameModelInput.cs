using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemoMVC.Models
{
    public class UserNameModelInput
    {
        public int Id { get; set; } = 10;

        [Required(ErrorMessage ="Tên không được trống")]
        [StringLength(100)]
        public string Name { get; set; }


    }
}