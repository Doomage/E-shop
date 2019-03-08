﻿using E_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_shop.Viewmodels
{
    public class HomeViewModel
    {

        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}