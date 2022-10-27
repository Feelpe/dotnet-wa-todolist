using Microsoft.EntityFrameworkCore;
using wa_todolist_backend.Models;
using wa_todolist_backend.Data.Map;

namespace wa_todolist_backend.Data;

public class TasksSystemDBContext : DbContext
{
  public TasksSystemDBContext(DbContextOptions<TasksSystemDBContext> options)
    : base(options)
  {
  }

  public DbSet<TaskModel> Tasks { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration(new TaskMap());
    base.OnModelCreating(modelBuilder);
  }
}
