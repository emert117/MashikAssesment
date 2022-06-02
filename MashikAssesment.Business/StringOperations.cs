using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashikAssesment.Business
{
    public static class StringOperations
    {
        public static bool ValidateParentheses(string textToValidate)
        {
            if (string.IsNullOrEmpty(textToValidate) || string.IsNullOrWhiteSpace(textToValidate))
                throw new Exception("Invalid input");

            if (textToValidate.IndexOf('(') < 0 && textToValidate.IndexOf(')') < 0)
                return true; // there is no parentheses pair to validate

            if (textToValidate.IndexOf('(') < 0 || textToValidate.IndexOf(')') < 0)
                return false; // textToValidate doesn't contain any opening or closing parenthesis

            bool haveAnOpeningParenthesisBeforeClosingParenthesis = textToValidate.IndexOf('(') > textToValidate.IndexOf(')');
            if (haveAnOpeningParenthesisBeforeClosingParenthesis)
                return false;

            int numberOfClosingParenthesisWeNeed = 0;
            foreach (var c in textToValidate)
            {
                if (c == '(')
                    numberOfClosingParenthesisWeNeed++;

                if (c == ')')
                    numberOfClosingParenthesisWeNeed--;

                if (numberOfClosingParenthesisWeNeed < 0)
                    return false;
            }

            return numberOfClosingParenthesisWeNeed == 0;
        }
    }
}
