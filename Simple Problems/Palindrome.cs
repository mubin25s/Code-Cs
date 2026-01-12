using System;
using System.Linq;
public class Palindrome
{
    public static bool IsPalindrome(string input)
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input));

        var cleanedInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        var reversedInput = new string(cleanedInput.Reverse().ToArray());

        return cleanedInput == reversedInput;
    }
}