using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

// Register services and repositories for Dependency Injection using interfaces
// This allows for flexible, testable code and clear separation of concerns
builder.Services.AddScoped<BookingsApi.Services.IBookingService, BookingsApi.Services.BookingService>();
builder.Services.AddScoped<BookingsApi.Repositories.IBookingRepository, BookingsApi.Repositories.BookingRepository>();

// Add MVC controller support
builder.Services.AddControllers();

var app = builder.Build();

// Map controller endpoints
app.MapControllers();

app.Run();
