using ExamNET.Resources;
using System.ComponentModel.DataAnnotations;

namespace ExamNET.Domain.Enums
{
    public enum Subject
    {
        [Display(Name = "MATHEMATICS", ResourceType = typeof(ExamNETResource))]
        MATHEMATICS,

        [Display(Name = "PORTUGUESE", ResourceType = typeof(ExamNETResource))]
        PORTUGUESE
    }
}
