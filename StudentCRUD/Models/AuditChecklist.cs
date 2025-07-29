namespace StudentCRUD.Models
{
    public class AuditChecklist
    {
        public int ChecklistId { get; set; }
        public int AuditPlanDetailId { get; set; }
        public int TemplateId { get; set; }
        public string ChecklistName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public List<ChecklistResponse> Responses { get; set; } = new List<ChecklistResponse>();
    }
}
