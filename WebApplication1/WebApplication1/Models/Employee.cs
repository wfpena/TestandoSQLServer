﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblEmployee")]///Attribute/DataAnnotations/Annotations
    public class Employee
    {
        [Key]
        public int Employeeid { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }
}