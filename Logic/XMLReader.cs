using System.Xml.Linq;

namespace BlazorApp1.Logic
{
    public class XMLReader
    {
        public XElement e { get; set; }

        public List<XMLReader> eChilds = new List<XMLReader>();

        public List<XAttribute> a;
        public XMLReader(XElement e)
        {
            this.e = e;
            foreach(var el in this.e.Elements().ToList())
            {
                eChilds.Add(new XMLReader(el));
            }
            a = e.Attributes().ToList();
        }
    }
}
