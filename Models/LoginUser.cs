using System;
using System.ComponentModel.DataAnnotations;

namespace cinemapandas.Models
{
    public class LoginUser
    {
        [Required (ErrorMessage = "Email is required")]
        [EmailAddress (ErrorMessage = "Please enter a valid Email address")]
        public string LoginEmail { get; set; }

        [Required (ErrorMessage = "Password is required")]
        [MinLength (4, ErrorMessage = "Password must be 4 characters or longer")]
        [DataType ("Password")]
        public string LoginPassword { get; set; }
    }
}