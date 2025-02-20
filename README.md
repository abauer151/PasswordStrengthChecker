# PasswordStrengthChecker

The PasswordChecker class contains two methods useful for checking the strength of user passwords: PasswordChecker.CheckStrength() and PasswordChecker.GetStrengthScore(). PasswordChecker.GetStrengthScore() computes a numerical score for the strength of a password (where higher is stronger and lower is weaker) based off the number of letters, digits, and special characters in the password. PasswordChecker.CheckStrength() determines if the password is strong (true) or weak (false) by computing the password's strength score and using a score of 250 as a baseline threshold for a strong password.


This tool is made only to check that passwords follow general password rules such as containing a both letters, digits, and special characters. 
