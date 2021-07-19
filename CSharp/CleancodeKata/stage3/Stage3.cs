namespace CleancodeKata.stage3
{
    /**
     * Remove all the code duplications.
     */
    public static class Stage3
    {
        public static string DoTheThing(string input)
        {
            var prefix = input.Length % 2 == 0 ? "even" : "odd";
            var dummy = input.Length < 10 ? "short" : "long";

            return $"{dummy}_{prefix}_{LowercaseVowels(input)}";
        }

        private static string LowercaseVowels(string input)
        {
            return input.Replace('A', 'a')
                .Replace('E', 'e')
                .Replace('I', 'i')
                .Replace('O', 'o')
                .Replace('U', 'u')
                .Replace('Y', 'y');
        }
    }
}