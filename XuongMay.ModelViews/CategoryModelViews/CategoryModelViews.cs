﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace XuongMay.ModelViews.CategoryModelViews
{
    public class CategoryModelViews
    {
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
