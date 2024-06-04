using InvoiceGenerator.Domain.Models;
using InvoiceGenerator.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.Infrastructure.DataAccess;

public class InvoiceGeneratorDbContext(DbContextOptions<InvoiceGeneratorDbContext> options)
    : DbContext(options)
{
    public DbSet<Settings> Settings { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<LineItem> LineItems { get; set; }
    public DbSet<Contractor> Contractors { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("invoicegenerator");
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new SettingsEntityConfiguration());
        builder.ApplyConfiguration(new ContractorEntityConfiguration());
        builder.ApplyConfiguration(new InvoiceEntityConfiguration());
        builder.ApplyConfiguration(new LineItemEntityConfiguration());
    }
}