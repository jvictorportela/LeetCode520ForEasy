namespace LeetCodeSolution.Application.UseCases.LeetCode._520;

public class SolutionDetectCapital : ISolutionDetectCapital
{
    public bool DetectCapitalUse(string word)
    {
        return word.All(char.IsUpper) ||
               word.All(char.IsLower) ||
               (char.IsUpper(word[0]) && word.Skip(1).All(char.IsLower));
    }
}
