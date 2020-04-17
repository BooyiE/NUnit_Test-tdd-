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
            var instant = Activator.CreateInstance(typePerson);
            var getmethodsetvalue = typePerson.GetMethod("PublicValues");
            getmethodsetvalue.Invoke(instant, null);

            var getmethodgender = typePerson.GetMethod("GenderValue", BindingFlags.NonPublic | BindingFlags.Instance);
            getmethodgender.Invoke(instant, null);

            PropertyInfo[] props = typePerson.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            foreach (var prop in props)
            {
                dictionary.Add(prop.Name, prop.GetValue(instant).ToString());
                //Console.WriteLine(prop.GetValue(instant));

            }
            return dictionary;
        }
    }
} 
