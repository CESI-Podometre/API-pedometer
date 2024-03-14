using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarFitApi.Models.Database;

[Table("Variables")]
public class Variables
{
    [Column("id")]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Column("conversion_money")]
    [MaxLength(255)]
    public string ConversionStepMoney { get; set; } = null!;
}