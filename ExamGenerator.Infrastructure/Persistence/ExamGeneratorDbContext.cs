using ExamGenerator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamGenerator.Infrastructure.Persistence;

internal class ExamGeneratorDbContext(DbContextOptions<ExamGeneratorDbContext> options) : DbContext(options)
{
    internal DbSet<Customer> Customers{ get; set; }
    internal DbSet<Exam> Exams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}