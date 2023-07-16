using ExamNET.Bogus;
using ExamNET.Bogus.Models;
using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using ExamNET.Domain.Extensions;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Portuguese
{
    public class PortugueseSeparateSyllablesQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.PORTUGUESE_SEPARATE_SYLLABLES;

        private const int _AMOUNT = 5;

        public override QuestionHolder GetHolder()
        {
            var words = Faker.Words(_AMOUNT).ToList();

            return new QuestionHolder(GetQuestionHtml(words),
                                      GetAnswerHtml(words));
        }

        private string GetQuestionHtml(IEnumerable<WordModel> words)
        {
            var questionHtml = new StringBuilder();

            var maxLength = words.Max(word => word.Word.Length);
            questionHtml.Append(GetStatement());

            foreach (var word in words)
            {
                var wordHtml = new StringBuilder();
                wordHtml.Append("<p>");
                wordHtml.Append("<b>");
                wordHtml.Append(word.Word);
                wordHtml.Append(new string(MyConstants.PdfSpaceChar, maxLength + 1 - word.Word.Length));
                wordHtml.Append("= ");
                wordHtml.Append("</b>");

                wordHtml.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength - wordHtml.Length));

                wordHtml.Append("</p>");

                questionHtml.Append(wordHtml);
            }

            return questionHtml.ToString();
        }

        private string GetAnswerHtml(IEnumerable<WordModel> words)
        {
            var answerHtml = new StringBuilder();

            var maxLength = words.Max(word => word.Word.Length);
            answerHtml.Append(GetStatement());

            foreach (var word in words)
            {
                var wordHtml = new StringBuilder();
                wordHtml.Append("<p>");
                wordHtml.Append("<b>");
                wordHtml.Append(word.Word);
                wordHtml.Append(new string(MyConstants.PdfSpaceChar, maxLength + 1 - word.Word.Length));
                wordHtml.Append("= ");
                wordHtml.Append("</b>");

                wordHtml.Append($"<u>{word.Syllables} | {word.SylablleType.GetDisplayName()}</u>");

                wordHtml.Append("</p>");

                answerHtml.Append(wordHtml);
            }

            return answerHtml.ToString();
        }
    }
}
