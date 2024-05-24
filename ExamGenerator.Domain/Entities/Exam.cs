namespace ExamGenerator.Domain.Entities;

public class Exam
{
    public Guid ExamId { get; set; }
    public string FileName { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}