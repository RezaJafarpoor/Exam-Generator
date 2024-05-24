using ExamGenerator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamGenerator.Infrastructure.Persistence;

internal class ExamGeneratorDbContext(DbContextOptions options) : DbContext
{

    internal DbSet<Customer> Customers;
    internal DbSet<Exam> Exams;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}