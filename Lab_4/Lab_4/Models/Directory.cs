using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_4.Models
{
    public class Directory
    {
        public string last_name { get; set; }
        [Key]
        public string phone_number { get; set; }
    }
}