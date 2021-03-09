using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class XElement : IXElement
    {
        public string XValue { get; }

        private List<IXElement> childrens
        {
            get;
        }

        public string XName { get; }

        public XElement(string name)
        {
            XName = name;
            childrens = new List<IXElement>();

        }
        public XElement(string name, string value)
        {
            XName = name;
            XValue = value;
            childrens = new List<IXElement>();

        }
        public XElement(string name, params IXElement[] items)
        {
            childrens = new List<IXElement>();
            XName = name;
            foreach (var _item in items)
            {
                childrens.Add(_item);
            }
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
            var document = new StringBuilder();
            document.Append($"<{XName}>");
            if (childrens.Count > 0)
            {
                foreach (var item in childrens)
                {
                    document.Append(item.ToString());
                }
            }
            else {
                if(XValue != null)
                document.Append(XValue.ToString());
            }
            document.Append(@"<\"+XName+">");
            return document.ToString();
        }
        public List<IXElement> Elements()
        {
            return childrens;
        }
    }
}
