using ARED.Entities.Enums;

namespace ARED.Core.Models
{
    public class AppRule : BaseEntity
    {
        public string? Name { get; set; }
        public EventType? Type { get; set; }
    }
}
