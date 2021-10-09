using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public IResult Add(Task task)
        {
            _taskDal.Add(task);
            return new SuccessResult(Messages.TaskAdded);
        }

        public IResult Delete(Task task)
        {
            _taskDal.Delete(task);
            return new SuccessResult(Messages.TaskDeleted);
        }
        public IResult Update(Task task)
        {
            _taskDal.Update(task);
            return new SuccessResult(Messages.TaskUpdate);
        }

        public IDataResult<List<Task>> GetAll()
        {
            return new SuccessDataResult<List<Task>>(_taskDal.GetAll(),Messages.TasksListed);
        }

        public IDataResult<Task> GetById(int id)
        {
            return new SuccessDataResult<Task>(_taskDal.Get(t => t.Id == id));
        }

        public IDataResult<List<TaskDetailDto>> GetTaskDetails()
        {
            return new SuccessDataResult<List<TaskDetailDto>>(_taskDal.GetTaskDetails());
        }

        
    }
}
