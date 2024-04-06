using System.ComponentModel.DataAnnotations;

namespace L01P022023PH651.Models
{
    public class materias
    {
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Materia")]
        public string? materia { get; set; }

        [Display(Name = "Unidades Valorativas")]
        public int? unidades_valorativas { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
