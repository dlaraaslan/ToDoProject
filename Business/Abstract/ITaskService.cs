using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskService
    {
        IDataResult<List<Task>> GetAll();
        IDataResult<Task> GetById(int id);
        IDataResult<List<TaskDetailDto>> GetTaskDetails();
        IResult Add(Task task);
        IResult Update(Task task);
        IResult Delete(Task task);

    }
}
