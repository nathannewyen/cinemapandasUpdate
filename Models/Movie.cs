using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using cinemapandas.Models;

namespace cinemapandas
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required (ErrorMessage = "Title is required")]
        [MinLength (2, ErrorMessage = "Title must be at least 2 characters")]
        public string Title { get; set; }

        [Required (ErrorMessage = "Genre is required")]
        public string Genre { get; set; }

        [Required (ErrorMessage = "Year is required")]
        [Range(1900,2020)]
        public int Year { get; set; }
        public string Description { get; set; }

        [Required (ErrorMessage = "Screen Time is required")]
        // Dont allow past screen time
        public DateTime ScreeningTime { get; set; }
        public int UserId { get; set; }
        public User Organizer { get; set; }
        public List<WatchParty> Guests { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}