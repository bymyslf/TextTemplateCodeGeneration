using System;

namespace TextTemplateCodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            var template = new DocumentTemplate()
            {
                Source = @"

                Foo:     string Prop1, 
                         int Prop2;

                Bar:     string FirstName,
                         string LastName,
                         int Age;
                "
            };

            var classes = template.TransformText();
            Console.WriteLine(classes);
            Console.ReadLine();
        }
    }
}
