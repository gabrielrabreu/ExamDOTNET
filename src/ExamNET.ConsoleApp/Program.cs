using ExamNET.Bogus;
using ExamNET.Bogus.Enums;
using ExamNET.ConsoleApp.Exporters;
using ExamNET.Domain.Enums;
using ExamNET.Domain.Services.Exams;

WordsFactory.Initialize(Locale.PT_BR);

var portuguese = ExamService.Construct(Subject.PORTUGUESE);

Console.WriteLine("Exporting...");

ExamExporter.ExportToPath(portuguese);

Console.WriteLine("Exported...");

Console.ReadKey();