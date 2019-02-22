using Logger.Models.Contracts;
using System;
namespace Logger.Models.Factories
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutType)
        {
            ILayout layout = null;

            switch (layoutType)
            {
                case "simpleLayout":
                    layout = new SimpleLayout();
                    break;
                default:
                    throw new ArgumentException("Invalid Layout Type!");               
            }

            return layout;
        }

    }
}
