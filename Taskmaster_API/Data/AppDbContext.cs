using System;
using Microsoft.EntityFrameworkCore;
using Taskmaster_API.Data;
using Taskmaster_Services.Domain.Models;

namespace Taskmaster_API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<UserModel> Users { get; set; }
    public DbSet<TaskModel> Tasks { get; set; }
    public DbSet<CategoryModel> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Here you can configure table names, relationships, keys, etc.
        base.OnModelCreating(modelBuilder);
    }
}
