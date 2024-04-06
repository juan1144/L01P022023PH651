using System.ComponentModel.DataAnnotations;

namespace L01P022023PH651.Models
{
    public class facultad
    {
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Facultad")]
        public string? facultad_nombre { get; set; }
    }
}
