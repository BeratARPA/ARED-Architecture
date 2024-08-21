namespace ARED.Core.Models
{
    public class RuleActionMap : BaseEntity
    {
        public int AppRuleId { get; set; }
        public int AppActionId { get; set; }
        public int SortOrder { get; set; }
    }
}
