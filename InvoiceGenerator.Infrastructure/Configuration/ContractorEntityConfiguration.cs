using InvoiceGenerator.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceGenerator.Infrastructure.Configuration;

public class ContractorEntityConfiguration : IEntityTypeConfiguration<Contractor>
{
    public void Configure(EntityTypeBuilder<Contractor> builder)
    {
        builder.ToTable(nameof(Contractor)).HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
    }
}