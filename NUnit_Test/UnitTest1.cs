using Rosyln_Create_A_Class;
using NUnit.Framework;
using Reflection_Person;
using System.Collections.Generic;

namespace NUnit_Test
{
    [TestFixture]
    public class Tests
    {
        Reflection reflection;
        Person person;
        Dictionary<string, string> dictionaryFromReflectionMethod;
        [SetUp]
        public void Setup()
        {
            reflection = new Reflection();
            person = new Person();
            person.PublicValues();
            dictionaryFromReflectionMethod = reflection.ReflectionMethod();
        }

        [Test]
        public void TestName()
        {
            dictionaryFromReflectionMethod.TryGetValue("Name", out string Name);
            Assert.AreEqual(person.Name, Name);
        }

        [Test]
        public void TestSurname()
        {
            dictionaryFromReflectionMethod.TryGetValue("Surname", out string Surname);
            Assert.AreEqual(person.Surname, Surname);
        }

        [Test]
        public void TestGender()
        {
            dictionaryFromReflectionMethod.TryGetValue("Gender", out string Gender);
            Assert.AreEqual("Female", Gender);
        }
    }
}