using Application;
using Application.Transactions.Details;
using Application.Transactions.Get;
using Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/companies/{companyId}/transactions", async (int companyId, ISender sender, CancellationToken cancellationToken) => 
{
    var query = new GetTransactionsQuery(companyId);
    var transactions = await sender.Send(query, cancellationToken);
    return Results.Ok(transactions);
});

app.MapGet("/companies/{companyId}/transactions/{transactionId}/details", async (int companyId, int transactionId, ISender sender, CancellationToken cancellationToken) =>
{
    var query = new GetTransactionDetailsQuery(transactionId);
    var transactionDetails = await sender.Send(query, cancellationToken);
    return Results.Ok(transactionDetails);
});

app.Run();
