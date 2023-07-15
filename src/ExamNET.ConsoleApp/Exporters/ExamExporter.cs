using ExamNET.Domain.Models;

namespace ExamNET.ConsoleApp.Exporters
{
    public static class ExamExporter
    {
        private static readonly string PATH = "C:\\Development\\Projects\\personal\\ExamDOTNET\\.exams";

        public static void ExportToPath(ExamModel examDomain)
        {
            var folder = $"{PATH}//{DateTime.Now:yyyyMMddHHmmss}";
            Directory.CreateDirectory(folder);

            var examFilename = $"{folder}/exam.pdf";
            var answersFilename = $"{folder}/answers.pdf";

            var exam = examDomain.GetExamHtml(false);
            var answers = examDomain.GetExamHtml(true);

            SaveHtmlAsPdf(exam, examFilename);
            SaveHtmlAsPdf(answers, answersFilename);
        }

        private static void SaveHtmlAsPdf(string body, string filename)
        {
            var pdfRenderer = new ChromePdfRenderer();
            var pdfDocument = pdfRenderer.RenderHtmlAsPdf(body);
            pdfDocument.SaveAs(filename);
        }
    }
}
