using ExamNET.Domain.Attributes;
using ExamNET.Domain.Enums;
using ExamNET.Domain.Extensions;
using ExamNET.Domain.Models;
using ExamNET.Domain.Services.Questions;

namespace ExamNET.Domain.Services.Exams
{
    public static class ExamService
    {
        public static ExamModel Construct(Subject subject)
        {
            var exam = new ExamModel(subject);

            var types = GetQuestionTypes(subject);
            //var types = new List<QuestionType>() { QuestionType.PORTUGUESE_DICTATION };

            foreach (var type in types)
            {
                var service = QuestionServiceFactory.Get(type);
                var question = service.Construct(exam.GetNextQuestionNumber());
                exam.AddQuestion(question);
            }

            return exam;
        }

        private static List<QuestionType> GetQuestionTypes(Subject subject)
        {
            var types = new List<QuestionType>();

            foreach (QuestionType type in Enum.GetValues(typeof(QuestionType)))
            {
                var attribute = type.GetAttribute<QuestionAttribute>();

                if (attribute == null)
                    continue;

                if (attribute.Subject == subject)
                    types.Add(type);
            }

            return types;
        }
    }
}
