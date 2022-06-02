using Microsoft.VisualStudio.TestTools.UnitTesting;
using MashikAssesment.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashikAssesment.Business.Tests
{
    [TestClass()]
    public class StringOperationsTests
    {
        [DataRow("Text without parentheses")]
        [DataRow("( )")]
        [DataRow("I have ( and )")]
        [DataRow("I have () and ()")]
        [DataRow("I have ( ( and ) )")]
        [DataTestMethod]
        public void ValidateParentheses_should_return_true(string input)
        {
            Assert.IsTrue(StringOperations.ValidateParentheses(input));
        }

        [DataRow("(")]
        [DataRow(")")]
        [DataRow("())(")]
        [DataRow("I have ( and ) )")]
        [DataRow("I have ( ( and ) ")]
        [DataRow("safasfd)asdfsadf(asdf")]
        [DataTestMethod]
        public void ValidateParentheses_should_return_false(string input)
        {
            Assert.IsFalse(StringOperations.ValidateParentheses(input));
        }

        [DataRow("")]
        [DataRow(" ")]
        [DataTestMethod]
        public void ValidateParentheses_should_throw_exception(string input)
        {
            Assert.ThrowsException<Exception>(() => StringOperations.ValidateParentheses(input));
        }
    }
}