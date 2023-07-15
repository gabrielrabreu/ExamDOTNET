using ExamNET.Domain.Enums;

namespace ExamNET.Domain.Attributes
{
    public class QuestionAttribute : Attribute
    {
        public Subject Subject { get; }

        public QuestionAttribute(Subject subject)
        {
            Subject = subject;
        }
    }
}
