# PasswordStrengthChecker

**Description:** The PasswordChecker class contains two methods useful for checking the strength of user passwords: PasswordChecker.CheckStrength() and PasswordChecker.GetStrengthScore(). PasswordChecker.GetStrengthScore() computes a numerical score for the strength of a password (where higher is stronger and lower is weaker) based off the number of letters, digits, and special characters in the password. PasswordChecker.CheckStrength() determines if the password is strong (true) or weak (false) by computing the password's strength score and using a score of 250 as a baseline threshold for a strong password.

**Installation/Usage:** The PasswordChecker can be easily installed by forking this repository and using the directions above to implement it into your program or application. An example usage for this tool is when a user is signing up for your application through making an account, to use PasswordChecker.CheckStrength() to check that they are creating an account with a strong password.

**Limitations:** This tool is designed only to check that passwords follow general password making principles such as containing a mix of letters, digits, and special characters. It does not ensure that the password is entirely secure against motivated malicious parties.

**Responsible Use:** Do not use this tool to ensure that a password is 100% secure. Secure passwords do not contain any identifying information and are not shared across websites, both of which this tool is not capable of checking, among other things. Accept the limitations of this tool and use it responsibly.
