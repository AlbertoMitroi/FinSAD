using FinSAD.Domain.Enums;

namespace FinSAD.Domain.Entities
{
    public class FinanceReport
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public ReportFormat Format { get; set; } = new ReportFormat();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public void Generate() { }
        public void Export() { }
    }
}