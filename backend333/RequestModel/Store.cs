using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class Store
{
    public Store(string heading) => Heading = heading;

    [Key] public int Id{ get; set; }
    [Required]
    public string Heading { get; set; }
    public string MainText { get; set; }
}