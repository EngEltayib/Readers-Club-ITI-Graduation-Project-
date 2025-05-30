﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadersClubCore.Models
{
    public class Category:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Story> Stories { get; set; } = new List<Story>();

    }
}
