﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedtoNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        [Display(Name ="Membershpi Type")]
        public byte MembershipTypeId { get; set; }
        [Display(Name="Date of Birth")]
        public DateTime? BirthDate { get; set; }

    }
}