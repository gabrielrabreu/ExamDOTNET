using ExamNET.Bogus;
using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Mathematics
{
    public class MathematicsWriteExtenseQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.MATHEMATICS_WRITE_EXTENSE;

        private const int _AMOUNT = 3;

        public override QuestionHolder GetHolder()
        {
            var numbers = Faker.Numbers(_AMOUNT, 1, 2000).ToList();

            return new QuestionHolder(GetQuestionHtml(numbers),
                                      GetAnswerHtml(numbers));
        }

        private string GetQuestionHtml(IEnumerable<int> numbers)
        {
            var questionHtml = new StringBuilder();

            questionHtml.Append(GetStatement());

            questionHtml.Append("<table>");

            questionHtml.Append("<tr>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("</tr>");

            foreach (var number in numbers)
            {
                var numberHtml = new StringBuilder();

                numberHtml.Append("<tr>");

                numberHtml.Append($"<td><b>{number}</b></td>");

                numberHtml.Append("<td> = </td>");

                numberHtml.Append("<td>");
                numberHtml.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength));
                numberHtml.Append("</td>");

                numberHtml.Append("</tr>");

                questionHtml.Append(numberHtml);
            }

            questionHtml.Append("</table>");

            return questionHtml.ToString();
        }

        private string GetAnswerHtml(IEnumerable<int> numbers)
        {
            var answerHtml = new StringBuilder();

            answerHtml.Append(GetStatement());

            answerHtml.Append("<table>");

            answerHtml.Append("<tr>");
            answerHtml.Append("<th></th>");
            answerHtml.Append("<th></th>");
            answerHtml.Append("<th></th>");
            answerHtml.Append("</tr>");

            foreach (var number in numbers)
            {
                var numberHtml = new StringBuilder();

                numberHtml.Append("<tr>");

                numberHtml.Append($"<td><b>{number}</b></td>");

                numberHtml.Append("<td> = </td>");

                numberHtml.Append("<td>");
                numberHtml.Append("___");
                numberHtml.Append("</td>");

                numberHtml.Append("</tr>");

                answerHtml.Append(numberHtml);
            }

            answerHtml.Append("</table>");

            return answerHtml.ToString();
        }
    }
}
