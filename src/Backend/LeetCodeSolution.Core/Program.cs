using LeetCodeSolution.Application.UseCases.LeetCode._520;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddScoped<ISolutionDetectCapital, SolutionDetectCapital>();

using var serviceProvider = services.BuildServiceProvider();

var solution = serviceProvider.GetRequiredService<ISolutionDetectCapital>();

Console.WriteLine(solution.DetectCapitalUse("USA"));    // true
Console.WriteLine(solution.DetectCapitalUse("leetcode")); // true
Console.WriteLine(solution.DetectCapitalUse("Google")); // true
Console.WriteLine(solution.DetectCapitalUse("FlaG"));   // false