using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var charArr = input.ToCharArray();
        Array.Reverse(charArr);
        return new String(charArr);
    }
}
