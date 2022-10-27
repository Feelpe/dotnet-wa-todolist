using Microsoft.EntityFrameworkCore;
using wa_todolist_backend.Models;

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
    base.OnModelCreating(modelBuilder);
  }
}
