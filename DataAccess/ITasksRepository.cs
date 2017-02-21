using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.DataAccess{
    public interface ITasksRepository{

        List<Task> All();
        Task Get(int id);
        bool Delete(int id);
        void Update(Task task);
        void Add(Task task);
    }
}