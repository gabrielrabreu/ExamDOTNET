using ExamNET.Bogus.Enums;
using System.Globalization;
using System.Text;

namespace ExamNET.Bogus.Models
{
    public class WordModel
    {
        public Locale Locale { get; set; }
        public string Word { get; set; }
        public string Syllables { get; set; }
        public SylablleType SylablleType { get; set; }
        public string? Antonym { get; set; }
        public bool HasConsonantClusters { get; set; }

        public WordModel(Locale locale,
                         string word,
                         string syllables,
                         SylablleType sylablleType,
                         string antonym)
        {
            Locale = locale;
            Word = word;
            Syllables = syllables;
            SylablleType = sylablleType;
            Antonym = antonym;
            SetConsonantClusters();
        }

        public WordModel(Locale locale,
                         string word,
                         string syllables,
                         SylablleType sylablleType)
        {
            Locale = locale;
            Word = word;
            Syllables = syllables;
            SylablleType = sylablleType;
            SetConsonantClusters();
        }

        private void SetConsonantClusters()
        {
            var consonantInSequence = 0;

            for (int i = 0; i < Word.Length; i++)
            {
                var currentLetter = Word[i];

                if (IsConsonant(currentLetter))
                    consonantInSequence++;
                else
                    consonantInSequence = 0;

                if (consonantInSequence > 1)
                    HasConsonantClusters = true;
            }
        }

        public static bool IsConsonant(char c)
        {
            return !IsVowel(c);
        }

        public static bool IsVowel(char c)
        {
            var t = RemoveDiacritics(c.ToString());
            return "aeiou".IndexOf(t.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
        }

        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString.EnumerateRunes())
            {
                var unicodeCategory = Rune.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
