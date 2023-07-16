using ExamNET.Bogus;
using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Mathematics
{
    public class MathematicsFourOperationsQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.MATHEMATICS_FOUR_OPERATIONS;

        private Dictionary<int, int> _forAdd = new Dictionary<int, int>();
        private Dictionary<int, int> _forSub = new Dictionary<int, int>();
        private Dictionary<int, int> _forMul = new Dictionary<int, int>();
        private Dictionary<int, int> _forDiv = new Dictionary<int, int>();

        public override QuestionHolder GetHolder()
        {
            _forAdd.Add(Faker.Number(1000, 5000), Faker.Number(1000, 5000));
            _forAdd.Add(Faker.Number(1000, 5000), Faker.Number(1000, 5000));

            _forSub.Add(Faker.Number(4000, 5000), Faker.Number(1000, 4000));
            _forSub.Add(Faker.Number(4000, 5000), Faker.Number(1000, 4000));

            _forMul.Add(Faker.Number(100, 5000), Faker.Number(2, 3));
            _forMul.Add(Faker.Number(100, 5000), Faker.Number(2, 3));

            _forDiv.Add(Faker.Number(100, 1000), Faker.Number(2, 3));
            _forDiv.Add(Faker.Number(100, 1000), Faker.Number(2, 3));

            return new QuestionHolder(GetQuestionHtml(),
                                      GetAnswerHtml());
        }

        private string GetQuestionHtml()
        {
            var questionHtml = new StringBuilder();

            questionHtml.Append(GetStatement());

            questionHtml.Append("<table>");

            questionHtml.Append("<tr>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("<th></th>");
            questionHtml.Append("</tr>");

            foreach (var addKey in _forAdd)
            {
                var n1 = addKey.Key;
                var n2 = addKey.Value;

                questionHtml.Append("<tr>");
                questionHtml.Append($"<td><b>{n1}+{n2}</b></td>");
                questionHtml.Append("<td> = </td>");
                questionHtml.Append($"<td>{new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength)}</td>");
                questionHtml.Append("</tr>");

                questionHtml.Append("<tr>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("</tr>");
            }

            questionHtml.Append("<tr>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("</tr>");

            foreach (var subKey in _forSub)
            {
                var n1 = subKey.Key;
                var n2 = subKey.Value;

                questionHtml.Append("<tr>");
                questionHtml.Append($"<td><b>{n1}-{n2}</b></td>");
                questionHtml.Append("<td> = </td>");
                questionHtml.Append($"<td>{new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength)}</td>");
                questionHtml.Append("</tr>");

                questionHtml.Append("<tr>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("</tr>");
            }

            questionHtml.Append("<tr>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("</tr>");

            foreach (var mulKey in _forMul)
            {
                var n1 = mulKey.Key;
                var n2 = mulKey.Value;

                questionHtml.Append("<tr>");
                questionHtml.Append($"<td><b>{n1}x{n2}</b></td>");
                questionHtml.Append("<td> = </td>");
                questionHtml.Append($"<td>{new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength)}</td>");
                questionHtml.Append("</tr>");

                questionHtml.Append("<tr>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("</tr>");
            }

            questionHtml.Append("<tr>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("<td></td>");
            questionHtml.Append("</tr>");

            foreach (var divKey in _forDiv)
            {
                var n1 = divKey.Key;
                var n2 = divKey.Value;

                questionHtml.Append("<tr>");
                questionHtml.Append($"<td><b>{n1}:{n2}</b></td>");
                questionHtml.Append("<td> = </td>");
                questionHtml.Append($"<td>{new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength)}</td>");
                questionHtml.Append("</tr>");

                questionHtml.Append("<tr>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("<td></td>");
                questionHtml.Append("</tr>");
            }

            questionHtml.Append("</table>");

            return questionHtml.ToString();
        }

        private string GetAnswerHtml()
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
            answerHtml.Append("</tr>");

            foreach (var addKey in _forAdd)
            {
                var n1 = addKey.Key;
                var n2 = addKey.Value;

                answerHtml.Append("<tr>");
                answerHtml.Append($"<td><b>{n1}+{n2}</b></td>");
                answerHtml.Append("<td> = </td>");
                answerHtml.Append($"<td>{n1 + n2}</td>");
                answerHtml.Append("</tr>");

                answerHtml.Append("<tr>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("</tr>");
            }

            answerHtml.Append("<tr>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("</tr>");

            foreach (var subKey in _forSub)
            {
                var n1 = subKey.Key;
                var n2 = subKey.Value;

                answerHtml.Append("<tr>");
                answerHtml.Append($"<td><b>{n1}-{n2}</b></td>");
                answerHtml.Append("<td> = </td>");
                answerHtml.Append($"<td>{n1 - n2}</td>");
                answerHtml.Append("</tr>");

                answerHtml.Append("<tr>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("</tr>");
            }

            answerHtml.Append("<tr>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("</tr>");

            foreach (var mulKey in _forMul)
            {
                var n1 = mulKey.Key;
                var n2 = mulKey.Value;

                answerHtml.Append("<tr>");
                answerHtml.Append($"<td><b>{n1}x{n2}</b></td>");
                answerHtml.Append("<td> = </td>");
                answerHtml.Append($"<td>{n1 * n2}</td>");
                answerHtml.Append("</tr>");

                answerHtml.Append("<tr>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("</tr>");
            }

            answerHtml.Append("<tr>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("<td></td>");
            answerHtml.Append("</tr>");

            foreach (var divKey in _forDiv)
            {
                var n1 = divKey.Key;
                var n2 = divKey.Value;

                answerHtml.Append("<tr>");
                answerHtml.Append($"<td><b>{n1}:{n2}</b></td>");
                answerHtml.Append("<td> = </td>");
                answerHtml.Append($"<td>{n1 / n2}</td>");
                answerHtml.Append("</tr>");

                answerHtml.Append("<tr>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("<td></td>");
                answerHtml.Append("</tr>");
            }

            answerHtml.Append("</table>");

            return answerHtml.ToString();
        }
    }
}
