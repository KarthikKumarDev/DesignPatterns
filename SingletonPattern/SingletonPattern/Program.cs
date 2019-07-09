using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonObject = SingletonClass.Instance;
            singletonObject.Name = "First obj value";

            var testSingletonObject = SingletonClass.Instance;
            Console.WriteLine("Test object Name :" + testSingletonObject.Name);

            Console.ReadKey();
        }
    }
}
