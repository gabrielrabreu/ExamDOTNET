using ExamNET.Bogus;
using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using ExamNET.Resources;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Mathematics
{
    public class MathematicsLogicQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.MATHEMATICS_LOGIC;

        private Dictionary<int, int> _for = new Dictionary<int, int>();

        public override QuestionHolder GetHolder()
        {
            _for.Add(Faker.Number(5, 100), Faker.Number(2, 3));
            _for.Add(Faker.Number(2, 3), Faker.Number(5, 100));

            return new QuestionHolder(GetQuestionHtml(),
                                      GetAnswerHtml());
        }

        private string GetQuestionHtml()
        {
            var questionHtml = new StringBuilder();

            questionHtml.Append(GetStatement());

            var _index = 0;

            foreach (var key in _for)
            {
                var n1 = key.Key;
                var n2 = key.Value;

                questionHtml.Append("<p>");

                if (_index % 2 == 0)
                    questionHtml.Append(string.Format(ExamNETResource.SimpleTextDiv, n1, n2));
                else
                    questionHtml.Append(string.Format(ExamNETResource.SimpleTextMult, n1, n2));

                questionHtml.Append("</p>");

                questionHtml.Append("<p>");
                questionHtml.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength));
                questionHtml.Append("</p>");

                _index++;
            }

            return questionHtml.ToString();
        }

        private string GetAnswerHtml()
        {
            var answerHtml = new StringBuilder();

            answerHtml.Append(GetStatement());

            var _index = 0;

            foreach (var key in _for)
            {
                var n1 = key.Key;
                var n2 = key.Value;
                var result = 0;

                answerHtml.Append("<p>");

                if (_index % 2 == 0)
                {
                    answerHtml.Append(string.Format(ExamNETResource.SimpleTextDiv, n1, n2));
                    result = n1 / (n2 + 1);

                }
                else
                {
                    answerHtml.Append(string.Format(ExamNETResource.SimpleTextMult, n1, n2));
                    result = n1 * n2;
                }

                answerHtml.Append("</p>");

                answerHtml.Append("<p>");
                answerHtml.Append(result);
                answerHtml.Append("</p>");

                _index++;
            }

            return answerHtml.ToString();
        }
    }
}
