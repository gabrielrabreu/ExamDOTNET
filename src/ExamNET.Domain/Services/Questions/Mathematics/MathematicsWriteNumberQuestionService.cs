using ExamNET.Bogus;
using ExamNET.Domain.Constants;
using ExamNET.Domain.Enums;
using ExamNET.Resources;
using System.Text;

namespace ExamNET.Domain.Services.Questions.Mathematics
{
    public class MathematicsWriteNumberQuestionService : BaseQuestionService
    {
        public override QuestionType Type => QuestionType.MATHEMATICS_WRITE_NUMBER;

        private const int _AMOUNT = 3;

        public override QuestionHolder GetHolder()
        {
            var numbers = Faker.Numbers(_AMOUNT, 1, 2000).ToList();

            return new QuestionHolder(GetQuestionHtml(numbers),
                                      GetAnswerHtml(numbers));
        }

        private string GetQuestionHtml(IEnumerable<int> numbers)
        {
            var questionHtml = new StringBuilder();

            var maxLength = numbers.Max(n => n.ToString().Length);
            questionHtml.Append(GetStatement());

            foreach (var number in numbers)
            {
                var numberHtml = new StringBuilder();
                numberHtml.Append("<p>");
                numberHtml.Append(GetNumberInCases(number));
                numberHtml.Append(new string(MyConstants.PdfSpaceChar, maxLength + 1 - number.ToString().Length));
                numberHtml.Append("= ");

                numberHtml.Append(new string(MyConstants.PdfEmptyChar, MyConstants.PdfLineMaxLength));

                numberHtml.Append("</p>");

                questionHtml.Append(numberHtml);
            }

            return questionHtml.ToString();
        }

        private string GetAnswerHtml(IEnumerable<int> numbers)
        {
            var answerHtml = new StringBuilder();

            var maxLength = numbers.Max(n => n.ToString().Length);
            answerHtml.Append(GetStatement());

            foreach (var number in numbers)
            {
                var numberHtml = new StringBuilder();
                numberHtml.Append("<p>");
                numberHtml.Append(GetNumberInCases(number));
                numberHtml.Append(new string(MyConstants.PdfSpaceChar, maxLength + 1 - number.ToString().Length));
                numberHtml.Append("= ");

                numberHtml.Append($"<u>{number}</u>");

                numberHtml.Append("</p>");

                answerHtml.Append(numberHtml);
            }

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

                var ext = IsGTOne(n1) ? ExamNETResource.Units : ExamNETResource.Unit;
                strr.Append($"{GetNumberInExtense(n1)} {ext}");

                return strr.ToString();
            }
            else if (cases == 2)
            {
                var n1 = numStr[1];
                var n2 = numStr[0];

                var strr = new StringBuilder();

                if (IsGTZero(n2))
                {
                    var ext = IsGTOne(n2) ? ExamNETResource.Tens : ExamNETResource.Ten;
                    strr.Append($"{GetNumberInExtense(n2)} {ext}");
                    strr.Append($" {ExamNETResource.And} ");
                }

                if (IsGTZero(n1))
                {
                    var ext = IsGTOne(n1) ? ExamNETResource.Units : ExamNETResource.Unit;
                    strr.Append($"{GetNumberInExtense(n1)} {ext}");
                }
                return strr.ToString();
            }
            else if (cases == 3)
            {
                var n1 = numStr[2];
                var n2 = numStr[1];
                var n3 = numStr[0];

                var strr = new StringBuilder();

                if (IsGTZero(n3))
                {
                    var ext = IsGTOne(n3) ? ExamNETResource.Hundreds : ExamNETResource.Hundred;
                    strr.Append($"{GetNumberInExtense(n3)} {ext}");
                    strr.Append($" {ExamNETResource.And} ");
                }

                if (IsGTZero(n2))
                {
                    var ext = IsGTOne(n2) ? ExamNETResource.Tens : ExamNETResource.Ten;
                    strr.Append($"{GetNumberInExtense(n2)} {ext}");
                    strr.Append($" {ExamNETResource.And} ");
                }

                if (IsGTZero(n1))
                {
                    var ext = IsGTOne(n1) ? ExamNETResource.Units : ExamNETResource.Unit;
                    strr.Append($"{GetNumberInExtense(n1)} {ext}");
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

                if (IsGTZero(n4))
                {
                    var ext = IsGTOne(n4) ? ExamNETResource.Thousands : ExamNETResource.Thousand;
                    strr.Append($"{GetNumberInExtense(n4, true)} {ext}");
                    strr.Append($" {ExamNETResource.And} ");
                }

                if (IsGTZero(n3))
                {
                    var ext = IsGTOne(n3) ? ExamNETResource.Hundreds : ExamNETResource.Hundred;
                    strr.Append($"{GetNumberInExtense(n3)} {ext}");
                    strr.Append($" {ExamNETResource.And} ");
                }

                if (IsGTZero(n2))
                {
                    var ext = IsGTOne(n2) ? ExamNETResource.Tens : ExamNETResource.Ten;
                    strr.Append($"{GetNumberInExtense(n2)} {ext}");
                    strr.Append($" {ExamNETResource.And} ");
                }

                if (IsGTZero(n1))
                {
                    var ext = IsGTOne(n1) ? ExamNETResource.Units : ExamNETResource.Unit;
                    strr.Append($"{GetNumberInExtense(n1)} {ext}");
                }
                return strr.ToString();
            }
        }

        private bool IsGTZero(char number)
        {
            if (number == '0') return false;
            return true;
        }

        private bool IsGTOne(char number)
        {
            if (number == '0') return false;
            if (number == '1') return false;
            return true;
        }

        private string GetNumberInExtense(char number, bool? isThousands = false)
        {
            if (number == '1' && isThousands.HasValue && isThousands == true) return ExamNETResource.OneThousand;
            if (number == '2' && isThousands.HasValue && isThousands == true) return ExamNETResource.TwoThousand;

            if (number == '1') return ExamNETResource.One;
            if (number == '2') return ExamNETResource.Two;
            if (number == '3') return ExamNETResource.Three;
            if (number == '4') return ExamNETResource.Four;
            if (number == '5') return ExamNETResource.Five;
            if (number == '6') return ExamNETResource.Six;
            if (number == '7') return ExamNETResource.Seven;
            if (number == '8') return ExamNETResource.Eight;
            if (number == '9') return ExamNETResource.Nine;
            return "";
        }
    }
}
