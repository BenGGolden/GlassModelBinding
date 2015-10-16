using System;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Diagnostics;

namespace GlassModelBinding
{
    public class GlassModelBinderProvider : IModelBinderProvider
    {
        private readonly Type _itemBaseType;
        private readonly Type _parametersBaseType;

        public GlassModelBinderProvider(Type itemBaseType, Type parametersBaseType)
        {
            Assert.ArgumentNotNull(itemBaseType, "itemBaseType");
            Assert.ArgumentNotNull(parametersBaseType, "parametersBaseType");
            
            _itemBaseType = itemBaseType;
            _parametersBaseType = parametersBaseType;
        }

        public IModelBinder GetBinder(Type modelType)
        {
            if (_parametersBaseType.IsAssignableFrom(modelType))
            {
                return new GlassParametersModelBinder(new GlassHtml(SitecoreContext.GetFromHttpContext()));
            }

            if (_itemBaseType.IsAssignableFrom(modelType))
            {
                return new GlassItemModelBinder(SitecoreContext.GetFromHttpContext());
            }

            return null;
        }
    }
}