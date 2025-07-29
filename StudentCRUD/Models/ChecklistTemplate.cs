//namespace StudentCRUD.Models
//{
//    public class ChecklistTemplate
//    {
//        public int TemplateId { get; set; }
//        public string TemplateName { get; set; }
//        public string Description { get; set; }
//        public string Content { get; set; }
//        public int? RiskCategoryId { get; set; }
//        public int? SystemId { get; set; }
//        public bool IsActive { get; set; }
//        public List<ChecklistItem> Items { get; set; } = new List<ChecklistItem>();
//    }
//}
namespace StudentCRUD.Models
{
    public class ChecklistTemplate
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int? RiskCategoryId { get; set; }
        public int? SystemId { get; set; }
        public bool IsActive { get; set; }
        public List<ChecklistItem> Items { get; set; } = new List<ChecklistItem>();

        // 👇 Add these two properties to fix the controller error
        public string CategoryName { get; set; }
        public string SystemName { get; set; }
    }
}

