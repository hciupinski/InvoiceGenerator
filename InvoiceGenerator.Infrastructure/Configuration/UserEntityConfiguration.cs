using InvoiceGenerator.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceGenerator.Infrastructure.Configuration;

public class SettingsEntityConfiguration : IEntityTypeConfiguration<Settings>
{
    public void Configure(EntityTypeBuilder<Settings> builder)
    {
        builder.ToTable(nameof(Contractor)).HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
    }
}