using System.IO;

namespace JsTreeviewBuilder.Core
{
    class Builder
    {
        private string _outputHtmlPath;
        public Builder(string outputHtmlPath)
        {
            _outputHtmlPath = outputHtmlPath;
        }

        public void Process()
        {
            var jsonTopObject = new JsonItem($"I am the top object");
            jsonTopObject.AddChild(new JsonItem("second level object 1"));
            jsonTopObject.AddChildren(new JsonItem("second level object 2"), new JsonItem("second level object 3"));
            jsonTopObject.children[0].AddChild(new JsonItem("even a third level object!"));

            var jsonStr = jsonTopObject.ToString();

            var htmlTemplateStr = File.ReadAllText("index.htm");
            var htmlStr = htmlTemplateStr.Replace("[[[data]]]", jsonStr);
            File.WriteAllText(_outputHtmlPath, htmlStr);
        }
    }
}
