using ExamNET.Bogus;
using ExamNET.Bogus.Models;
using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Portuguese
{
    public class PortugueseDictationQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.PORTUGUESE_DICTATION;

        private const int _AMOUNT = 10;
        private const string _SEPARATOR = ", ";

        public override QuestionHolder GetHolder()
        {
            var words = Faker.Words(_AMOUNT).ToList();

            return new QuestionHolder(GetQuestionHtml(),
                                      GetAnswerHtml(words));
        }

        private string GetQuestionHtml()
        {
            var questionHtml = new StringBuilder();

            questionHtml.Append(GetStatement());

            questionHtml.Append("<p>");
            questionHtml.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength));
            questionHtml.Append("</p>");

            questionHtml.Append("<p>");
            questionHtml.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength));
            questionHtml.Append("</p>");

            questionHtml.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength));

            return questionHtml.ToString();
        }

        private string GetAnswerHtml(IEnumerable<WordModel> words)
        {
            var answerHtml = new StringBuilder();

            answerHtml.Append(GetStatement());

            answerHtml.Append("<p><u>");
            answerHtml.Append(string.Join(_SEPARATOR, words.Select(x => x.Word)));
            answerHtml.Append("</u></p>");

            return answerHtml.ToString();
        }
    }
}
