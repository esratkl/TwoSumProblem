using TwoSumProblem;

var twoSum = new TwoSum();  
int[] nums = { 2, 7, 11, 15 };
int target = 9;

var result = twoSum.TwoSumDictionary(nums, target);
Console.WriteLine($"Indisler: [{result[0]}, {result[1]}]");

var result2 = twoSum.TwoSumHashSet(nums, target);
Console.WriteLine($"Indisler (HashSet): [{result2[0]}, {result2[1]}]");
