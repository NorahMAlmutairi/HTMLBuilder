using System;

namespace HTMLBuilder
{
    class Program
    {
        class HTMLBuilder
        {
            public string html;

            public HTMLBuilder OpenTag(string tag)
            {
                html += "<" + tag + ">";
                return this;
            }

            public HTMLBuilder Body(string body)
            {
                html += body;
                return this;

            }

            public HTMLBuilder ClosingTag(string tag)
            {
                html += "</" + tag + ">";
                return this;

            }

            public string Get()
            {
                return html;
            }


        }
        static void Main(string[] args)
        {
            HTMLBuilder myHtmlPage = new HTMLBuilder();

            myHtmlPage.OpenTag("div").Body("Welcome to C#").ClosingTag("div");
            Console.WriteLine(myHtmlPage.Get());
        }
    }
}
