using System;

namespace Association
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
