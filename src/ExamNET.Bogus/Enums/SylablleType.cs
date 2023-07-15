using ExamNET.Resources;
using System.ComponentModel.DataAnnotations;

namespace ExamNET.Bogus.Enums
{
    public enum SylablleType
    {
        [Display(Name = "MONOSYLABLLE", ResourceType = typeof(ExamNETResource))]
        Mono,

        [Display(Name = "DISYLABLLE", ResourceType = typeof(ExamNETResource))]
        Di,

        [Display(Name = "TRISYLABLLE", ResourceType = typeof(ExamNETResource))]
        Tri,

        [Display(Name = "POLYSYLABLLE", ResourceType = typeof(ExamNETResource))]
        Poly
    }
}
