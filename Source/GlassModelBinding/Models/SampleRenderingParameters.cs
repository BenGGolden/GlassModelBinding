using Glass.Mapper.Sc.Configuration.Attributes;

namespace GlassModelBinding.Models
{
    [SitecoreType(TemplateId = "{3A3363CD-86E5-467A-B8D9-61D922EE8871}", AutoMap = true)]
    public class SampleRenderingParameters : IGlassRenderingParameters
    {
        public string CssClass { get; set; }
    }
}