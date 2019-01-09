using System;
using System.Text.RegularExpressions;

public static class Bob
{
    private static bool IsQuestion(string statement)
    {
        return statement.EndsWith("?");
    }

    private static bool IsShouting(string statement)
    {
        var rx = new Regex(@"^[^A-Za-z]+$");
        if (rx.IsMatch(statement)) {
            return false;
        }

        return statement == statement.ToUpper();
    }

    public static string Response(string statement)
    {
        // Remove leading and trailing whitespace
        statement = statement.Trim();

        // Silence...
        if (statement == "") {
            return "Fine. Be that way!";
        }

        // Asking a question
        if (IsQuestion(statement)) {
            // The question is being yelled.
            if (IsShouting(statement)) {
                return "Calm down, I know what I'm doing!";
            }
            return "Sure.";
        }

        // Yelling
        if (IsShouting(statement)) {
            return "Whoa, chill out!";
        }

        // Default response
        return "Whatever.";
    }
}
