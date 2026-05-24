namespace practice_1;

public class Palindrome
{
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return false;
        string original = input.ToLower().Replace(" ", "");
        string reversed = new string(original.Reverse().ToArray());
        Console.WriteLine(original == reversed);
        return original == reversed;
    }
}