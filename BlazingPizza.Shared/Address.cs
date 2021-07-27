﻿using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MaxLength(100)] public string Name { get; set; }

        [Required, MaxLength(100)] public string Line1 { get; set; }

        [Required, MaxLength(100)] public string Line2 { get; set; }

        [Required(ErrorMessage = "Siyaphuma sisithi siyaphi? heh?"), MaxLength(50)]
        public string City { get; set; }

        [Required, MaxLength(20)] public string Region { get; set; }

        [Required, MaxLength(20)] public string PostalCode { get; set; }
    }
}