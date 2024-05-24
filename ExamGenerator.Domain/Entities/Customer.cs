namespace ExamGenerator.Domain.Entities;

public class Customer
{
    public Guid CustomerId { get; set; }
    public string UserName { get; set; } = default!;
    public List<Exam> Exams { get; set; } = [];
    


}