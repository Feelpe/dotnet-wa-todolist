using wa_todolist_backend.Models;

namespace wa_todolist_backend.Repository.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskModel>> Get();
        Task<TaskModel> GetById(int id);
        Task<TaskModel> Post(TaskModel task);
        Task<TaskModel> Update(TaskModel task, int id);
        Task<bool> Delete(int id);
    }
}