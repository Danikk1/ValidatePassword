using System;
using System.Linq;

namespace ValidatePassword
{
    public class PasswordValidator
    {
        public int ValidatePassword(string password)
        {
            int score = 0;

            if (password.Length <= 10)
            {
                return score;
            }

            if (password.Any(char.IsDigit))
            {
                score++;
            }

            if (password.Any(char.IsLower))
            {
                score++;
            }

            if (password.Any(char.IsUpper))
            {
                score++;
            }

            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                score++;
            }

            score++;  

            return score;
        }
    }
}
