﻿using Ecommerce_Website.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_Website.Models.Home
{
    public class Item
    {
        public Tbl_Product Product { get; set; }
        public int Quantity { get; set; }
    }
}