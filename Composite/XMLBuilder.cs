using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class XMLBuilder : IXMLBuilder
    {
        public XDocument Root { get; }
        internal IXElement Current { get; set; }
        public XMLBuilder(string comment) {
            Root = new XDocument(comment);
            Current = Root;
        }
        public IXMLBuilder AddElement( string name, string value)
        {
            Current.Add(new XElement(name, value));
            return this;
        }
        public IXMLBuilder MoveTo(string name)
        {
            List<IXElement> filtered = Current.Elements().Where(x => x.XName == name).ToList();
            Current = filtered.Count > 0 ? filtered[0] : Root;
            return this;
        }
        public IXMLBuilder Reset()
        {
            Current = Root;
            return this;
        }
        public IXMLBuilder AddElement(string name)
        {
            var temp = new XElement(name);
            Current.Add(temp);
            Current = temp;
            return this;
        }
    }
}
