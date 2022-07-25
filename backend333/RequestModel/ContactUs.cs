using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModel;

public class ContactUs {
    public ContactUs(string firstName)
    {
        FirstName = firstName;
    }

    [Key] public int Id{ get; set; }

public string FirstName { get; set; }
    [Required]
    public string LastName{get; set; }
    [EmailAddress(ErrorMessage = "must be specified")]
    public string Email { get; set; }
    [Url]
    public string SocialMedia { get; set; }
}


