using Microsoft.EntityFrameworkCore;
using Taskmaster_API.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=TaskMaster.db")
);

var app = builder.Build();

app.Run();
