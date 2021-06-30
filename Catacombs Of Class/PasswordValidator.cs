using System;
using System.Collections.Generic;
using System.Text;

namespace Catacombs_Of_Class
{
    public static class PasswordValidator
    {
        /*passwords must be:
         * - at least 6 chars long
         * - no more than 13 chars long
         * - at least one uppercase letter
         * - at least one lowercase letter
         * - at least one number
         * - cannot contain capital T or an &         
         */

        public static bool IsValidPassword(string password)
        {
            return ContainsLowerCase(password) &&
                    ContainsUpperCase(password) &&
                    ContainsNumber(password) &&
                    IsValidLength(password) &&
                    !ContainsIllegalCharacters(password);
        }

        public static bool ContainsUpperCase(string password)
        {
            foreach (var character in password)
            {
                if (char.IsUpper(character))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsLowerCase(string password)
        {
            foreach (var character in password)
            {
                if (char.IsLower(character))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ContainsNumber(string password)
        {
            foreach (var character in password)
            {
                if (char.IsNumber(character))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsValidLength(string password) => password.Length >= 6 && password.Length <= 13;
        public static bool ContainsIllegalCharacters(string password)
        {
            foreach (var character in password)
            {
                if (char.Equals(character,'T') || char.Equals(character,'&'))
                {
                    return true;
                }    
            }
            return false;
        }
    }
}
