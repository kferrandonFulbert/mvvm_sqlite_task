using EasyTask.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRepository = EasyTask.Model.Repository;
using KFTaskModel = EasyTask.Model;
using EasyTask.Model;

namespace EasyTask.ViewModel
{
    internal class TaskViewModel
    {
        private TRepository.TaskRepository taskRepository;

        public List<KFTaskModel.Task> Tasks { get; set; }
        public KFTaskModel.Task SelectedTask { get; set; }

        public TaskViewModel()
        {
            taskRepository = new TRepository.TaskRepository();
            Tasks = taskRepository.GetAllTasks();
        }


        public void AddTask()
        {
            taskRepository.AddTask(SelectedTask);
            Tasks = taskRepository.GetAllTasks();
            SelectedTask = null;
        }

        public void UpdateTask()
        {
            taskRepository.UpdateTask(SelectedTask);
            Tasks = taskRepository.GetAllTasks();
            SelectedTask = null;
        }

        public void DeleteTask()
        {
            taskRepository.DeleteTask(SelectedTask.Id);
            Tasks = taskRepository.GetAllTasks();
            SelectedTask = null;
        }
    }
}
