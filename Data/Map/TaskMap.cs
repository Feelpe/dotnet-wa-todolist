using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wa_todolist_backend.Models;

namespace wa_todolist_backend.Data.Map
{
  public class TaskMap : IEntityTypeConfiguration<TaskModel>
  {
    public void Configure(EntityTypeBuilder<TaskModel> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Task);
      builder.Property(x => x.IsCompleted);
    }
  }
}