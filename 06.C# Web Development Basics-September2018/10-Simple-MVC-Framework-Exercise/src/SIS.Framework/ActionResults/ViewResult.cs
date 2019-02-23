using SIS.Framework.Contracts.ActionResults;
using System;

namespace SIS.Framework.ActionResults
{
    public class ViewResult : IViewable
    {
        public ViewResult(IRenderable view)
        {
            this.View = view;
        }

        public IRenderable View { get; set; }

        public string Invoke()
        {
           return this.View.Render();
        }
    }
}
