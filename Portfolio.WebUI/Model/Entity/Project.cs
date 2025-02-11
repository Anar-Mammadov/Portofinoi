﻿using Riode.WebUI.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.Entity
{
    public class Project : BaseEntity
    {
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string cLink { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string ProjectType { get; set; }
        public string Description{ get; set; }





    }
}
