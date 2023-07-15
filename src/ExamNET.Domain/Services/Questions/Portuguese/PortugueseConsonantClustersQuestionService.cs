using ExamNET.Bogus;
using ExamNET.Bogus.Models;
using ExamNET.Domain.Enums;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Portuguese
{
    public class PortugueseConsonantClustersQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.PORTUGUESE_CONSONANT_CLUSTERS;

        private const int _AMOUNT = 5;
        private const string _SEPARATOR = " - ";

        public override QuestionHolder GetHolder()
        {
            var words = Faker.Words(_AMOUNT, hasConsonantCluster: true).ToList();

            return new QuestionHolder(GetQuestionHtml(words),
                                      GetAnswerHtml(words));
        }

        private string GetQuestionHtml(IEnumerable<WordModel> words)
        {
            var questionHtml = new StringBuilder();

            questionHtml.Append(GetStatement());

            questionHtml.Append($"<p>{string.Join(_SEPARATOR, words.Select(x => x.Word))}</p>");

            return questionHtml.ToString();
        }

        private string GetAnswerHtml(IEnumerable<WordModel> words)
        {
            var answerHtml = new StringBuilder();

            answerHtml.Append(GetStatement());

            answerHtml.Append("<p>");
            foreach (var word in words)
            {
                var wordHtml = new StringBuilder();
                var isBold = -1;

                for (int i = 0; i < word.Word.Length; i++)
                {
                    var currentLetter = word.Word[i];
                    var nextLetter = i + 1 < word.Word.Length ? word.Word[i + 1] : 'a';

                    if (WordModel.IsConsonant(currentLetter) && WordModel.IsConsonant(nextLetter))
                    {
                        wordHtml.Append("<b>");
                        isBold = i;
                    }

                    wordHtml.Append(currentLetter);

                    if (isBold >= 0 && isBold != i)
                    {
                        wordHtml.Append("</b>");
                        isBold = -1;
                    }
                }

                answerHtml.Append(wordHtml);
                answerHtml.Append(_SEPARATOR);
            }
            answerHtml.Append("</p>");

            return answerHtml.ToString();
        }
    }
}
