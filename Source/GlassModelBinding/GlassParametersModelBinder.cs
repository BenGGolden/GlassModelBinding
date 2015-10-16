using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Presentation;

namespace GlassModelBinding
{
    public class GlassParametersModelBinder : IModelBinder
    {
        private readonly IGlassHtml _glassHtml;

        public GlassParametersModelBinder(IGlassHtml glassHtml)
        {
            Assert.ArgumentNotNull(glassHtml, "glassHtml");
            _glassHtml = glassHtml;
        }
        
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var method =
                _glassHtml.GetType()
                    .GetMethod("GetRenderingParameters", new[] {typeof (string)})
                    .MakeGenericMethod(bindingContext.ModelType);
            return method.Invoke(_glassHtml,
                new object[] {RenderingContext.Current.Rendering[GlassHtml.Parameters]});
        }
    }
}