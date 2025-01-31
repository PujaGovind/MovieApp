using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAppWeb.Models;

public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    
    [DisplayName ("Display Order")]
    public int DisplayOrder { get; set; }

    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}