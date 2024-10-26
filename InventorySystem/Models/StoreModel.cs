using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models;

public class StoreModel
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    [Display(Name = "Name")]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(100)]
    [Display(Name = "Description")]
    public string? Description { get; set; }
    
    [Required]
    public bool Status { get; set; }
}