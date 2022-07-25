using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModel;

public class NewBaseType
{
    [Required]
    public string Question { get; set; }
}

public class Faq : NewBaseType
{
    public Faq(string question) => Question = question;

    [Key] public int Id{ get; set; }
    public string Answer { get; set; }  
    public bool Active { get; set; }  
}
public class FaqActive
{
    [Key] public int Id{ get; set; }

   
}