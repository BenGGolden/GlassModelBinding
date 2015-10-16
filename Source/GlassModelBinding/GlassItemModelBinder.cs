using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Presentation;

namespace GlassModelBinding
{
    public class GlassItemModelBinder : IModelBinder
    {
        private readonly ISitecoreContext _sitecoreContext;

        public GlassItemModelBinder(ISitecoreContext sitecoreContext)
        {
            Assert.ArgumentNotNull(sitecoreContext, "sitecoreContext");
            _sitecoreContext = sitecoreContext;
        }

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            return _sitecoreContext.CreateType(bindingContext.ModelType, RenderingContext.Current.Rendering.Item, false,
                false, null);
        }
    }
}