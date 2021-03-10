using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class XDocument : IXElement
    {
        private readonly List<IXElement> childrens;

        public string XName { get; }
        public string Comment { get;  }
        public XDocument(string _comment, params IXElement[] items) {
            childrens = new List<IXElement>();
            Comment = _comment;
            foreach (var _item in items) {
                childrens.Add(_item);
            }
        }
        public XDocument(string _comment)
        {
            childrens = new List<IXElement>();
            Comment = _comment;
        }
        public void Add(IXElement element)
        {
            childrens.Add(element);
        }
        public void Remove(IXElement element)
        {
            childrens.Remove(element);
        }
        public override string ToString()
        {
            var document = new StringBuilder().Append($"< !--{Comment}-->");
            document.Append("<Root>");
            foreach (var item in childrens) {
                document.Append(item.ToString());
            }
            document.Append(@"<\Root>");
            return document.ToString();
        }
        public List<IXElement> Elements()
        {
            return childrens;
        }
    }
}
