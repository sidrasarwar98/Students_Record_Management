namespace StudentCRUD.Models
{
    public class Risk
    {
        public int RiskId { get; set; }
        public string RiskName { get; set; }
        public string Description { get; set; }
        public int RiskCategoryId { get; set; }
        public int Likelihood { get; set; }
        public int Impact { get; set; }
        public int RiskScore => Likelihood * Impact;
    }
}
