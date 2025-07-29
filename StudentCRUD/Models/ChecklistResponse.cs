namespace StudentCRUD.Models
{
    public class ChecklistResponse
    {
        public int ResponseId { get; set; }
        public int ChecklistId { get; set; }
        public int ItemId { get; set; }
        public string ResponseText { get; set; }
        public string ResponseStatus { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int? RespondedBy { get; set; }
    }
}
