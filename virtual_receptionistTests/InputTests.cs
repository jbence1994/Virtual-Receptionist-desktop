﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace virtual_receptionist.Tests
{
    [TestClass()]
    public class InputTests
    {
        /// <summary>
        /// Input ellenőrző osztály egy példánya
        /// </summary>
        private Input input;

        #region IsEmpty() tesztek

        /// <summary>
        /// Tesztmetódus: ha az input nem üres
        /// </summary>
        [TestMethod()]
        public void IsEmptyTest_InCaseInputIsNotEmpty()
        {
            input = new Input("test");

            bool expected = false;
            bool actual = input.IsEmpty();
            Assert.AreEqual(expected, actual, "Nem bukik a teszt nem üres inputra");
        }
        /// <summary>
        /// Tesztmetódus: ha az input üres
        /// </summary>
        [TestMethod()]
        public void IsEmptyTest_InCaseInputIsEmpty()
        {
            input = new Input("");

            bool expected = true;
            bool actual = input.IsEmpty();
            Assert.AreEqual(expected, actual, "Bukik a tezt üres inputra");

        }

        #endregion

        #region IsValidEmailAddress() tesztek

        /// <summary>
        /// Tesztmetódus: ha az input nem érvényes e-mail cím formátumú
        /// </summary>
        [TestMethod()]
        public void IsValidEmailAddressTest_InCaseInputIsNotValidEmail()
        {
            input = new Input("test.com");

            bool expected = false;
            bool actual = input.IsValidEmailAddress();
            Assert.AreEqual(expected, actual, "Nem bukik a teszt rossz e-mail inputra");
        }
        /// <summary>
        /// Tesztmetódus: ha az input érvényes e-mail cím formátumú
        /// </summary>
        [TestMethod()]
        public void IsValidEmailAddressTest_InCaseInputIsValidEmail()
        {
            input = new Input("test@test.co.uk");

            bool expected = true;
            bool actual = input.IsValidEmailAddress();
            Assert.AreEqual(expected, actual, "Bukik a teszt jó e-mail inputra");
        }

        #endregion

        #region FirstLetterIsUppercaseCharacter() tesztek

        /// <summary>
        /// Tesztmetódus: ha az input első kezdőbetűje kisbetű
        /// </summary>
        [TestMethod()]
        public void FirstLetterIsUppercaseCharacterTest_InCaseFirstLetterIsLowercase()
        {
            input = new Input("test");

            bool expected = false;
            bool actual = input.FirstLetterIsUppercaseCharacter();
            Assert.AreEqual(expected, actual, "Nem bukik a teszt rossz inputra");
        }
        /// <summary>
        /// Tesztmetódus: ha az input első kezdőbetűje nagybetű
        /// </summary>
        [TestMethod()]
        public void FirstLetterIsUppercaseCharacterTest_InCaseFirstLetterIsUppercase()
        {
            input = new Input("Test");

            bool expected = true;
            bool actual = input.FirstLetterIsUppercaseCharacter();
            Assert.AreEqual(expected, actual, "Bukik a teszt jó inputra");
        }

        #endregion
    }
}