namespace wa_todolist_backend.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }
    }
}