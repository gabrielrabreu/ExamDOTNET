using ExamNET.Bogus;
using ExamNET.Domain.Enums;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Mathematics
{
    public class MathematicsPredecessorSuccessorQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.MATHEMATICS_PREDECESSOR_SUCCESSOR;

        private const int _AMOUNT = 10;

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
            questionHtml.Append("<th></th>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("</tr>");

            for (int i = 0; i < numbers.Count(); i += 5)
            {
                var number1 = numbers.ElementAt(i);
                var number2 = numbers.ElementAt(i + 1);
                var number3 = numbers.ElementAt(i + 2);
                var number4 = numbers.ElementAt(i + 3);
                var number5 = numbers.ElementAt(i + 4);

                questionHtml.Append("<tr>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append($"<td><b> {number1} </b></td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append("<td>   |   </td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append($"<td><b> {number2} </b></td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append("<td>   |   </td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append($"<td><b> {number3} </b></td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append("<td>   |   </td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append($"<td><b> {number4} </b></td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append("<td>   |   </td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append($"<td><b> {number5} </b></td>");
                questionHtml.Append("<td>_____</td>");
                questionHtml.Append("</tr>");
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
            answerHtml.Append("<th></th>");
            answerHtml.Append("<th></th>");
            answerHtml.Append("<th></th>");
            answerHtml.Append("<th></th>");
            answerHtml.Append("</tr>");

            for (int i = 0; i < numbers.Count(); i += 5)
            {
                var number1 = numbers.ElementAt(i);
                var number2 = numbers.ElementAt(i + 1);
                var number3 = numbers.ElementAt(i + 2);
                var number4 = numbers.ElementAt(i + 3);
                var number5 = numbers.ElementAt(i + 4);

                answerHtml.Append("<tr>");
                answerHtml.Append($"<td>{number1 - 1}</td>");
                answerHtml.Append($"<td><b> {number1} </b></td>");
                answerHtml.Append($"<td>{number1 + 1}</td>");
                answerHtml.Append("<td>   |   </td>");
                answerHtml.Append($"<td>{number2 - 1}</td>");
                answerHtml.Append($"<td><b> {number2} </b></td>");
                answerHtml.Append($"<td>{number2 + 1}</td>");
                answerHtml.Append("<td>   |   </td>");
                answerHtml.Append($"<td>{number3 - 1}</td>");
                answerHtml.Append($"<td><b> {number3} </b></td>");
                answerHtml.Append($"<td>{number3 + 1}</td>");
                answerHtml.Append("<td>   |   </td>");
                answerHtml.Append($"<td>{number4 - 1}</td>");
                answerHtml.Append($"<td><b> {number4} </b></td>");
                answerHtml.Append($"<td>{number4 + 1}</td>");
                answerHtml.Append("<td>   |   </td>");
                answerHtml.Append($"<td>{number5 - 1}</td>");
                answerHtml.Append($"<td><b> {number5} </b></td>");
                answerHtml.Append($"<td>{number5 + 1}</td>");
                answerHtml.Append("</tr>");
            }

            answerHtml.Append("</table>");

            return answerHtml.ToString();
        }
    }
}
