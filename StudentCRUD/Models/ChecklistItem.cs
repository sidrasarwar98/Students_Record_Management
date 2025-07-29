namespace StudentCRUD.Models
{
    public class ChecklistItem
    {
        public int ItemId { get; set; }
        public int TemplateId { get; set; }
        public string ItemText { get; set; }
        public int ItemOrder { get; set; }
        public bool IsMandatory { get; set; }
    }
}
