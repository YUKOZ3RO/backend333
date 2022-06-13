using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace backend333.Controllers.RequestModel.cs;

public class ContactUs
{[Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName{get; set; }
    [EmailAddress(ErrorMessage = "must be specified")]
    public string Email { get; set; }
    [Url]
    public string SocialMedia { get; set; }
}


