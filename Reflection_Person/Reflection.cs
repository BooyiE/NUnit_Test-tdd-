using Rosyln_Create_A_Class;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection_Person
{
    public class Reflection
    {
        public Dictionary<string, string>ReflectionMethod()
        {
            var dictionary = new Dictionary<string, string>();
            var typePerson = typeof(Person);
            var personInstance = Activator.CreateInstance(typePerson);
            var setNameAndSurnameMethod = typePerson.GetMethod("SetNameAndSurname");
            setNameAndSurnameMethod.Invoke(personInstance, null);

            var SetGender = typePerson.GetMethod("SetGender", BindingFlags.NonPublic | BindingFlags.Instance);
            SetGender.Invoke(personInstance, null);

            PropertyInfo[] props = typePerson.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            foreach (var prop in props)
            {
                dictionary.Add(prop.Name, prop.GetValue(personInstance).ToString());
                //Console.WriteLine(prop.GetValue(instant));

            }
            return dictionary;
        }
    }
} 
