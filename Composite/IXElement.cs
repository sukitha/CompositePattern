using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IXElement
    {
        string XName { get; }
        void Add(IXElement element);
        void Remove(IXElement element);
        List<IXElement> Elements();

    }
}
