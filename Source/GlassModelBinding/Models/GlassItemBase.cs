using System;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace GlassModelBinding.Models
{
    public class GlassItemBase : IGlassItem
    {
        [SitecoreId]
        public virtual Guid Id { get; private set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid TemplateId { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }
    }
}