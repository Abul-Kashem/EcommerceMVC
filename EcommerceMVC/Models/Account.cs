﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int Id
        {
            get;set;
        }
        public string UserName
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }
        public string FullName
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public bool Status
        {
            get; set;
        }
       
    }
}
