using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.DataAccess
{
    public class TasksRepository : ITasksRepository
    {
        private static List<Task> tasks;

        public TasksRepository()
        {
            InitData();
        }

        public void Add(Task task)
        {
            tasks.Add(task);
        }

        public List<Task> All()
        {
            return tasks;
        }

        public bool Delete(int id)
        {
            Task task = tasks.Find(t => t.Id == id);
            bool deleted = false;
            if (task != null)
            {
                tasks.Remove(task);
                deleted = true;
            }
            return deleted;
        }

        public Task Get(int id)
        {
            Task task = tasks.Find(t => t.Id == id);
            return task;
        }

        public void Update(Task task)
        {
            throw new NotImplementedException();
        }

        #region private methods
        private static void InitData()
        {
            tasks = new List<Task>();
            Task task1 = new Task() { Id = 1, Name = "Task1", Notes = "note1" };
            Task task2 = new Task() { Id = 2, Name = "Task2", Notes = "note2" };
            Task task3 = new Task() { Id = 3, Name = "Task3", Notes = "note3" };
            Task task4 = new Task() { Id = 4, Name = "Task4", Notes = "note4" };
            Task task5 = new Task() { Id = 5, Name = "Task5", Notes = "note5" };
            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
        }
        #endregion
    }
}