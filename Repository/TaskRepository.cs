using Microsoft.EntityFrameworkCore;
using wa_todolist_backend.Data;
using wa_todolist_backend.Models;
using wa_todolist_backend.Repository.Interfaces;

namespace wa_todolist_backend.Repository
{
  public class TaskRepository : ITaskRepository
  {
    private readonly TasksSystemDBContext _dbContext;
    public TaskRepository(TasksSystemDBContext tasksSystemDBContext)
    {
        _dbContext = tasksSystemDBContext;
    }

    public async Task<List<TaskModel>> GetAll()
    {
      return await _dbContext.Tasks.ToListAsync();
    }

    public async Task<TaskModel> ById(int id)
    {
      return await _dbContext.Tasks.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<TaskModel> Add(TaskModel task)
    {
      await _dbContext.Tasks.AddAsync(task);
      await _dbContext.SaveChangesAsync();

      return task;
    }

    public async Task<TaskModel> Update(TaskModel task, int id)
    {
        TaskModel taskById = await ById(id);

        if(taskById == null)
        {
            throw new Exception($"Task de ID: {id} não encontrada no banco de dados");
        }

        taskById.Task = task.Task;
        taskById.IsCompleted = task.IsCompleted;

        _dbContext.Tasks.Update(taskById);
        await _dbContext.SaveChangesAsync();

        return taskById;
    }

    public async Task<bool> Delete(int id)
    {
        TaskModel taskById = await ById(id);

        if(taskById == null)
        {
            throw new Exception($"Task de ID: {id} não encontrada no banco de dados");
        }

        _dbContext.Tasks.Remove(taskById);
        await _dbContext.SaveChangesAsync();

        return true;
    }
  }
}