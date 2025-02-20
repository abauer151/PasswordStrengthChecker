string pw = "password123!";
Console.WriteLine(PasswordChecker.GetStrengthScore(pw));
Console.WriteLine(PasswordChecker.CheckStrength(pw));

public static class PasswordChecker
{
    public static bool CheckStrength(string password)
    {
        return GetStrengthScore(password) >= 250;
    }

    public static int GetStrengthScore(string password)
    {
        if (password == "password")
            return 0;

        int countLetters = password.Count(char.IsLetter);
        int countDigits = password.Count(char.IsDigit);
        int countSpecialCharacters = password.Count(p => !char.IsLetterOrDigit(p));

        int strengthScore = (password.Length * 10) + (countLetters * 5) + (countDigits * 10) + (countSpecialCharacters * 20);

        if (countLetters >= 3 && countDigits >= 2 && countSpecialCharacters >= 1)
            strengthScore += 100;

        return strengthScore;
    }
}