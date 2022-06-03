﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabBigSchool.Models;
using System.ComponentModel.DataAnnotations;

namespace LabBigSchool.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}