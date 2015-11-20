namespace _05.HtmlDispatcher
{
    public static class HtmlDispatcher
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder element = new ElementBuilder("img");
            element.AddAttribute("src", imageSource);
            element.AddAttribute("alt", alt);
            element.AddAttribute("title", title);
            return element.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder element = new ElementBuilder("a");
            element.AddAttribute("href", url);
            element.AddAttribute("title", title);
            element.AddContent(text);
            return element.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder element = new ElementBuilder("input");
            element.AddAttribute("type", type);
            element.AddAttribute("name", name);
            element.AddAttribute("value", value);
            return element.ToString();
        }
    }
}
