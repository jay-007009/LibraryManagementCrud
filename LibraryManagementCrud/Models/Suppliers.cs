﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Validations;

namespace LibraryManagementCrud.Models
{
    public class Suppliers
    {
        [Key]
        public int SupplierId { get; set; }

        //[Required(ErrorMessage = "SupplierName is Required")]
        //[RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string SupplierName { get; set; }

        //[Required(ErrorMessage = "SupplierAddress is Required")]
        //[RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string SupplierAddress { get; set; }

        //[Required(ErrorMessage = "SupplierCity is Required")]
        //[RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        public string SupplierCity { get; set; }

        //[Required(ErrorMessage = "SupplierPincode is Required")]
        //[RegularExpression("[0-9]{6}+$", ErrorMessage = ("Only 6 digits are allowed"))]
        public int SupplierPincode { get; set; }

        //[Required(ErrorMessage = "SupplierContact is Required")]
        //[RegularExpression("[0-9]{10}+$", ErrorMessage = ("Only 10 digits are allowed"))]
        public string SupplierContact { get; set; }

      

        //  [Required(ErrorMessage = "SupplierEmail is Required")]
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = ("Email in format"))]
        public string SupplierEmail { get; set; }

       public List<BookDetails> bookdetaillist { get; set; }

        public Suppliers()
        {
            bookdetaillist = new List<BookDetails>();
        }
    }
}
