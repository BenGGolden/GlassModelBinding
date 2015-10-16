using System;

namespace GlassModelBinding.Models
{
    public interface IGlassItem
    {
        Guid Id { get; }
        Guid TemplateId { get; }
        string Url { get; }
    }
}