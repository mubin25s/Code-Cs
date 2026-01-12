using System;
using System.Linq;
public class Palindrome
{
    public static bool IsPalindrome(string input)
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input));

