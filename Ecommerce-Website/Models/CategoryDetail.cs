﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_Website.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required (ErrorMessage= "Category Name is Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Minimum 5 and maximum 100 characters are are allowed " , MinimumLength = 3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }

    public class ProductDetail
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Minimum 5 and maximum 100 characters are are allowed ", MinimumLength = 3)]
      

        public string ProductName { get; set; }
        [Required]
        [Range(1,50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

         
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        [Required(ErrorMessage = "Discription is Required")]
        public Nullable<System.DateTime> Description { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        [Required]
        [Range(typeof(decimal), "1","500", ErrorMessage = "Invalid Quantity")]

        public Nullable<int> Quantity { get; set; }
    [Required]
        [Range(typeof(decimal),"1","200000",ErrorMessage = "Invalid Price" )]
        public Nullable<decimal> Price { get; set; }
    public SelectList Categories { get; set; }
    
    }
        
}