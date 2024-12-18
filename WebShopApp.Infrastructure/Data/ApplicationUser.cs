﻿using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopApp.Infrastructure.Data
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [MaxLength(30)]
        public string FirstName {  get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }


        [Required, MaxLength(50)]
        public string Adress {  get; set; }


    }
}
