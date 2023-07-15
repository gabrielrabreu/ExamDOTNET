using ExamNET.Bogus.Models;

namespace ExamNET.Bogus
{
    public static class Faker
    {
        public static WordModel Word(bool? hasAntonym = false)
        {
            var random = new Random();
            var words = WordsFactory.PT_BR;

            if (hasAntonym.HasValue && hasAntonym.Value)
                words = words.Where(x => !string.IsNullOrEmpty(x.Antonym)).ToList();

            if (hasAntonym.HasValue && !hasAntonym.Value)
                words = words.Where(x => string.IsNullOrEmpty(x.Antonym)).ToList();

            var index = random.Next(words.Count);
            return words.ElementAt(index);
        }

        public static IEnumerable<WordModel> Words(int amount = 10, bool? hasAntonym = false, bool? hasConsonantCluster = false)
        {
            var random = new Random();
            var words = WordsFactory.PT_BR;

            if (hasAntonym.HasValue && hasAntonym.Value)
                words = words.Where(x => !string.IsNullOrEmpty(x.Antonym)).ToList();

            if (hasAntonym.HasValue && !hasAntonym.Value)
                words = words.Where(x => string.IsNullOrEmpty(x.Antonym)).ToList();

            if (hasConsonantCluster.HasValue && hasConsonantCluster.Value)
                words = words.Where(x => x.HasConsonantClusters).ToList();

            if (hasConsonantCluster.HasValue && !hasConsonantCluster.Value)
                words = words.Where(x => !x.HasConsonantClusters).ToList();

            for (int i = 0; i < amount; i++)
            {
                if (words.Count == 0) break;

                var index = random.Next(words.Count);
                var word = words.ElementAt(index);
                words.RemoveAt(index);
                yield return word;
            }
        }

        public static int Number(int min = 0, int max = 1)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        public static IEnumerable<int> Numbers(int amount = 10, int min = 0, int max = 10)
        {
            for (int i = 0; i < amount; i++)
            {
                var random = new Random();
                yield return random.Next(min, max);
            }
        }
    }
}
