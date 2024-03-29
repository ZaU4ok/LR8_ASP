﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LR8_ASP
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { ID = 1, Name = "Product 1", Price = 10.99m, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Product 2", Price = 20.49m, CreatedDate = DateTime.Now.AddDays(-1) },
            new Product { ID = 3, Name = "Product 3", Price = 15.79m, CreatedDate = DateTime.Now.AddDays(-2) }
        };

            return View(products);
        }
    }
}
