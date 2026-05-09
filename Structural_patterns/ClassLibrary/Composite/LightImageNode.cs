using ClassLibrary.Composite.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Composite
{
    public class LightImageNode : LightNode
    {
        private string href;
        private IImageLoadStrategy strategy;

        public LightImageNode(string href)
        {
            this.href = href;
            SetStrategy();
        }

        private void SetStrategy()
        {
            if (href.StartsWith("http"))
            {
                strategy = new NetworkImageLoadStrategy();
            }
            else
            {
                strategy = new FileImageLoadStrategy();
            }
        }

        public override string OuterHTML()
        {
            return $"<img src=\"{href}\" />";
        }

        public override string InnerHTML()
        {
            return "";
        }

        public string LoadImage()
        {
            return strategy.Load(href);
        }
    }
}
