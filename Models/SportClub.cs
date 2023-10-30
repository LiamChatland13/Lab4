using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4.Models
{
    public class SportClub
    {
        [Required]
        [Display(Name = "Registration Number")]
        [DatabaseGenerated (DatabaseGeneratedOption.None)]
        public String Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public String Title { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Fee { get; set; }


    }
}
