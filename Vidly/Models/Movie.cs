﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name="Genre")]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name="Number In Stock")]
        public byte NumberInStock { get; set; }
    }
}