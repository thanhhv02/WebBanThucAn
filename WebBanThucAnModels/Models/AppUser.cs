﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanThucAnUser.Models
{
    public class AppUser:IdentityUser
    {
        [Column(TypeName ="nvarchar")]
        [StringLength(400)]
        public string HomeAddress { get; set; }
        [DataType(DataType.Date)]
        public DateTime?  DayOfBirth { get; set; }
    }
}
