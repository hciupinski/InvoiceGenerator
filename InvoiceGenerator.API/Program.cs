using InvoiceGenerator.Application.Queries.GetInvoices;
using InvoiceGenerator.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("InvoiceGenerator") ??
                       throw new InvalidOperationException("Connection string 'InvoiceGenerator' not found.");

builder.Services.AddDbContext<InvoiceGeneratorDbContext>(options =>
    options.UseNpgsql(connectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/invoices", async (IMediator mediator, CancellationToken cancellationToken) =>
    {
        await mediator.Send(new GetInvoicesQuery(), cancellationToken);
    })
    .WithName("GetInvoices")
    .WithOpenApi();

app.Run();