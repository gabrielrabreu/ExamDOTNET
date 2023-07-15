using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using ExamNET.Domain.Extensions;
using ExamNET.Resources;
using System.Text;

namespace ExamNET.Domain.Models
{
    public class ExamModel
    {
        public Subject Subject { get; set; }
        public List<QuestionModel> Questions { get; set; } = new List<QuestionModel>();

        public ExamModel(Subject subject)
        {
            Subject = subject;
        }

        public void AddQuestion(QuestionModel question)
        {
            Questions.Add(question);
        }

        public int GetNextQuestionNumber()
        {
            return Questions.Count + 1;
        }

        public string GetExamHtml(bool withAnswers)
        {
            // Headers
            var localAndDate = new StringBuilder();
            localAndDate.Append("<p>");
            localAndDate.Append("Blumenau, ");
            localAndDate.Append(new string(MyConstants.PdfEmptyChar, 4));
            localAndDate.Append('/');
            localAndDate.Append(new string(MyConstants.PdfEmptyChar, 4));
            localAndDate.Append('/');
            localAndDate.Append(new string(MyConstants.PdfEmptyChar, 4));
            localAndDate.Append("</p>");

            var studentName = new StringBuilder();
            studentName.Append("<p>");
            studentName.Append($"{ExamNETResource.Student}: ");
            studentName.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength - studentName.Length));
            studentName.Append("</p>");

            var professorName = new StringBuilder();
            professorName.Append("<p>");
            professorName.Append($"{ExamNETResource.Professor}: ");
            professorName.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength - professorName.Length));
            professorName.Append("</p>");

            var examName = new StringBuilder();
            examName.Append("<center><p><b>");
            examName.Append(Subject.GetDisplayName());
            examName.Append("</b></p></center>");

            var header = new StringBuilder()
                .Append(localAndDate)
                .Append(studentName)
                .Append(professorName)
                .Append(examName);

            // Questions
            var body = new StringBuilder();
            foreach (var question in Questions)
            {
                body.Append(withAnswers == true ? question.AnswerHtml : question.QuestionHtml);
            }

            // Footer
            var footer = new StringBuilder()
                .Append("<center><p>")
                .Append(ExamNETResource.GoodLuck)
                .Append("</p></center>");

            return new StringBuilder()
                .Append("<pre>")
                .Append(header)
                .Append(body)
                .Append(footer)
                .Append("</pre>")
                .ToString();
        }
    }
}
