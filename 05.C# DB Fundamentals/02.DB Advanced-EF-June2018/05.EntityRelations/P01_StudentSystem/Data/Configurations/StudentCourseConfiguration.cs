namespace P01_StudentSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(c => new { c.CourseId, c.StudentId });

            builder
                .HasOne(s => s.Student)
                .WithMany(c => c.CourseEnrollments)
                .HasForeignKey(s => s.StudentId);

            builder
                .HasOne(c => c.Course)
                .WithMany(s => s.StudentsEnrolled)
                .HasForeignKey(c => c.CourseId);
        }
    }
}
