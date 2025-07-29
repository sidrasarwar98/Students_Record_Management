namespace StudentCRUD.Models
{
    public class AuditPlan
    {
        public int AuditPlanId { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
