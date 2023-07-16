using ExamNET.Bogus;
using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Mathematics
{
    public class MathematicsDecomposeQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.MATHEMATICS_DECOMPOSE;

        private const int _AMOUNT = 8;

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

            for (int i = 0; i < numbers.Count(); i += 2)
            {
                var number1 = numbers.ElementAt(i);
                var number2 = numbers.ElementAt(i + 1);

                questionHtml.Append("<tr>");
                questionHtml.Append($"<td><b> {number1} </b></td>");
                questionHtml.Append("<td> = </td>");
                questionHtml.Append($"<td>{new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength / 2)}</td>");

                questionHtml.Append("<td>   |   </td>");

                questionHtml.Append($"<td><b> {number2} </b></td>");
                questionHtml.Append("<td> = </td>");
                questionHtml.Append($"<td>{new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength / 2)}</td>");
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

            for (int i = 0; i < numbers.Count(); i += 2)
            {
                var number1 = numbers.ElementAt(i);
                var number2 = numbers.ElementAt(i + 1);

                answerHtml.Append("<tr>");
                answerHtml.Append($"<td><b> {number1} </b></td>");
                answerHtml.Append("<td> = </td>");
                answerHtml.Append($"<td>{GetNumberInCases(number1)}</td>");

                answerHtml.Append("<td>   |   </td>");

                answerHtml.Append($"<td><b> {number2} </b></td>");
                answerHtml.Append("<td> = </td>");
                answerHtml.Append($"<td>{GetNumberInCases(number2)}</td>");
                answerHtml.Append("</tr>");
            }

            answerHtml.Append("</table>");

            return answerHtml.ToString();
        }

        private string GetNumberInCases(int number)
        {
            var numStr = number.ToString();
            var cases = numStr.Length;

            if (cases == 1)
            {
                var n1 = numStr[0];

                var strr = new StringBuilder();
                strr.Append(n1);
                return strr.ToString();
            }
            else if (cases == 2)
            {
                var n1 = numStr[1];
                var n2 = numStr[0];

                var strr = new StringBuilder();

                strr.Append($"{n2}0");
                strr.Append($" + ");

                if (IsGTZero(n1))
                {
                    strr.Append($"{n1}");
                }

                return strr.ToString();
            }
            else if (cases == 3)
            {
                var n1 = numStr[2];
                var n2 = numStr[1];
                var n3 = numStr[0];

                var strr = new StringBuilder();

                strr.Append($"{n3}00");
                strr.Append($" + ");

                if (IsGTZero(n2))
                {
                    strr.Append($"{n2}0");
                    strr.Append($" + ");
                }

                if (IsGTZero(n1))
                {
                    strr.Append($"{n1}");
                }
                return strr.ToString();
            }
            else
            {
                var n1 = numStr[3];
                var n2 = numStr[2];
                var n3 = numStr[1];
                var n4 = numStr[0];

                var strr = new StringBuilder();

                strr.Append($"{n4}000");
                strr.Append($" + ");

                if (IsGTZero(n3))
                {
                    strr.Append($"{n3}00");
                    strr.Append($" + ");
                }

                if (IsGTZero(n2))
                {
                    strr.Append($"{n2}0");
                    strr.Append($" + ");
                }

                if (IsGTZero(n1))
                {
                    strr.Append($"{n1}");
                }
                return strr.ToString();
            }
        }

        private bool IsGTZero(char number)
        {
            if (number == '0') return false;
            return true;
        }
    }
}
