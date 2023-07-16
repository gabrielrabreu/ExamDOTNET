using ExamNET.Domain.Attributes;
using ExamNET.Resources;
using System.ComponentModel.DataAnnotations;

namespace ExamNET.Domain.Enums
{
    public enum QuestionType
    {
        [Question(Subject.MATHEMATICS)]
        [Display(Name = "MATHEMATICS_DICTATION", ResourceType = typeof(ExamNETResource))]
        MATHEMATICS_DICTATION,

        [Question(Subject.MATHEMATICS)]
        [Display(Name = "MATHEMATICS_PREDECESSOR_SUCCESSOR", ResourceType = typeof(ExamNETResource))]
        MATHEMATICS_PREDECESSOR_SUCCESSOR,

        [Question(Subject.MATHEMATICS)]
        [Display(Name = "MATHEMATICS_WRITE_EXTENSE", ResourceType = typeof(ExamNETResource))]
        MATHEMATICS_WRITE_EXTENSE,

        [Question(Subject.MATHEMATICS)]
        [Display(Name = "MATHEMATICS_WRITE_NUMBER", ResourceType = typeof(ExamNETResource))]
        MATHEMATICS_WRITE_NUMBER,

        [Question(Subject.MATHEMATICS)]
        [Display(Name = "MATHEMATICS_DECOMPOSE", ResourceType = typeof(ExamNETResource))]
        MATHEMATICS_DECOMPOSE,

        [Question(Subject.MATHEMATICS)]
        [Display(Name = "MATHEMATICS_FOUR_OPERATIONS", ResourceType = typeof(ExamNETResource))]
        MATHEMATICS_FOUR_OPERATIONS,

        [Question(Subject.MATHEMATICS)]
        [Display(Name = "MATHEMATICS_LOGIC", ResourceType = typeof(ExamNETResource))]
        MATHEMATICS_LOGIC,

        [Question(Subject.PORTUGUESE)]
        [Display(Name = "PORTUGUESE_DICTATION", ResourceType = typeof(ExamNETResource))]
        PORTUGUESE_DICTATION,

        [Question(Subject.PORTUGUESE)]
        [Display(Name = "PORTUGUESE_CREATE_PHRASES", ResourceType = typeof(ExamNETResource))]
        PORTUGUESE_CREATE_PHRASES,

        [Question(Subject.PORTUGUESE)]
        [Display(Name = "PORTUGUESE_SEPARATE_SYLLABLES", ResourceType = typeof(ExamNETResource))]
        PORTUGUESE_SEPARATE_SYLLABLES,

        [Question(Subject.PORTUGUESE)]
        [Display(Name = "PORTUGUESE_CONSONANT_CLUSTERS", ResourceType = typeof(ExamNETResource))]
        PORTUGUESE_CONSONANT_CLUSTERS,

        [Question(Subject.PORTUGUESE)]
        [Display(Name = "PORTUGUESE_ANTONYMS", ResourceType = typeof(ExamNETResource))]
        PORTUGUESE_ANTONYMS,
    }
}
