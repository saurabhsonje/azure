﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07_Entity
{
    public class Department
    {
        [Key]
        public int Department_Id { get; set; }

        public string Department_Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
