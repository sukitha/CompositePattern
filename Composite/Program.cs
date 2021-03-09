using Builder;
using Composite;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = new XDocument("This is the root element", 
                new XElement("child1", 
                    new XElement("child1.1", 
                        new XElement("child1.1.1", "1.1.1"))),
                new XElement("child2", "2"),
                new XElement("child3", "3"),
                new XElement("child4", "4"));
            var element5 = new XElement("child4", "5");
            document.Add(element5);
            Console.WriteLine(document);
            document.Remove(element5);
            Console.WriteLine(document);

            XDocument xdocument = new XMLBuilder("This is the root element")
                .AddElement("child1")
                .AddElement("child1.1")
                .AddElement("child1.1.1", "1.1.1")
                .Reset()
                .AddElement("child2", "2")
                .AddElement("child2", "3")
                .AddElement("child2", "4")
                .AddElement("child2", "5")
                .Root;

            Console.WriteLine(xdocument);
        }
    }
}
