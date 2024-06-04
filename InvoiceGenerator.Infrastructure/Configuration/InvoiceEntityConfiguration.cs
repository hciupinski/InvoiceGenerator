using InvoiceGenerator.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceGenerator.Infrastructure.Configuration;

public class InvoiceEntityConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable(nameof(Invoice)).HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();

        builder.HasMany<LineItem>(e => e.Items)
            .WithOne()
            .HasForeignKey(x => x.InvoiceId)
            .HasPrincipalKey(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Contractor>(e => e.Customer)
            .WithMany()
            .HasForeignKey(e => e.CustomerId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        
        builder.HasOne<Contractor>(e => e.Seller)
            .WithMany()
            .HasForeignKey(e => e.SellerId)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}