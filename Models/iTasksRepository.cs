namespace Mission08_Team0302._1.Models
{
    public interface iTasksRepository
    {
        List<Category> Categories{ get; }
        List<Task> Tasks{get;}
        public void AddTask(Task task);
        
        public void UpdateTask(Task task);
        
        public void DeleteTask(Task task);
    }
}
