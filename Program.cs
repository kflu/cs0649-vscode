using System;

namespace cs0649_vscode
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo();
            foo.X = "hi";
            Console.WriteLine(foo.X);
        }

        public class Foo
        {
            public string X;
            public string Y;
        }
    }
}
