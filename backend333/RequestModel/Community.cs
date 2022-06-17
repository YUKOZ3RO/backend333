using System.ComponentModel.DataAnnotations;
namespace backend333.RequestModel;

public class Community
{
 [Key] public int Id{ get; set; }
 [Required]
 public string Question { get; set; }   
 public bool Active { get; set; }  
 public int Count { get; set; }  
 public string Comment { get; set; }  
}
public class CommunityActive
{
 [Key] public int Id{ get; set; }

 
}