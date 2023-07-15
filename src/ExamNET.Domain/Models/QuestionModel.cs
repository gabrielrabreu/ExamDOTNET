using ExamNET.Domain.Enums;

namespace ExamNET.Domain.Models
{
    public class QuestionModel
    {
        public QuestionType QuestionType { get; set; }
        public string QuestionHtml { get; set; }
        public string AnswerHtml { get; set; }

        public QuestionModel(QuestionType questionType,
                             string questionHtml,
                             string answerHtml)
        {
            QuestionType = questionType;
            QuestionHtml = questionHtml;
            AnswerHtml = answerHtml;
        }
    }
}
