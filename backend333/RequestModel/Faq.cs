using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModel;

public class Faq {
    [Key] public int Id{ get; set; }
    [Required]
    public string Question { get; set; }  
    public string Answer { get; set; }  
    public bool Active { get; set; }  
}
public class FaqActive
{
    [Key] public int Id{ get; set; }

   
}