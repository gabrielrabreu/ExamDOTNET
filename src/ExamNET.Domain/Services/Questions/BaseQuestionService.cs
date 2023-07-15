using ExamNET.Domain.Enums;
using ExamNET.Domain.Extensions;
using ExamNET.Domain.Models;

namespace ExamNET.Domain.Services.Questions
{
    public abstract class BaseQuestionService
    {
        public abstract QuestionType Type { get; }

        private int _number;

        public QuestionModel Construct(int number = 0)
        {
            _number = number;

            var holder = GetHolder();

            var question = new QuestionModel(Type, holder.QuestionHtml, holder.AnswerHtml);

            return question;
        }

        public string GetStatement()
        {
            return $"<p><b>{_number} - {Type.GetDisplayName()}</b></p>";
        }

        public abstract QuestionHolder GetHolder();
    }

    public class QuestionHolder
    {
        public string QuestionHtml { get; set; }
        public string AnswerHtml { get; set; }

        public QuestionHolder(string questionHtml, string answerHtml)
        {
            QuestionHtml = questionHtml;
            AnswerHtml = answerHtml;
        }
    }
}
