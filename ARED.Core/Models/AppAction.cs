using ARED.Entities.Enums;

namespace ARED.Core.Models
{
    public class AppAction : BaseEntity
    {
        public string? Name { get; set; }
        public ActionType Type { get; set; }
        public string? Properties { get; set; }
    }
}
