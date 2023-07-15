using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using ExamNET.Resources;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Portuguese
{
    public class PortugueseCreatePhraseQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.PORTUGUESE_CREATE_PHRASES;

        public override QuestionHolder GetHolder()
        {
            return new QuestionHolder(GetQuestionHtml(),
                                      GetAnswerHtml());
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

        private string GetAnswerHtml()
        {
            var answerHtml = new StringBuilder();

            answerHtml.Append(GetStatement());

            answerHtml.Append("<p><u>");
            answerHtml.Append(ExamNETResource.PersonalResponse);
            answerHtml.Append("</u></p>");

            return answerHtml.ToString();
        }
    }
}
