using System.Web.Mvc;
using GlassModelBinding.Models;
using Sitecore.Pipelines;

namespace GlassModelBinding.Pipelines.Loader
{
    public class AddModelBinderProvider
    {
        public void Process(PipelineArgs args)
        {
            ModelBinderProviders.BinderProviders.Add(new GlassModelBinderProvider(typeof (IGlassItem),
                typeof (IGlassRenderingParameters)));
        }
    }
}