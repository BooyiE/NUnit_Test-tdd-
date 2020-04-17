using System;

namespace Reflection_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflection reflection = new Reflection();
            var FromReflection = reflection.ReflectionMethod();
            FromReflection.TryGetValue("Name", out string Name);
            FromReflection.TryGetValue("Surname", out string Surname);
            FromReflection.TryGetValue("Gender", out string Gender);
            Console.WriteLine(Name + " " + Surname + " " + Gender);
            Console.Read();
        }
    }
}
