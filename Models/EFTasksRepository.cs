namespace Mission08_Team0302._1.Models
{
    public class EFTasksRepository : iTasksRepository
    {
        private TaskContext context;
        public EFTasksRepository(TaskContext temp)
        {
            context = temp;
        }
        public List<Category> Categories => context.Categories.ToList();
        public List<Task> Tasks => context.Tasks.ToList();

        public void AddTask(Task task)
        {
            context.Add(task);
            context.SaveChanges();
        }

        public void UpdateTask(Task task)
        {
            context.Update(task);
            context.SaveChanges();
        }

        public void DeleteTask(Task task)
        {
            context.Remove(task);
            context.SaveChanges();
        }
    }
}
