using ExamNET.Bogus;
using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Mathematics
{
    public class MathematicsDictationQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.MATHEMATICS_DICTATION;

        private const int _AMOUNT = 10;
        private const string _SEPARATOR = ", ";

        public override QuestionHolder GetHolder()
        {
            var numbers = Faker.Numbers(_AMOUNT, 1, 1000).ToList();

            return new QuestionHolder(GetQuestionHtml(),
                                      GetAnswerHtml(numbers));
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

        private string GetAnswerHtml(IEnumerable<int> numbers)
        {
            var answerHtml = new StringBuilder();

            answerHtml.Append(GetStatement());

            answerHtml.Append("<p><u>");
            answerHtml.Append(string.Join(_SEPARATOR, numbers));
            answerHtml.Append("</u></p>");

            return answerHtml.ToString();
        }
    }
}
