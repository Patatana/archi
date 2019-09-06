using MicroServiceMCQ.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceMCQ.Persistance.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Title).IsRequired().HasMaxLength(255);
            builder.Property(q => q.Value).IsRequired();
            builder.HasMany(q => q.Answers).WithOne(d => d.Question);
            builder.HasOne(q => q.QuestionType).WithMany(t => t.Questions);
        }
    }
}
