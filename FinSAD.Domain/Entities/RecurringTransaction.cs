namespace FinSAD.Domain.Entities
{
    public class RecurringTransaction
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Frequency { get; set; } = string.Empty;

        public void SetRecurrence() { }
        public void ModifyRecurrence() { }
    }
}