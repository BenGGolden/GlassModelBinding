using Glass.Mapper.Sc.Configuration.Attributes;

namespace GlassModelBinding.Models
{
    [SitecoreType(TemplateId = "{76036F5E-CBCE-46D1-AF0A-4143F9B557AA}", AutoMap = true)]
    public class SampleItem : GlassItemBase
    {
        public virtual string Title { get; set; }

        public virtual string Text { get; set; }
    }
}