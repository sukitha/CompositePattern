using Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IXMLBuilder
    {
        public XDocument Root { get; }
        IXMLBuilder AddElement(string name, string value);
        IXMLBuilder AddElement(string name);
        IXMLBuilder MoveTo(string name);
        IXMLBuilder Reset();

    }
}
